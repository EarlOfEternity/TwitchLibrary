using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Twitch.Authentication.Accesses;
using System.Text.Json;

namespace Twitch.Authentication.Flows
{
    public static class ClientCredentials
    {
        internal static async Task<AppAccessCcgf> GetAppToken(this TwitchAppClient appClient)
        {
            HttpRequestMessage request = Authentication.GetRequest(appClient, "token", "client_id=" + appClient.ID + "&client_secret=" + appClient.Secret + "&grant_type=client_credentials");
            HttpResponseMessage responseMessage = await appClient.SendAsync(request);

            if (responseMessage.StatusCode == HttpStatusCode.OK)
                return (await responseMessage.Content.ReadFromJsonAsync<AppAccessCcgf>())!;
            else
                throw new Exception($"{responseMessage.StatusCode} | {responseMessage.ReasonPhrase}");
        }
    }
}
