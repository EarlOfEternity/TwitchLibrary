namespace Twitch.Authentication.Access
{
    public interface ITwitchAccess
    {
        public string Token { get; }
        public string Type { get; }
    }
}
