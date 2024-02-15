using Twitch.Authentication.Access.Scopes;
using Twitch.Authentication.Application;
using Twitch.Interfaces;
namespace Twitch.Clients
{
    public class TwitchAppClient : ITwitchClient
    {
        private readonly string _id;
        private readonly string _secret;

        private readonly bool _forceVerify = false;
        private readonly string _redirectUri;

        private  HttpClient _httpClient;
        internal ClientCredentialsGrantFlow Access;
        public TwitchScopes Scopes { get; init; }
        public string Id => _id;
        public string Secret => _secret;
        public bool ForceVerify => _forceVerify;
        public string RedirectUri => _redirectUri;

        public   TwitchAppClient(string id, string secret, string redirectUri, TwitchScopesBuilder scopesBuilder, bool forceVerify = false)
        {
            _id = id;
            _secret = secret;
            _forceVerify = forceVerify;
            _redirectUri = redirectUri;
            Scopes = scopesBuilder.Build();
            _httpClient = new HttpClient();
            Access = ClientCredentialsGrantFlow.GetAppToken(this).Result;
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return response;
        }   
    }
}