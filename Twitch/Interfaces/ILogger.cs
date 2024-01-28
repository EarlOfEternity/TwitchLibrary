using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch.Interfaces
{
    internal interface ILogger
    {
        void Log(string msg);
        void Log(HttpRequestMessage req, HttpResponseMessage resp);
    }
}
