using System.Net;
using System.Net.Http.Json;
using Twitch.Authentication.Access;

namespace Twitch.Authentication.Validation
{
    public class TwitchAccessValidator
    {
        private HttpClient Requester { get; }
        public TwitchAccessValidator() 
        {
            Requester = new();    
        }
        internal TwitchAccessValidator(HttpClient requester)
        {
            this.Requester = requester;
        }

        public static HttpRequestMessage CreateValidationRequest(TwitchAccess access) => new(HttpMethod.Get, AuthenticationEndpoints.Validate)
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
