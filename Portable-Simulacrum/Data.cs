using System.Collections.Generic;

namespace Portable_Simulacrum
{
    public static class Data
    {
        public static int timeLimit = 180;
        public static int cycles = 200;

        public enum Hitpoint
        {
            Flesh,
            ClonedFlesh,
            InfestedFlesh,
            Infested,
            InfestedSinew,
            Fossilized,
            Machinery,
            Robotic,
            Shield,
            ProtoShield,
            AlloyArmor,
            FerriteArmor,
            None,
            Cap,
        }

        public enum DamageType
        {
            Impact,
            Puncture,
            Slash,
            Cold,
            Electricity,
            Heat,
            Toxin,
            Blast,
            Corrosive,
            Gas,
            Magnetic,
            Radiation,
            Viral,
            Finishing,
            Cap,
        }

        public static Dictionary<DamageType, string> damageText = new Dictionary<DamageType, string>
        {
            {DamageType.Impact       , "冲击" },
            {DamageType.Puncture     , "穿刺" },
            {DamageType.Slash        , "切割" },
            {DamageType.Cold         , "冰冻" },
            {DamageType.Electricity  , "电击" },
            {DamageType.Heat         , "火焰" },
            {DamageType.Toxin        , "毒素" },
            {DamageType.Blast        , "爆炸" },
            {DamageType.Corrosive    , "腐蚀" },
            {DamageType.Gas          , "毒气" },
            {DamageType.Magnetic     , "磁力" },
            {DamageType.Radiation    , "辐射" },
            {DamageType.Viral        , "病毒" },
        };

        public static double[,] damageMult =
        {
        //  Flesh   Clone   IFlesh  Infest  Sinew   Fossil  Machine Robotic Shield  Proto   Alloy   Ferrite None 
            {-0.25f,-0.25f, 0,      0,      0,      0,      0.25f,  0,      0.50f,  0.25f,  0,      0,      0,      }, //Impact
            {0,     0,      0,      0,      0.25f,  0,      0,      0.25f,  -0.20f, -0.50f, 0.15f,  0.50f,  0,      }, //Puncture
            {0.25f, 0.25f,  0.50f,  0.25f,  0.15f,  0,      0,      -0.25f, 0,      0,      -0.50f, -0.15f, 0,      }, //Slash
            {0,     0,      -0.50f, 0,      0.25f,  -0.25f, 0,      0,      0.50f,  0,      0.25f,  0,      0,      }, //Cold
            {0,     0,      0,      0,      0,      0,      0.50f,  0.50f,  0,      0,      -0.5f,  0,      0,      }, //Electricity
            {0,     0.25f,  0.50f,  0.25f,  0,      0,      0,      0,      0,      -0.50f, 0,      0,      0,      }, //Heat
            {0.50f, 0,      0,      0,      0,      -0.50f, -0.25f, -0.25f, 0,      0,      0,      0.25f,  0,      }, //Toxin
            {0,     0,      0,      0,      -0.50f, 0.50f,  0.75f,  0,      0,      0,      0,      -0.25f, 0,      }, //Blast
            {0,     0,      0,      0,      0,      0.75f,  0,      0,      0,      -0.50f, 0,      0.75f,  0,      }, //Corrosive
            {-0.25f,-0.50f, 0.50f,  0.75f,  0,      0,      0,      0,      0,      0,      0,      0,      0,      }, //Gas
            {0,     0,      0,      0,      0,      0,      0,      0,      0.75f,  0.75f,  -0.50f, 0,      0,      }, //Magnetic
            {0,     0,      0,      -0.50f, 0.50f,  -0.75f, 0,      0.25f,  -0.25f, 0,      0.75f,  0,      0,      }, //Radiation
            {0.50f, 0.75f,  0,      -0.50f, 0,      0,      -0.25f, 0,      0,      0,      0,      0,      0,      }, //Viral
            {0,     0,      0,      0,      0.33f,  0,      0,      0,      0,      0,      0,      0,      0,      }, //Finishing
        };

        public static DamageType[,] damageCombine =
        {
        //  Impact          Puncture        Slash           Cold                  Elecricity            Heat                  Toxin
            {DamageType.Cap,DamageType.Cap, DamageType.Cap, DamageType.Cap,       DamageType.Cap,       DamageType.Cap,       DamageType.Cap,       }, //Impact
            {DamageType.Cap,DamageType.Cap, DamageType.Cap, DamageType.Cap,       DamageType.Cap,       DamageType.Cap,       DamageType.Cap,       }, //Puncture
            {DamageType.Cap,DamageType.Cap, DamageType.Cap, DamageType.Cap,       DamageType.Cap,       DamageType.Cap,       DamageType.Cap,       }, //Slash
            {DamageType.Cap,DamageType.Cap, DamageType.Cap, DamageType.Cap,       DamageType.Magnetic,  DamageType.Blast,     DamageType.Viral,     }, //Cold
            {DamageType.Cap,DamageType.Cap, DamageType.Cap, DamageType.Magnetic,  DamageType.Cap,       DamageType.Radiation, DamageType.Corrosive, }, //Electricity
            {DamageType.Cap,DamageType.Cap, DamageType.Cap, DamageType.Blast,     DamageType.Radiation, DamageType.Cap,       DamageType.Gas,       }, //Heat
            {DamageType.Cap,DamageType.Cap, DamageType.Cap, DamageType.Viral,     DamageType.Corrosive, DamageType.Gas,       DamageType.Cap,       }, //Toxin
        };

        public enum ModProp
        {
            Base,
            Multi,

            CritChan,
            CritMult,
            StatChan,

            Impact,
            Puncture,
            Slash,

            Cold,
            Electricity,
            Heat,
            Toxin,

            FireRate,
            Clip,
            Reload,

            Cap,
        }
        public static int elemDiff = (int)ModProp.Cold - (int)DamageType.Cold;

        public enum WeaponType
        {
            Rifle,
            Shotgun,
            Bow,
            Secondary,
        }

        public struct Simdata
        {
            public double time;
            public double shots;

            public Simdata(double _time,int _shots)
            {
                time = _time;
                shots = _shots;
            }
        }
    }
}
