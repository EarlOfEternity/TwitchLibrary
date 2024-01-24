using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Twitch.Authentication.Accesses.JsonConverters
{
    internal class JsonConverterAcgf : JsonConverter<UserAccessAcgf>
    {
        public override UserAccessAcgf Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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
                                ScopesBuilder scopesBuilder = new();

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

        public override void Write(Utf8JsonWriter writer, UserAccessAcgf userAccessAcgf, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("access_token", userAccessAcgf.Token);
            writer.WriteString("refresh_token", userAccessAcgf.RefreshToken);
            writer.WriteStartArray("scope");

            List<string> copes = userAccessAcgf.Scopes.GetScopes();
            foreach (string scope in copes)
                writer.WriteStringValue(scope);
            
            writer.WriteString("token_type", userAccessAcgf.Type);
            writer.WriteEndObject();
        }
    }
}
