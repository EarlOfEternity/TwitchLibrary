using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch.Authentication
{
    internal static class AuthenticationUri
    {
        public static readonly Uri OAuthToken = new("https://id.twitch.tv/oauth2/token");
        public static readonly Uri OAuthCode = new("https://id.twitch.tv/oauth2/code");
        public static readonly Uri OAuthAuthorize = new("https://id.twitch.tv/oauth2/authorize");
    }
}
