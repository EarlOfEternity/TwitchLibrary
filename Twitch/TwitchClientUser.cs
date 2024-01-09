using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch
{
    public class TwitchClientUser
    {
        public TwitchClient TwitchClient { get; }

        internal TwitchClientUser(TwitchClient twitchClient)
        {
            TwitchClient = twitchClient;
        }
    }
}
