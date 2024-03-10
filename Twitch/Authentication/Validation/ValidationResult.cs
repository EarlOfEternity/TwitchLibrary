using System.Text.Json.Serialization;
using System.Text.Json;
using Twitch.Authentication.Access;
using System.Collections.ObjectModel;

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

        private ValidationResult() 
        {
            ClientId = null!;
        } 
        private class JsonConverter : JsonConverter<ValidationResult>
        {
            public override ValidationResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                ValidationResult result = new();

                if (reader.TokenType is JsonTokenType.StartObject)
                {
                    while (reader.TokenType is not JsonTokenType.EndObject)
                    {
                        reader.Read();

                        if (reader.TokenType is JsonTokenType.PropertyName)
                        {
                            string propertyName = reader.GetString()!;
                            reader.Read();

                            switch (propertyName)
                            {
                                case "client_id":

                                    result.ClientId = reader.GetString()!;

                                    break;

                                case "login":

                                    result.Login = reader.GetString();

                                    break;

                                case "user_id":

                                    result.UserId = reader.GetString();

                                    break;

                                case "scopes":

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

                                default:
                                    break;
                            }
                        }
                    }
                }

                if (result.ClientId is not null)
                    return result;
                else
                    throw new JsonException();
            }
            public override void Write(Utf8JsonWriter writer, ValidationResult access, JsonSerializerOptions options)
            {
                writer.WriteStartObject();
                writer.WriteString("client_id", access.ClientId);

                if (access.Login is not null)
                    writer.WriteString("login", access.Login);
                
                if (access.UserId is not null)
                    writer.WriteString("user_id", access.UserId);
                
                if (access.Scopes is not null)
                {
                    writer.WriteStartArray("scope");

                    ReadOnlyCollection<string> scopes = access.Scopes.GetReadOnlyCollection();

                    foreach (string scope in scopes)
                        writer.WriteStringValue(scope);
                }
                
                if(access.ExpiresIn is not null)
                    writer.WriteNumber("expires_in", (int)access.ExpiresIn);

                writer.WriteEndObject();

            }
        }
    }
    
}
