using Twitch.Authentication.Access.Scopes;

namespace Twitch.Authentication.Access
{
    public interface ITwitchUserAccess : ITwitchAccess
    {
        TwitchScopes Scopes { get; }
    }
}
