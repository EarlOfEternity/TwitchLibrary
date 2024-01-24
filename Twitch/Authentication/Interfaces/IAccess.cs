namespace Twitch.Authentication
{
    public interface IAccess
    {
        public string Token { get; }
        public string Type { get; }
    }
}
