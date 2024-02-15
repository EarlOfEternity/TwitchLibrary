using System.Collections.Specialized;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Web;
using Twitch.Authentication.Access;
using Twitch.Authentication.Access.Scopes;
using Twitch.Authentication.JsonConverters;
using Twitch.Clients;

namespace Twitch.Authentication.User
{
    [JsonConverter(typeof(AuthorizationCodeGrantFlow_JsonConverter))]
    public class AuthorizationCodeGrantFlow : TwitchUserAccess
    {
        public string RefreshToken { get; }

        public AuthorizationCodeGrantFlow(string token, string type, string refreshToken, TwitchScopesBuilder scopesBuilder) : base(token, type, scopesBuilder)
        {
            RefreshToken = refreshToken;
        }

        public static Uri CreateUri(TwitchAppClient twitchClient,string? secret = null)
            => TwitchAuthentication.GetUrl(twitchClient, "code", secret);
        public static string TryConvertFromUri(Uri uri, ref TwitchScopesBuilder scopesBuilder, string? state = null)
        {
            NameValueCollection query = HttpUtility.ParseQueryString(uri.Query);

            string? receivedState = query.Get("state");
            if (receivedState != state)
            {
                throw new Exception();
            }

            string? code = query.Get("code");

            if (code is not null)
            {
                string? scope = query.Get("scope");

                if (scope is not null)
                {
                    scopesBuilder = new(HttpUtility.UrlDecode(scope).Split(' '));
                    return code;
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
        public static async Task<AuthorizationCodeGrantFlow> TryGetUserToken(TwitchAppClient appClient, string code)
        {
            HttpRequestMessage request = GetRequest(appClient, code);            
            HttpResponseMessage response = await appClient.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
                return (await response.Content.ReadFromJsonAsync<AuthorizationCodeGrantFlow>())!;
            else
                throw new Exception($"{(int)response.StatusCode} | {response.ReasonPhrase}");
        }
        public static HttpRequestMessage GetRequest(TwitchAppClient appClient, string code)
            => TwitchAuthentication.GetPostRequest(
                appClient,
                "token",
                "client_id=" + appClient.Id +
                "&client_secret=" + appClient.Secret +
                "&code=" + code +
                "&grant_type=authorization_code" +
                "&redirect_uri=" + appClient.RedirectUri);
    }
}
