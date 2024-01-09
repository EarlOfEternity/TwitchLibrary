using System.Text.Json.Nodes;

namespace Twitch.Authentication
{
    internal interface ITwitchRefreshebleUserAccess
    {
        public string RefreshToken { get; }
    }
}
