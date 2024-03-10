using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch.Authentication
{
    internal static class AuthenticationEndpoints
    {
        public const string OAuthToken = "https://id.twitch.tv/oauth2/token";
        public const string OAuthCode = "https://id.twitch.tv/oauth2/code";
        public const string OAuthAuthorize = "https://id.twitch.tv/oauth2/authorize";
        public const string Validate = "https://id.twitch.tv/oauth2/validate";

    }
}
