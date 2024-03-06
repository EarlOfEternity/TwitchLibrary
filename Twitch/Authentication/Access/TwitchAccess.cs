namespace Twitch.Authentication.Access
{
    public abstract class TwitchAccess
    {
        private string _type = "OAuth";

        public string Token { get; internal set; }
        public string Type
        {
            get
            {
                return _type;
            }
            internal set
            {
                if (value is "bearer")
                    _type = "Bearer";
                else
                    _type = value;
            }
        }
        protected TwitchAccess(string token, string type)
        {
            Token = token;
            Type = type;
        }

        internal virtual void Udpate(string type, string token)
        {
            Token = token;
            Type = type;
        }
    }
}
