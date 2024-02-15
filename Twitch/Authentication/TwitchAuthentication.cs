using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using Twitch.Authentication.Access;
using Twitch.Clients;
using Twitch.Exceptions;

namespace Twitch.Authentication
{
    public static class TwitchAuthentication
    {
        internal static Uri GetUrl(TwitchAppClient twitchClient, string responseType, string? state = null)
        {
            string url = "https://id.twitch.tv/oauth2/authorize" +
                "?client_id=" + twitchClient.Id +
                "&force_verify=" + twitchClient.ForceVerify +
                "&redirect_uri=" + twitchClient.RedirectUri +
                "&response_type=" + responseType +
                "&scope=" + (twitchClient.Scopes is not null ? HttpUtility.UrlEncode(twitchClient.Scopes!.GetLineOfScopes()) : "") +
                (state is not null ? "&state=" + state : "");

            return new(url);
        }
        internal static HttpRequestMessage GetPostRequest(TwitchAppClient appClient, string type, string content)
        {
            HttpRequestMessage request = new(HttpMethod.Post, new Uri("https://id.twitch.tv/oauth2/" + type))
            {
                Content = new ByteArrayContent(Encoding.UTF8.GetBytes(content))
            };
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            return request;
        }
        public static async Task<HttpResponseMessage> ValidateAccess(this TwitchAppClient appClient, ITwitchAccess access)
        {
            HttpRequestMessage request = new(HttpMethod.Get, new Uri("https://id.twitch.tv/oauth2/validate"));

            request.Headers.Authorization = new(access.Type, access.Token);

            HttpResponseMessage response = await appClient.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
                return response;
            else
                throw new TwitchApiException($"{response.StatusCode} | {response.ReasonPhrase}", request, response);

        }
    }
}
