using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web;
using Twitch.Authentication.Access;
using Twitch.Exceptions;

namespace Twitch.Authentication
{
    public class OAuthAuthorizationCodeGrantFlow
    {
        private const string RepsonseType = "code";
        private const string GrantType = "authorization_code";

        private readonly TwitchAuthenticator _auth;
        private bool ForceVerify { get; }
        private Uri RedirectUri { get; }
        private Scopes Scopes { get; }

        internal OAuthAuthorizationCodeGrantFlow(TwitchAuthenticator auth, bool forceVerify, Uri redirectUri, Scopes scopes)
        {
            this._auth = auth;
            ForceVerify = forceVerify;
            this.RedirectUri = redirectUri;
            this.Scopes = scopes;
        }

        public Uri CreateUri(string? state = null) =>
            new(AuthenticationEndpoints.OAuthAuthorize +
                $"?client_id={_auth.Application.Id}" +
                $"&force_verify={ForceVerify}" +
                $"&redirect_uri={RedirectUri.OriginalString}" +
                $"&response_type={RepsonseType}" +
                $"&scope={HttpUtility.UrlEncode(Scopes.GetString())}" +
                (state is not null ? $"&state={state}" : ""));

        public string TryGetCode(string uri, string? state = null) => TryGetCode(new Uri(uri), state);
        public string TryGetCode(Uri uri, string? state = null)
        {
            NameValueCollection query = HttpUtility.ParseQueryString(uri.Query);

            string? receivedState = query.Get("state");
            if (receivedState != state)
            {
                throw new Exception();
            }

            string? code = query.Get("code");

            if (code is not null)
            {
                string? scope = query.Get("scope");

                if (scope is not null)
                {
                    Scopes scopes = new(scope);

                    if(Scopes == scopes)
                    return code;
                }
            }

            string? error = query.Get("error");

            if (error is not null)
            {
                string? errorDescription = query.Get("error_description");

                if (errorDescription is not null)
                {
                    throw new Exception(error + " | " + errorDescription);
                }
            }

            throw new Exception();
        }



        internal HttpRequestMessage CreateRequest(string code) => new(HttpMethod.Post, AuthenticationEndpoints.OAuthToken)
        {
            Content = new ByteArrayContent(Encoding.UTF8.GetBytes($"client_id={_auth.Application.Id}&client_secret={_auth.Application.Secret}&code={code}&grant_type={GrantType}&redirect_uri={RedirectUri.OriginalString}"))
            {
                Headers =
                {
                    ContentType = new MediaTypeHeaderValue(MediaTypeNames.Application.FormUrlEncoded)
                }
            }
        };
        internal async Task<UserAccess> TryGetUserAccess(string code)
        {
            HttpRequestMessage request = CreateRequest(code);
            HttpResponseMessage response = await _auth.SendAsync(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new TwitchApiException($"{response.StatusCode} | {response.ReasonPhrase}", request, response);
            else
                return (await response.Content.ReadFromJsonAsync<UserAccess>())!;
        }

        [JsonConverter(typeof(JsonConverter))]
        public class UserAccess : TwitchUserAccess
        {

            public string RefreshToken { get; private set; }

            private UserAccess() : base()
            {
                RefreshToken = null!;
            }
            internal UserAccess(string token, string refreshToken, string type, Scopes scopes) : base(token, type, scopes)
            {
                RefreshToken = refreshToken;
            }

            private class JsonConverter : JsonConverter<UserAccess>
            {
                public override UserAccess Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
                {
                    UserAccess access = new();
                    
                    if (reader.TokenType == JsonTokenType.StartObject)
                    {
                        while (reader.TokenType != JsonTokenType.EndObject)
                        {
                            reader.Read();

                            if (reader.TokenType == JsonTokenType.PropertyName)
                            {
                                string propertyName = reader.GetString()!;
                                reader.Read();

                                switch (propertyName)
                                {
                                    case "access_token":

                                        access.Token = reader.GetString()!;

                                        break;

                                    case "token_type":

                                        access.Type = reader.GetString()!;

                                        break;

                                    case "refresh_token":

                                        access.RefreshToken = reader.GetString()!;

                                        break;

                                    case "expires_in":
                                        break;

                                    case "scope":

                                        if (reader.TokenType is JsonTokenType.StartArray)
                                        {
                                            reader.Read();
                                            List<string> scopes = [];

                                            while (reader.TokenType is not JsonTokenType.EndArray)
                                            {
                                                scopes.Add(reader.GetString()!);
                                                reader.Read();
                                            }
                                        }

                                        break;

                                    default:
                                        break;
                                }
                            }
                        }
                    }

                    if(access.Token is not null && access.Type is not null && access.RefreshToken is not null)
                        return access;
                    else
                        throw new JsonException();
                }

                public override void Write(Utf8JsonWriter writer, UserAccess userAccessAcgf, JsonSerializerOptions options)
                {
                    writer.WriteStartObject();
                    writer.WriteString("access_token", userAccessAcgf.Token);
                    writer.WriteString("refresh_token", userAccessAcgf.RefreshToken);
                    writer.WriteStartArray("scope");

                    ReadOnlyCollection<string> scopes = userAccessAcgf.Scopes.GetReadOnlyCollection();

                    foreach (string scope in scopes)
                        writer.WriteStringValue(scope);

                    writer.WriteString("token_type", userAccessAcgf.Type);
                    writer.WriteEndObject();
                }
            }
        }
    }
}
