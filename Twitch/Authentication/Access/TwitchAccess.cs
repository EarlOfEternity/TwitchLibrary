namespace Twitch.Authentication.Access
{
    public abstract class TwitchAccess
    {
        private string _type = "OAuth";

        public string Token { get; private protected set; }
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
        private protected TwitchAccess()
        {
            Token = null!;
        }
        private protected TwitchAccess(string token, string type)
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
