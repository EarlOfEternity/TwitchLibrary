﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch.Authentication.Interfaces
{
    internal interface IUserAccess : IAccess
    {
        Scopes Scopes { get; }
    }
}