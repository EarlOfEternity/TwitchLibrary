using Twitch.Authentication.Access.Scopes;

namespace Twitch.Authentication.Access
{
    public abstract class TwitchUserAccess : TwitchAccess
    {
        internal TwitchScopes Scopes { get; init; }

        public TwitchUserAccess(string token, string type, TwitchScopesBuilder scopesBuilder) : base(token, type)
        {
            Scopes = scopesBuilder.Build();
        }
    }
}
