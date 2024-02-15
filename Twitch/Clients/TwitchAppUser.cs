using Twitch.Authentication.Access;
using Twitch.Interfaces;

namespace Twitch.Clients
{
    public class TwitchAppUser : ITwitchClient
    {
        internal TwitchAppClient AppClient { get; }
        public string ID { get; }
        public string Login { get; }
        public ITwitchUserAccess Access { get; } 

        internal TwitchAppUser(TwitchAppClient twitchClient, ITwitchUserAccess Access)
        {
            AppClient = twitchClient;
/*            var reponse = AppClient.ValidateAccess(Access).Result.Content.ReadFromJsonAsync<JsonObject>().Result;
            ID = reponse["id"].GetValue<string>();
            Login = reponse["id"].GetValue<string>();*/
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            return await AppClient.SendAsync(request);
        }
    }
}
