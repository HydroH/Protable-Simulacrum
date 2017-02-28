using System.Collections.Generic;

namespace Portable_Simulacrum
{
    public static class ModList
    {
        //      Base    Multi   CChan   CMult   SChan   Impact  Punc    Slash   Cold    Elec    Heat    Toxin   FRate   Clip    Reload
        public static Mod Serration = new Mod(new double[]
            {   0.15,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      });
        public static Mod HeavyCaliber = new Mod(new double[]
            {   0.15,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      });
        public static Mod SplitChamber = new Mod(new double[]
            {   0,      0.15,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      });
        public static Mod PointStrike = new Mod(new double[]
            {   0,      0,      0.25,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      });
        public static Mod VitalSense = new Mod(new double[]
            {   0,      0,      0,      0.20,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      });
        public static Mod PrimedCryoRounds = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0,      });
        public static Mod CryoRounds = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0,      });
        public static Mod Stormbringer = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      });
        public static Mod Hellfire = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      });
        public static Mod InfectedClip = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      });
        public static Mod RimeRounds = new Mod(new double[]
            {   0,      0,      0,      0,      0.15,   0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0,      });
        public static Mod HighVoltage = new Mod(new double[]
            {   0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      });
        public static Mod ThermiteRounds = new Mod(new double[]
            {   0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      });
        public static Mod MalignantForce = new Mod(new double[]
            {   0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      });
        public static Mod Shred = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.05,   0,      0,      });
        public static Mod SpeedTrigger = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.10,   0,      0,      });
        public static Mod VileAcceleration = new Mod(new double[]
            {   -0.025, 0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      });
        public static Mod WildFire = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0.05,   0,      });
        public static Mod HammerShot = new Mod(new double[]
            {   0,      0,      0,      0.15,   0.10,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      });
        public static Mod MagazineWarp = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.05,   0,      });
        public static Mod PrimedFastHands = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.05,   });
        public static Mod FastHands = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.05,   });
        public static Mod ArgonScope = new Mod(new double[]
            {   0,      0,      0.225,  0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      });
        public static Mod BladedRounds = new Mod(new double[]
            {   0,      0,      0,      0.20,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      });
        public static Mod CrashCourse = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0.20,   0,      0,      0,      0,      0,      0,      0,      0,      0,      });
        public static Mod PiercingCaliber = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0.20,   0,      0,      0,      0,      0,      0,      0,      0,      });
        public static Mod FangedFusillade = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0.20,   0,      0,      0,      0,      0,      0,      0,      });
        public static Mod RivenMod = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      });

        public static SortedDictionary<string, Mod> rifleModList = new SortedDictionary<string, Mod>
        {
            {"膛线"            , Serration         },
            {"重口径"          , HeavyCaliber      },
            {"分裂膛室"        , SplitChamber      },
            {"致命一击"        , PointStrike       },
            {"弱点感应"        , VitalSense        },
            {"低温弹头Prime"   , PrimedCryoRounds  },
            {"低温弹头"        , CryoRounds        },
            {"暴风使者"        , Stormbringer      },
            {"地狱火"          , Hellfire          },
            {"感染弹匣"        , InfectedClip      },
            {"白霜弹头"        , RimeRounds        },
            {"高压电流"        , HighVoltage       },
            {"铝热弹头"        , ThermiteRounds    },
            {"致命火力"        , MalignantForce    },
            {"撕裂"            , Shred             },
            {"灵敏扳机"        , SpeedTrigger      },
            {"卑劣加速"        , VileAcceleration  },
            {"野火"            , WildFire          },
            {"重锤射击"        , HammerShot        },
            {"弹匣增幅"        , MagazineWarp      },
            {"爆发装填Prime"   , PrimedFastHands   },
            {"爆发装填"        , FastHands         },
            {"氩晶瞄具"        , ArgonScope        },
            {"尖刃弹头"        , BladedRounds      },
            {"连续冲击"        , CrashCourse       },
            {"穿甲口径"        , PiercingCaliber   },
            {"尖牙连射"        , FangedFusillade   },
            {"裂罅MOD"         , RivenMod          },
        };
    }
}
