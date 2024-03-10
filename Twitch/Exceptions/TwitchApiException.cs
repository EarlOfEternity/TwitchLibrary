namespace Twitch.Exceptions
{
    public class TwitchApiException : System.Exception
    {
        internal HttpRequestMessage Request { get; }
        internal HttpResponseMessage Response { get; }

        internal TwitchApiException(string message, HttpRequestMessage request, HttpResponseMessage response) : base(message)
        {
            Request = request;
            Response = response;
        }
    }
}