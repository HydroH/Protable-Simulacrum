﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portable_Simulacrum
{
    public static class ModList
    {
        //      Base    Multi   CChan   CMult   SChan   Impact  Punc    Slash   Cold    Elec    Heat    Toxin   FRate   Clip    Reload
        public static Mod Serration = new Mod(new double[]
            {   0.15,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      });
        public static Mod HeavyCaliber = new Mod(new double[]
            {   0.15,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      });
    }
}
