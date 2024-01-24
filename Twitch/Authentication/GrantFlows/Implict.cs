using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Twitch.Authentication.Accesses;

namespace Twitch.Authentication.Flows
{
    public static class Implict
    {
        public static Uri CreateUri(this TwitchAppClient twitchClient, AuthenticationSettings settings, string? secret = null)
            => Authentication.CreateUri(twitchClient, settings, "token", secret);

        public static UserAccessIgf ConvertFromUri(Uri uri, string? state = null)
        {
            NameValueCollection query = HttpUtility.ParseQueryString(uri.Query);

            string? receivedState = query.Get("state");
            if (receivedState != state)
            {
                throw new Exception();
            }

            string? token = query.Get("access_token");

            if (token is not null)
            {
                string? scope = query.Get("scope");

                if (scope is not null)
                {
                    string? type = query.Get("token_type");

                    if (type is not null)
                    {
                        return new(token, type, new(HttpUtility.UrlDecode(scope).Split(' ')));
                    }
                }
            }

            string? error = query.Get("error");

            if (error is not null)
            {
                string? errorDescription = query.Get("error_description");

                if (errorDescription is not null)
                {
                    throw new Exception(error + " | " + errorDescription);
                }
            }

            throw new Exception();
        }
    }
}
