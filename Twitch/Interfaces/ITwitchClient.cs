using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch.Interfaces
{
    internal interface ITwitchClient
    {
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);
    }
}
