
namespace Twitch.Authentication.Access
{
    public abstract class TwitchUserAccess : TwitchAccess
    {
        private protected Scopes Scopes { get; init; }
        private protected TwitchUserAccess() : base() 
        {
            Scopes = null!;
        }
        private protected TwitchUserAccess(string token, string type, Scopes scopes) : base(token, type)
        {
            Scopes = scopes;
        }

    }
}
