namespace Twitch.Authentication
{
    public abstract class Access : IAccess
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

        internal Access() { }
        public Access(string token, string type)
        {
            Token = token;
            Type = type;
        }

        internal void Udpate(string type, string token)
        {
            Token = token;
            Type = type;
        }
    }
}
