using System.Text.Json;
using System.Text.Json.Serialization;
using Twitch.Authentication.Access.Scopes;
using Twitch.Authentication.User;

namespace Twitch.Authentication.JsonConverters
{
    internal class AuthorizationCodeGrantFlow_JsonConverter : JsonConverter<AuthorizationCodeGrantFlow>
    {
        public override AuthorizationCodeGrantFlow Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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
                                TwitchScopesBuilder scopesBuilder = new();

                                reader.Read();
                                if (reader.TokenType == JsonTokenType.StartArray)
                                {
                                    reader.Read();
                                    while (reader.TokenType != JsonTokenType.EndArray)
                                    {
                                        scopesBuilder.SetByName(reader.GetString()!);
                                        reader.Read();
                                    }

                                    reader.Read();
                                    if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "token_type")
                                    {
                                        reader.Read();

                                        string type = reader.GetString()!;

                                        reader.Read();
                                        if (reader.TokenType == JsonTokenType.EndObject)
                                            return new(token, type, refreshToken, scopesBuilder);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, AuthorizationCodeGrantFlow userAccessAcgf, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("access_token", userAccessAcgf.Token);
            writer.WriteString("refresh_token", userAccessAcgf.RefreshToken);
            writer.WriteStartArray("scope");

            string[] scopes = userAccessAcgf.Scopes.GetArrayOfScopes();

            foreach (string scope in scopes)
                writer.WriteStringValue(scope);

            writer.WriteString("token_type", userAccessAcgf.Type);
            writer.WriteEndObject();
        }
    }
}
