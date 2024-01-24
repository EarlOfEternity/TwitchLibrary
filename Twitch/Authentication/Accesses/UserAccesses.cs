using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using Twitch.Authentication.Accesses.JsonConverters;
using Twitch.Authentication.Interfaces;

namespace Twitch.Authentication.Accesses
{
    public abstract class UserAccess : Access, IUserAccess
    {
        public Scopes Scopes { get; }

        internal UserAccess(string token, string type, ScopesBuilder scopesBuilder) : base(token, type) 
        {
            Scopes = new(scopesBuilder); 
        }
    }

    public class UserAccessIgf : UserAccess
    {
        public UserAccessIgf(string token, string type, ScopesBuilder scopesBuilder) : base(token, type, scopesBuilder)
        {

        }
    }

    [JsonConverter(typeof(JsonConverterAcgf))]
    public class UserAccessAcgf : UserAccess, IRefreshebleUserAccess
    {
        public string RefreshToken { get; }

        public UserAccessAcgf(string token, string type, string refreshToken, ScopesBuilder scopesBuilder) : base(token, type, scopesBuilder)
        {
            RefreshToken = refreshToken;
        }
    }
}
