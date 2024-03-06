using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Twitch.Authentication.Access;

namespace Twitch
{
    public class TwitchApplicationUser
    {
        public ITwitchApplication Application { get; }
        public string Id { get; private set; }
        public string Name { get; private set; }
        public TwitchUserAccess Access { get; private set; }
        internal TwitchApplicationUser(TwitchApplication app, string id, string name, TwitchUserAccess access)
        {
            Application = app;
            Id = id;
            Name = name;
            Access = access;
        }

    }
}
