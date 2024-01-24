using System.Text.Json.Nodes;

namespace Twitch.Authentication
{
    internal interface IRefreshebleUserAccess : IAccess
    {
        public string RefreshToken { get; }
    }
}
