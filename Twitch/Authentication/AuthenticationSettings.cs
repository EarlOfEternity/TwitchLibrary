using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch.Authentication
{
    public class AuthenticationSettings
    {
        public bool ForceVerify { get; set; }
        public Uri RedirectUri { get; set; }
        public ScopesBuilder? Scopes { get; set; }
        public AuthenticationSettings(Uri redirectUri, ScopesBuilder? scopes = null, bool forceVerify = false)
        {
            ForceVerify = forceVerify;
            RedirectUri = redirectUri;
            Scopes = scopes;
        }
    }
}
