
using System.Collections.Specialized;
using System.Web;
using Twitch.Authentication.Access;
using Twitch.Authentication.Access.Scopes;
using Twitch.Clients;

namespace Twitch.Authentication.User
{
    public class ImplicitGrantFlow : TwitchUserAccess
    {
        public ImplicitGrantFlow(string token, string type, TwitchScopesBuilder scopesBuilder) : base(token, type, scopesBuilder) { }

        public static Uri GetUrl(TwitchAppClient twitchClient, string? state = null)
            => TwitchAuthentication.GetUrl(twitchClient, "token", state);

        public static ImplicitGrantFlow TryCreateFromUri(Uri uri, string? state = null)
        {
            NameValueCollection query = HttpUtility.ParseQueryString(uri.Fragment);

            string? receivedState = query.Get("state");
            if (receivedState != state)
            {
                throw new Exception();
            }

            string? token = query.Get("#access_token");

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
