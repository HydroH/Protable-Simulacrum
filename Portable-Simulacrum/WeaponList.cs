using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portable_Simulacrum
{
    public static class WeaponList
    {
        //          Impact   Punc   Slash   Cold    Elec    Heat    Toxin   Blast   Corro   Gas     Mag     Radi    Viral   Finish     Multi   FRate   CChan   CMult   SChan   Reload  Clip   
        public static Weapon SomaPrime = new Weapon(new double[]
                {   1.2,    4.8,    6.0,    0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  1,      15.0,   0.30,   3.0,    0.10,   3.0,    200,    true);
    }
}
