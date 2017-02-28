using System.Collections.Generic;

namespace Portable_Simulacrum
{
    public static class WeaponList
    {
        //          Impact   Punc   Slash   Cold    Elec    Heat    Toxin   Blast   Corro   Gas     Mag     Radi    Viral   Finish      Multi   FRate   CChan   CMult   SChan   Reload  Clip     WeaponType
        public static Weapon Boltor = new Weapon(new double[]
                {   2.5,    20.0,   2.5,    0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  1,      8.75,   0.05,   1.5,    0.10,   2.6,    60,      Data.WeaponType.Rifle,     true);
        public static Weapon BoltorPrime = new Weapon(new double[]
                {   5.5,    49.5,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  1,      10,     0.05,   2.0,    0.10,   2.4,    60,      Data.WeaponType.Rifle,     true);
        public static Weapon TelosBoltor = new Weapon(new double[]
                {   5.0,    45.0,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  1,      9.33,   0.05,   2.0,    0.075,  2.4,    90,      Data.WeaponType.Rifle,     true);
        public static Weapon Braton = new Weapon(new double[]
                {   6.6,    6.6,    6.8,    0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  1,      8.75,   0.10,   1.5,    0.05,   2.0,    45,      Data.WeaponType.Rifle,     true);
        public static Weapon DeraVandal = new Weapon(new double[]
                {   6.2,    23.3,   1.6,    0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  1,      11.3,   0.05,   2.0,    0.15,   2.4,    60,      Data.WeaponType.Rifle,     true);
        public static Weapon SomaPrime = new Weapon(new double[]
                {   1.2,    4.8,    6.0,    0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  1,      15.0,   0.30,   3.0,    0.10,   3.0,    200,     Data.WeaponType.Rifle,     true);
        public static Weapon Ignis = new Weapon(new double[]
                {   0,      0,      0,      0,      0,      27.0,   0,      0,      0,      0,      0,      0,      0,      0,      },  1,      10.0,   0.05,   2.0,    0.25,   2.0,    150,     Data.WeaponType.Rifle,     true);

        public static SortedDictionary<string, Weapon> weaponList = new SortedDictionary<string, Weapon>
        {
            {"螺钉步枪"       , Boltor           },
            {"螺钉步枪Prime"  , BoltorPrime      },
            {"终极螺钉步枪"    , TelosBoltor      },
            {"布莱顿"         , Braton           },
            {"德拉 破坏者"     , DeraVandal       },
            {"月神Prime"      , SomaPrime        },
            {"伊格尼斯"       , Ignis            },
        };
    }
}
