using System.Net.Http.Headers;
using System.Text;
using Twitch.Authentication;
using Twitch.Authentication.Accesses;
using Twitch.Interfaces;
using Twitch.Authentication.Flows;
using Twitch.Authentication.GrantFlows;
namespace Twitch
{
    public class TwitchAppClient : ITwitchClient
    {
        private  HttpClient _httpClient;
        internal AppAccessCcgf Access;
        public string ID { get; }
        public string Secret { get; }

        public TwitchAppClient(string id, string secret)
        {
            ID = id;
            Secret = secret;
            _httpClient = new HttpClient();
            Access = ClientCredentials.GetAppToken(this).Result;
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return response;
        }
    }
}