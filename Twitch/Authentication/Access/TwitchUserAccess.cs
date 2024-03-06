namespace Twitch.Authentication.Access
{
    public abstract class TwitchUserAccess(string token, string type, Scopes scopes) : TwitchAccess(token, type)
    {
        public Scopes Scopes { get; init; } = scopes;
    }
}
