using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch.Exceptions
{
    public class TwitchApiException : System.Exception
    {
        internal HttpRequestMessage _request { get; }
        internal HttpResponseMessage _response { get; }

        internal TwitchApiException(string message, HttpRequestMessage request, HttpResponseMessage response) : base(message)
        {
            _request = request;
            _response = response;
        }
    }
}
