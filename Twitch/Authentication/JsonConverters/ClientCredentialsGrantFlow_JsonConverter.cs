using System.Text.Json;
using System.Text.Json.Serialization;
using Twitch.Authentication.Application;

namespace Twitch.Authentication.JsonConverters
{
    internal class ClientCredentialsGrantFlow_JsonConverter : JsonConverter<ClientCredentialsGrantFlow>
    {
        public override ClientCredentialsGrantFlow Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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
                        if (reader.TokenType == JsonTokenType.PropertyName && reader.GetString() == "token_type")
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

        public override void Write(Utf8JsonWriter writer, ClientCredentialsGrantFlow access, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("access_token", access.Token);
            writer.WriteString("token_type", access.Type);
            writer.WriteEndObject();
        }
    }
}
