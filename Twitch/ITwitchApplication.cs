﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch
{
    public interface ITwitchApplication
    {
        string Id { get; }
        string Secret { get; }
    }
}
