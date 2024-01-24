using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Twitch.Authentication.Accesses;
using Twitch.Interfaces;
using System.Collections.Specialized;
using System.Web;

namespace Twitch.Authentication.GrantFlows
{
    public static class AuthorizationCode
    {
        public static Uri CreateUri(this TwitchAppClient twitchClient, AuthenticationSettings settings, string? secret = null)
            => Authentication.CreateUri(twitchClient, settings, "code", secret);
        public static string ConvertFromUri(Uri uri, ref ScopesBuilder scopesBuilder, string? state = null)
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
        public static async Task<UserAccessAcgf> GetUserToken(this TwitchAppClient appClient, string code, Uri redirectUri)
        {
            HttpRequestMessage request = Authentication.GetRequest(appClient, "token", "client_id=" + appClient.ID + "&client_secret=" + appClient.Secret + "&code=" + code + "&grant_type=authorization_code&redirect_uri=" + redirectUri.OriginalString);
            HttpResponseMessage responseMessage = await appClient.SendAsync(request);

            if (responseMessage.StatusCode == HttpStatusCode.OK)
                return (await responseMessage.Content.ReadFromJsonAsync<UserAccessAcgf>())!;
            else
                throw new Exception($"{(int)responseMessage.StatusCode} | {responseMessage.ReasonPhrase}");
        }
    }
}
