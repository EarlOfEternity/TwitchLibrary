using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Twitch.Authentication;
using Twitch.Authentication.Access;
using Twitch.Authentication.Validation;

namespace Twitch
{
    public class TwitchApplication : ITwitchApplication
    {
        public string Id { get; private set; }
        public string Secret { get; private set; }
        internal OAuthClientCredentialGrantFlow.AppAccess Access { get; }
        public TwitchAuthenticator Authenticator { get; }
        private TwitchAccessValidator Validator { get; }

        private TwitchApplication(string id, string secret)
        {
            HttpClient requester = new();

            Id = id;
            Secret = secret;
            Authenticator = new(this, requester);
            Validator = new TwitchAccessValidator(requester);
            Access = Authenticator.OAuthClientCredentialGrantFlow().TryGetAppAccessAsync().Result;
        }

        public static TwitchApplication TryCreate(string id, string secret) => new(id, secret);
        public void SetPrimaryLogger(ILogger logger)
        {
            Authenticator.Logger = logger;
        }
        public async Task<TwitchApplicationUser> TryCreateUser(TwitchUserAccess access)
        {
           ValidationResult data = await Validator.TryValidate(access);
            if (data.ClientId == Id)
            {
                return new(this, data.UserId!, data.Login!, access);
            }
            else
                throw new Exception("Incorrect access");

            
        }
    }
}
