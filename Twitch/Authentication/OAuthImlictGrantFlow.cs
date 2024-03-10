using System.Collections.Specialized;
using System.Web;
using Twitch.Authentication.Access;

namespace Twitch.Authentication
{
    public class OAuthImlictGrantFlow
    {
        private const string RepsonseType = "token";

        private readonly TwitchAuthenticator _auth;
        private bool ForceVerify { get; set; }
        private Uri RedirectUri { get; set; }
        private Scopes Scopes { get; }

        internal OAuthImlictGrantFlow(TwitchAuthenticator auth, bool forceVerify, Uri redirectUri, Scopes scopes)
        {
            _auth = auth;
            ForceVerify = forceVerify;
            RedirectUri = redirectUri;
            Scopes = scopes;
        }

        public Uri CreateUri( string? state = null) => 
            new(AuthenticationEndpoints.OAuthAuthorize +
                $"?client_id={_auth.Application.Id}" +
                $"&force_verify={ForceVerify}" +
                $"&redirect_uri={RedirectUri.OriginalString}" +
                $"&response_type={RepsonseType}" +
                $"&scope={HttpUtility.UrlEncode(Scopes.GetString())}" +
                (state is not null ? $"&state={state}" : ""));
        
        public static UserAccess TryCreateUserAccess(Uri uri, string? state = null)
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
                        return new(token, type, new Scopes(HttpUtility.UrlDecode(scope)));
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
       
        public class UserAccess(string token, string type, Scopes scopes) : TwitchUserAccess(token, type, scopes)
        {
        }

    }
}
