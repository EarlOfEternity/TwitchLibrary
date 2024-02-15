namespace Twitch.Clients
{
    internal interface ITwitchAppClient
    {
        public string Id { get; }
        public string Secret { get; }
        public bool ForceVerify { get; }
        public string RedirectUri { get; }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage msg);
    }
}
