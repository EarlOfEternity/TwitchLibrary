using System.Text.Json.Serialization;
using System.Text.Json;
using Twitch.Authentication.Access;

namespace Twitch.Authentication.Validation
{
    [JsonConverter(typeof(JsonConverter))]
    public class ValidationResult
    {
        public string ClientId { get; private set; }
        public string? Login { get; private set; }
        public string? UserId { get; private set; }
        public Scopes? Scopes { get; private set; }
        public int? ExpiresIn { get; private set; }

        internal ValidationResult(string clientId)
        {
            ClientId = clientId;
        }
        internal class JsonConverter : JsonConverter<ValidationResult>
        {
            public override ValidationResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType is JsonTokenType.StartObject)
                {
                    ValidationResult result = new("Unknown");
                    while (reader.TokenType is not JsonTokenType.EndObject)
                    {
                        reader.Read();

                        if (reader.TokenType is JsonTokenType.PropertyName)
                            switch (reader.GetString())
                            {
                                case "client_id":
                                    reader.Read();
                                    result.ClientId = reader.GetString()!;
                                    break;
                                case "login":
                                    reader.Read();
                                    result.Login = reader.GetString();
                                    break;
                                case "user_id":
                                    reader.Read();
                                    result.UserId = reader.GetString();
                                    break;
                                case "scopes":
                                    reader.Read();

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
                                case "expires_in":
                                    reader.Read();
                                    result.ExpiresIn = reader.GetInt32();
                                    break;
                                default: break;
                            }
                    }

                    return result;
                }
                 
                throw new JsonException();
            }
            public override void Write(Utf8JsonWriter writer, ValidationResult access, JsonSerializerOptions options)
            {

            }
        }
    }
    
}
