using System.Net.Http.Headers;
using System.Text;
using Twitch.Authentication;

namespace Twitch
{
    public class TwitchClient
    {
        private  HttpClient _httpClient;
        private  TwitchAcessScopes _scopes;
        private TwitchAccess _access;
        public string ID { get; }
        public string Secret { get; }
        public TwitchAcessScopes Scopes
        {
            get { return new(_scopes); }
        }
        public TwitchAccess Access
        {
            get { return new(_access); }
        }
        public TwitchClient(string id, string secret, TwitchAcessScopes scopes)
        {
            ID = id;
            Secret = secret;
            _httpClient = new HttpClient();
            _scopes = new(scopes);
            _access = this.GetApplicationToken().Result;
        }

        public async Task<HttpResponseMessage> SendAsync(TwitchHttpRequest request) => await _httpClient.SendAsync(request.Message);
    }
}