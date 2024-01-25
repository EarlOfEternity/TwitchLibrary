using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Twitch.API
{
    internal static class Ads
    {
        public static Task<HttpResponseMessage> StartCommercial(TwitchUserClient userClient, int length)
        {
            if (userClient.Access.Scopes.ChannelEditCommercial)
                if (length > 0 && length < 180)
                {
                    HttpRequestMessage request = new(HttpMethod.Post, new Uri("https://api.twitch.tv/helix/channels/commercial"))
                    {
                        Content = JsonContent.Create(new JsonObject()
                        {
                            { "broadcaster_id", userClient.ID },
                            { "length", length }
                        })
                    };
                    request.Headers.Authorization = new(userClient.Access.Type, userClient.Access.Token);

                    return userClient.SendAsync(request);
                }
                else
                    throw new Exception("Commercial length must be be less than 180 seconds");
            else
                throw new Exception("StartCommercial request requires ChannelEditCommercial permission");
        }
        public static Task<HttpResponseMessage> GetAdSchedule(TwitchUserClient userClient)
        {
            if (userClient.Access.Scopes.ChannelReadAds)
            {
                HttpRequestMessage request = new(HttpMethod.Get, new Uri($"https://api.twitch.tv/helix/channels/ads?broadcaster_id={userClient.ID}"));
                request.Headers.Authorization = new AuthenticationHeaderValue(userClient.Access.Type, userClient.Access.Token);

                return userClient.SendAsync(request);
            }
            else
                throw new Exception("GetAdSchedule request requires ChannelReadAds permission");
        }
        public static Task<HttpResponseMessage> SnoozeNextAd(TwitchUserClient userClient)
        {
            if (userClient.Access.Scopes.ChannelManageAds)
            {
                HttpRequestMessage request = new(HttpMethod.Post, new Uri($"https://api.twitch.tv/helix/channels/ads/schedule/snooze?broadcaster_id={userClient.ID}"));
                request.Headers.Authorization = new(userClient.Access.Type, userClient.Access.Token);

                return userClient.SendAsync(request);
            }
            else
                throw new Exception("SnoozeNextAd request requires ChannelManageAds permission");
        }
    }
}
