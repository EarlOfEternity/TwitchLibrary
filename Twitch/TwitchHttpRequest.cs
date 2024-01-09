using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch
{
    public class TwitchHttpRequest
    {
        internal HttpRequestMessage Message;
        internal TwitchHttpRequest(HttpRequestMessage message)
        {
            Message = message;
        }
    }
}
