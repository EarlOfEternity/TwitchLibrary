using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Authentication.Access;

namespace Twitch.Authentication
{
    public class TwitchAuthenticator
    {
        public ITwitchApplication Application { get; }
        private readonly HttpClient _requester;
        public ILogger? Logger { get; set; }
        public TwitchAuthenticator(ITwitchApplication app)
        {
            Application = app;
            _requester = new HttpClient();
        }
        internal TwitchAuthenticator(ITwitchApplication app, HttpClient requester) 
        {
            Application = app;
            _requester = requester;
        }
        public OAuthClientCredentialGrantFlow OAuthClientCredentialGrantFlow() => new(this);
        public OAuthAuthorizationCodeGrantFlow CreateOAuthAuthorizationCodeGrantFlow(bool forceVerify, Uri redirectUri, Scopes scopes) => new(this, forceVerify, redirectUri, scopes);
        public OAuthImlictGrantFlow CreateOAuthImlictGrantFlow(bool forceVerify, Uri redirectUri, Scopes scopes) => new(this, forceVerify, redirectUri, scopes);
        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMsg)
        {
            HttpResponseMessage responseMsg = await _requester.SendAsync(requestMsg);
            
            Logger?.FlowLog(requestMsg, responseMsg);
            
            return responseMsg;
        }
    }
}
