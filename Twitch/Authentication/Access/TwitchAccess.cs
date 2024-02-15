using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Twitch.Authentication.Application;
using Twitch.Exceptions;

namespace Twitch.Authentication.Access
{
    public class TwitchAccess : ITwitchAccess
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
        public TwitchAccess(string token, string type)
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
