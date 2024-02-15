using System.Net;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Twitch.Authentication.Access;
using Twitch.Authentication.JsonConverters;
using Twitch.Clients;
using Twitch.Exceptions;

namespace Twitch.Authentication.Application
{
    [JsonConverter(typeof(ClientCredentialsGrantFlow_JsonConverter))]
    internal class ClientCredentialsGrantFlow : TwitchAccess
    {
        public ClientCredentialsGrantFlow(string token, string type) : base(token, type) { }

        internal static async Task<ClientCredentialsGrantFlow> GetAppToken(TwitchAppClient appClient)
        {
            HttpRequestMessage request = GetRequest(appClient);
            HttpResponseMessage response = await appClient.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
                return (await response.Content.ReadFromJsonAsync<ClientCredentialsGrantFlow>())!;
            else
                throw new TwitchApiException($"{response.StatusCode} | {response.ReasonPhrase}", request, response);
        }
        internal static HttpRequestMessage GetRequest(TwitchAppClient appClient)
            => TwitchAuthentication.GetPostRequest(
                appClient, 
                "token",
                "client_id=" + appClient.Id + 
                "&client_secret=" + appClient.Secret + 
                "&grant_type=client_credentials");
    }
}
