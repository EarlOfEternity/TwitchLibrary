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
            new(AuthenticationUri.OAuthAuthorize.OriginalString +
                $"?client_id={_auth.Application.Id}" +
                $"&force_verify={ForceVerify}" +
                $"&redirect_uri={RedirectUri.OriginalString}" +
                $"&response_type={RepsonseType}" +
                $"&scope={HttpUtility.UrlEncode(Scopes.GetString())}" +
                (state is not null ? $"&state={state}" : ""));
        public static string TryGetCode(Uri uri, string? state = null)
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
                    // 
                    //ADD SCOPES VALIDATION
                    //
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
        internal HttpRequestMessage CreateRequest(string code) => new(HttpMethod.Post, AuthenticationUri.OAuthToken)
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
        public class UserAccess(string token, string refreshToken, string type, Scopes scopes) : TwitchUserAccess(token, type, scopes)
        {
            public string RefreshToken { get; } = refreshToken;
        }
        internal class JsonConverter : JsonConverter<UserAccess>
        {
            public override UserAccess Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.StartObject)
                {
                    reader.Read();
                    if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "access_token")
                    {
                        reader.Read();

                        string token = reader.GetString()!;

                        reader.Read();
                        if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "expires_in")
                        {
                            reader.Read();
                            reader.Read();
                            if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "refresh_token")
                            {
                                reader.Read();

                                string refreshToken = reader.GetString()!;

                                reader.Read();
                                if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "scope")
                                {
                                    List<string> scopes = [];

                                    reader.Read();
                                    if (reader.TokenType == JsonTokenType.StartArray)
                                    {
                                        reader.Read();
                                        while (reader.TokenType != JsonTokenType.EndArray)
                                        {
                                            scopes.Add(reader.GetString()!);
                                            reader.Read();
                                        }

                                        reader.Read();
                                        if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "token_type")
                                        {
                                            reader.Read();

                                            string type = reader.GetString()!;

                                            reader.Read();
                                            if (reader.TokenType == JsonTokenType.EndObject)
                                                return new(token, type, refreshToken, new(scopes));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                throw new JsonException();
            }

            public override void Write(Utf8JsonWriter writer, UserAccess userAccessAcgf, JsonSerializerOptions options)
            {
                writer.WriteStartObject();
                writer.WriteString("access_token", userAccessAcgf.Token);
                writer.WriteString("refresh_token", userAccessAcgf.RefreshToken);
                writer.WriteStartArray("scope");

                var scopes = userAccessAcgf.Scopes.GetReadOnlyCollection();

                foreach (string scope in scopes)
                    writer.WriteStringValue(scope);

                writer.WriteString("token_type", userAccessAcgf.Type);
                writer.WriteEndObject();
            }
        }
    }
}
