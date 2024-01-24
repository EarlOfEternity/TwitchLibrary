using System.Text.Json.Serialization;
using Twitch.Authentication.Accesses.JsonConverters;

namespace Twitch.Authentication.Accesses
{
    [JsonConverter(typeof(JsonConverterCcgf))]
    public class AppAccessCcgf : Access
    {
        internal AppAccessCcgf(string token, string type) : base(token, type) 
        {
            
        }
    }
}
