using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Twitch.Authentication.Access;
using Twitch.Exceptions;

namespace Twitch.Authentication
{
    public class OAuthClientCredentialGrantFlow
    {
        private const string Type = "client_credentials";

        private readonly TwitchAuthenticator _auth;

        internal OAuthClientCredentialGrantFlow(TwitchAuthenticator auth)
        {
            _auth = auth;
        }

        internal HttpRequestMessage CreateRequest() => new(HttpMethod.Post, AuthenticationUri.OAuthToken)
        {
            Content = new ByteArrayContent(Encoding.UTF8.GetBytes($"client_id={_auth.Application.Id}&client_secret={_auth.Application.Secret}&grant_type={Type}"))
            {
                Headers =
                {
                    ContentType = new MediaTypeHeaderValue(MediaTypeNames.Application.FormUrlEncoded)
                }
            }
        };
        internal async Task<AppAccess> TryGetAppAccessAsync()
        {
            HttpRequestMessage request = CreateRequest();
            HttpResponseMessage response = await _auth.SendAsync(request);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new TwitchApiException($"{response.StatusCode} | {response.ReasonPhrase}", request, response);
            else
                return (await response.Content.ReadFromJsonAsync<AppAccess>())!;
        }

        [JsonConverter(typeof(JsonConverter))]
        public class AppAccess : TwitchAccess
        {
            internal AppAccess(string token, string type) : base(token, type) { }
        }
        internal class JsonConverter : JsonConverter<AppAccess>
        {
            private const string AccessToken = "access_token";
            private const string ExpiresIn = "expires_in";
            private const string TokenType = "token_type";

            public override AppAccess Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.StartObject)
                {
                    reader.Read();
                    if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == AccessToken)
                    {
                        reader.Read();

                        string token = reader.GetString()!;

                        reader.Read();
                        if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == ExpiresIn)
                        {
                            reader.Read();
                            reader.Read();
                            if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == TokenType)
                            {
                                reader.Read();

                                string type = reader.GetString()!;

                                reader.Read();
                                if (reader.TokenType == JsonTokenType.EndObject)
                                    return new(token, type);
                            }
                        }
                    }
                }

                throw new JsonException();
            }
            public override void Write(Utf8JsonWriter writer, AppAccess access, JsonSerializerOptions options)
            {
                writer.WriteStartObject();
                writer.WriteString("access_token", access.Token);
                writer.WriteString("token_type", access.Type);
                writer.WriteEndObject();
            }
        }
    }
}
