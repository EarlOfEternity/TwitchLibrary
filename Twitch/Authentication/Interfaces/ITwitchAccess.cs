namespace Twitch.Authentication
{
    public interface ITwitchAccess
    {
        public string Token { get; }
        public string Type { get; }
    }
}
