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
        public static Weapon Boar = new Weapon(new double[]
                {   96.8,   26.4,   52.8,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  8,      4.17,   0.10,   1.5,    0.20,   2.7,    20,      Data.WeaponType.Shotgun,   true);
        public static Weapon BoarPrime = new Weapon(new double[]
                {   119.6,  27.6,   36.8,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  9,      4.67,   0.15,   2.0,    0.30,   2.8,    20,      Data.WeaponType.Shotgun,   true);
        public static Weapon Convectrix = new Weapon(new double[]
                {   10.0,   10.0,   80.0,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  1,      3,      0.10,   2.0,    0.25,   2.0,    90,      Data.WeaponType.Shotgun,   true);
        public static Weapon Drakgoon = new Weapon(new double[]
                {   37.09,  37.09,  296.7,  0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  10,     3.33,   0.075,  2.0,    0.10,   2.3,    7,       Data.WeaponType.Shotgun,   true);
        public static Weapon Hek = new Weapon(new double[]
                {   78.75,  341.25, 105.0,  0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  7,      2.17,   0.10,   2.0,    0.25,   2.0,    4,       Data.WeaponType.Shotgun,   true);
        public static Weapon VaykorHek = new Weapon(new double[]
                {   78.75,  341.25, 105.0,  0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  7,      3,      0.25,   2.0,    0.25,   2.3,    8,       Data.WeaponType.Shotgun,   true);
        public static Weapon Kohm = new Weapon(new double[]
                {   18.0,   18.0,   54.0,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  3,      14.8,   0.10,   2.0,    0.25,   2.0,    245,     Data.WeaponType.Shotgun,   true);
        public static Weapon Phage = new Weapon(new double[]
                {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      330.0,  0,      },  7,      1,      0.15,   2.0,    0.10,   2.0,    40,      Data.WeaponType.Shotgun,   true);
        public static Weapon Sobek = new Weapon(new double[]
                {   262.5,  43.8,   43.8,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  5,      2.5,    0.10,   2.0,    0.15,   4.0,    20,      Data.WeaponType.Shotgun,   true);
        public static Weapon Strun = new Weapon(new double[]
                {   165.0,  45.0,   90.0,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  10,     2.5,    0.075,  1.5,    0.20,   3.8,    6,       Data.WeaponType.Shotgun,   true);
        public static Weapon Mk1Strun = new Weapon(new double[]
                {   99.0,   27.0,   54.0,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  10,     2.08,   0.075,  2.0,    0.20,   3.8,    6,       Data.WeaponType.Shotgun,   true);
        public static Weapon StrunWraith = new Weapon(new double[]
                {   195.0,  45.0,   60.0,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  10,     2.5,    0.15,   2.0,    0.40,   5.0,    10,      Data.WeaponType.Shotgun,   true);
        public static Weapon Tigris = new Weapon(new double[]
                {   105.0,  105.0,  840.0,  0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  5,      2.0,    0.05,   2.0,    0.25,   1.8,    2,       Data.WeaponType.Shotgun,   true);
        public static Weapon TigrisPrime = new Weapon(new double[]
                {   156.0,  156.0,  1248.0, 0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  8,      2.0,    0.10,   2.0,    0.30,   1.8,    2,       Data.WeaponType.Shotgun,   true);
        public static Weapon SanctiTigris = new Weapon(new double[]
                {   126.0,  126.0,  1008.0, 0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      },  6,      2.0,    0.15,   1.5,    0.25,   1.5,    2,       Data.WeaponType.Shotgun,   true);

        public static SortedDictionary<string, Weapon> weaponList = new SortedDictionary<string, Weapon>
        {
            {"螺钉步枪"       , Boltor           },
            {"螺钉步枪Prime"  , BoltorPrime      },
            {"终极螺钉步枪"    , TelosBoltor      },
            {"布莱顿"         , Braton           },
            {"德拉 破坏者"     , DeraVandal       },
            {"月神Prime"      , SomaPrime        },
            {"伊格尼斯"       , Ignis             },
            {"野猪"           , Boar             },
            {"野猪Prime"      , BoarPrime        },
            {"导热聚焦枪"      , Convectrix       },
            {"龙骑兵"          , Drakgoon         },
            {"海克"           , Hek              },
            {"勇气 海克"       , VaykorHek        },
            {"寇恩热能枪"      , Kohm             },
            {"噬菌者"          , Phage            },
            {"鳄神"            , Sobek            },
            {"斯特朗"          , Strun            },
            {"MK1-斯特朗"      , Mk1Strun         },
            {"斯特朗 亡魂"     , StrunWraith       },
            {"猛虎"            , Tigris           },
            {"猛虎Prime"       , TigrisPrime      },
            {"圣洁 猛虎"        , SanctiTigris    },
        };
    }
}
