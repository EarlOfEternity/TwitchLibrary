using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Twitch.Authentication.Accesses.JsonConverters
{
    internal class JsonConverterCcgf : JsonConverter<AppAccessCcgf>
    {
        public override AppAccessCcgf Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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

        public override void Write(Utf8JsonWriter writer, AppAccessCcgf twitchAppAccess, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("access_token", twitchAppAccess.Token);
            writer.WriteString("token_type", twitchAppAccess.Type);
            writer.WriteEndObject();
        }
    }
}
