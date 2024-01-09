using System.Text.Json.Serialization;

namespace Twitch.Authentication
{
    public class TwitchAccess : ITwitchAccess
    {
        [JsonPropertyName("access_token")]
        public string Token { get; private set; }
        private string _type = "OAuth";
        [JsonPropertyName("token_type")]
        public string Type
        {
            get
            {
                return _type;
            }
            private set
            {
                if (value is "bearer")
                    _type = "Bearer";
                else
                    _type = value;
            }
        }
        internal TwitchAccess(TwitchAccess access)
        {
            Token = access.Token;
            Type = access.Type;
        }
        public TwitchAccess(string token, string type)
        {
            Token = token;
            Type = type;
        }
        internal void Udpate(string type, string token) 
        {
            _type = type;
            Token = token;
        }
    }
}
