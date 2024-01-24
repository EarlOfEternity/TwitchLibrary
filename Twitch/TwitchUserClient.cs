using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Twitch.Authentication;
using Twitch.Authentication.Accesses;
using Twitch.Authentication.Interfaces;
using Twitch.Interfaces;

namespace Twitch
{
    public class TwitchUserClient : ITwitchClient
    {
        internal TwitchAppClient AppClient { get; }
        public string ID { get; }
        public string Login { get; }
        
        internal IUserAccess Access { get; }

        internal TwitchUserClient(TwitchAppClient twitchClient, string id, string login, IUserAccess access)
        {
            AppClient = twitchClient;
            Access = access;
            ID = id; 
            Login = login;
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            return await AppClient.SendAsync(request);
            if(Access is UserAccessAcgf)
            {

            }
        }
             
        
    }
}
