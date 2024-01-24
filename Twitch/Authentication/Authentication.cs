using System.Dynamic;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Web;
using Twitch.Authentication.Accesses;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Twitch.Authentication
{
    public static class Authentication
    {
        internal static Uri CreateUri(TwitchAppClient twitchClient, AuthenticationSettings settings, string responseType, string? state)
        {
            string url = "https://id.twitch.tv/oauth2/authorize";
            url += "?client_id=" + twitchClient.ID;
            url += "&force_verify=" + settings.ForceVerify;
            url += "&redirect_uri=" + settings.RedirectUri.OriginalString;
            url += "&response_type=" + responseType;
            if (settings.Scopes is not null)
                url += "&scope=" + HttpUtility.UrlEncode(settings.Scopes.GetScopes());
            if (state is not null)
                url += "&state=" + state;
            return new(url);
        }
        internal static HttpRequestMessage GetRequest(TwitchAppClient appClient, string type, string content)
        {
            HttpRequestMessage request = new(HttpMethod.Post, new Uri("https://id.twitch.tv/oauth2/" + type))
            {
                Content = new ByteArrayContent(Encoding.UTF8.GetBytes(content))
            };
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            return request;
        }
/*        public static async Task<ValidationResult> Validate(this TwitchAppClient twitchClient, IAccess access)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, new Uri("https://id.twitch.tv/oauth2/validate"));
            requestMessage.Headers.Authorization = new(access.Type, access.Token);
            HttpResponseMessage responseMessage = await twitchClient.SendAsync(requestMessage);
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    string? res = await responseMessage.Content.ReadAsStringAsync();
                    ValidationResponse? response = await responseMessage.Content.ReadFromJsonAsync<ValidationResponse>();
                    if (response != null)
                        return response.ToValidationResult();
                    else
                        throw new Exception($"{responseMessage.StatusCode} | {responseMessage.ReasonPhrase} | Can't convert response to ValidationResponse");
                }
                catch
                {
                    throw;
                }
            }
            else
                throw new Exception($"{responseMessage.StatusCode} | {responseMessage.ReasonPhrase}");
        }*/
    }
}
