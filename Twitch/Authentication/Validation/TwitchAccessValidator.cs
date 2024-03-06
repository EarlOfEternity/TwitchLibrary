using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
using System.Threading.Tasks;
using Twitch.Authentication.Access;

namespace Twitch.Authentication.Validation
{
    public class TwitchAccessValidator
    {
        private const string Endpoint = "https://id.twitch.tv/oauth2/validate";
        private HttpClient Requester { get; }
        public TwitchAccessValidator() 
        {
            Requester = new();    
        }
        internal TwitchAccessValidator(HttpClient requester)
        {
            this.Requester = requester;
        }

        public static HttpRequestMessage CreateValidationRequest(TwitchAccess access) => new(HttpMethod.Get, Endpoint)
        {
            Headers =
            {
                Authorization = new(access.Type, access.Token)
            }
        };
        public async Task<ValidationResult> TryValidate(TwitchAccess access)
        {
            HttpRequestMessage requestMsg = CreateValidationRequest(access);
            HttpResponseMessage responseMsg = await Requester.SendAsync(requestMsg);
            
            if(responseMsg.StatusCode is HttpStatusCode.OK)
            {
                return (await responseMsg.Content.ReadFromJsonAsync<ValidationResult>())!;
            }
            else
                throw new Exception(responseMsg.StatusCode.ToString());
        }
    }
}
