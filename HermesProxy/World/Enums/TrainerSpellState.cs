﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HermesProxy.World.Enums
{
    public enum TrainerSpellStateLegacy
    {
        Available = 0,
        Unavailable = 1,
        Known = 2,
    }
    public enum TrainerSpellStateModern
    {
        Known = 0,
        Available = 1,
        Unavailable = 2,
    }
}
