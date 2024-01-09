using System.Net;
using System.Net.Http.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Twitch.Authentication
{
    public static class Requester
    {
        internal static async Task<TwitchAccess> GetApplicationToken(this TwitchClient twitchClient)
        {
            HttpResponseMessage response = await twitchClient.SendAsync(new(new(HttpMethod.Post, new Uri("https://id.twitch.tv/oauth2/token"))
            {
                Content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("client_id", twitchClient.ID),
                    new KeyValuePair<string, string>("client_secret", twitchClient.Secret),
                    new KeyValuePair<string, string>("grant_type", "client_credentials")
                })
            }));
            if (response.StatusCode == HttpStatusCode.OK)
            {
                TwitchAccess? access = await response.Content.ReadFromJsonAsync<TwitchAccess>();
                if (access != null)
                {
                    return access;
                }
                else
                    throw new Exception("Can't convert response to access");
            }
            else
                throw new Exception($"{response.StatusCode} | {response.ReasonPhrase}");
        }
    }
}
