using System.Collections.Generic;

namespace Portable_Simulacrum
{
    public static class ModList
    {
        //      Base    Multi   CChan   CMult   SChan   Impact  Punc    Slash   Cold    Elec    Heat    Toxin   FRate   Clip    Reload      MaxLevel
        public static Mod RivenMod = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 0        );

        //      Base    Multi   CChan   CMult   SChan   Impact  Punc    Slash   Cold    Elec    Heat    Toxin   FRate   Clip    Reload      MaxLevel
        public static Mod Serration = new Mod(new double[]
            {   0.15,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 10       );
        public static Mod HeavyCaliber = new Mod(new double[]
            {   0.15,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 10       );
        public static Mod SplitChamber = new Mod(new double[]
            {   0,      0.15,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod PointStrike = new Mod(new double[]
            {   0,      0,      0.25,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod VitalSense = new Mod(new double[]
            {   0,      0,      0,      0.20,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod PrimedCryoRounds = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0,      }, 10       );
        public static Mod CryoRounds = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod Stormbringer = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      }, 5        );
        public static Mod Hellfire = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      }, 5        );
        public static Mod InfectedClip = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      }, 5        );
        public static Mod RimeRounds = new Mod(new double[]
            {   0,      0,      0,      0,      0.15,   0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0,      }, 3        );
        public static Mod HighVoltage = new Mod(new double[]
            {   0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      }, 3        );
        public static Mod ThermiteRounds = new Mod(new double[]
            {   0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      }, 3        );
        public static Mod MalignantForce = new Mod(new double[]
            {   0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      }, 3        );
        public static Mod Shred = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.05,   0,      0,      }, 5        );
        public static Mod SpeedTrigger = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.10,   0,      0,      }, 5        );
        public static Mod VileAcceleration = new Mod(new double[]
            {   -0.025, 0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      }, 5        );
        public static Mod WildFire = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0.05,   0,      }, 3        );
        public static Mod HammerShot = new Mod(new double[]
            {   0,      0,      0,      0.15,   0.10,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 3        );
        public static Mod MagazineWarp = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.05,   0,      }, 5        );
        public static Mod PrimedFastHands = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.05,   }, 10       );
        public static Mod FastHands = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.05,   }, 5        );
        public static Mod ArgonScope = new Mod(new double[]
            {   0,      0,      0.225,  0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod BladedRounds = new Mod(new double[]
            {   0,      0,      0,      0.20,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod CrashCourse = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0.20,   0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod PiercingCaliber = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0.20,   0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod FangedFusillade = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0.20,   0,      0,      0,      0,      0,      0,      0,      }, 5        );

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
            {"污染弹匣"        , InfectedClip      },
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

        //      Base    Multi   CChan   CMult   SChan   Impact  Punc    Slash   Cold    Elec    Heat    Toxin   FRate   Clip    Reload      MaxLevel
        public static Mod PrimedPointBlank = new Mod(new double[]
            {   0.15,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 10       );
        public static Mod PointBlank = new Mod(new double[]
            {   0.15,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod VicousSpread = new Mod(new double[]
            {   0.15,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod HellsChamber = new Mod(new double[]
            {   0,      0.20,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod Blunderbass = new Mod(new double[]
            {   0,      0,      0.15,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod PrimedRavage = new Mod(new double[]
            {   0,      0,      0,      0.10,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 10       );
        public static Mod Ravage = new Mod(new double[]
            {   0,      0,      0,      0.10,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod ChillingGrasp = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod ChargedShell = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      }, 5        );
        public static Mod IncendiaryCoat = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      }, 5        );
        public static Mod ContagiousSpread = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      }, 5        );
        public static Mod FrigidBlast = new Mod(new double[]
            {   0,      0,      0,      0,      0.15,   0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0,      }, 3        );
        public static Mod ShellShock = new Mod(new double[]
            {   0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      }, 3        );
        public static Mod ScatteringInferno = new Mod(new double[]
            {   0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      }, 3        );
        public static Mod ToxicBarrage = new Mod(new double[]
            {   0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      }, 3        );
        public static Mod AcceleratedBlast = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0.15,   0,      0,      }, 3        );
        public static Mod ShotgunSpazz = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      }, 5        );
        public static Mod FrailMomentum = new Mod(new double[]
            {   -0.025, 0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      }, 5        );
        public static Mod Blaze = new Mod(new double[]
            {   0.15,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      }, 3        );
        public static Mod ChillingReload = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0.10,   }, 3        );
        public static Mod SeekingFury = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.025,  }, 5        );
        public static Mod AmmoStock = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.10,   0,      }, 5        );
        public static Mod TacticalPump = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.05,   }, 5        );
        public static Mod LazerSight = new Mod(new double[]
            {   0,      0,      0.20,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod ShrapnelShot = new Mod(new double[]
            {   0,      0,      0,      0.165,  0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod NanoApplicator = new Mod(new double[]
            {   0,      0,      0,      0,      0.15,   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod RepeaterClip = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0,      0.175,  0,      0,      }, 5        );
        public static Mod FullContact = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0.20,   0,      0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod BreachLoader = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0.20,   0,      0,      0,      0,      0,      0,      0,      0,      }, 5        );
        public static Mod SweepingSerration = new Mod(new double[]
            {   0,      0,      0,      0,      0,      0,      0,      0.20,   0,      0,      0,      0,      0,      0,      0,      }, 5        );

        public static SortedDictionary<string, Mod> shotgunModList = new SortedDictionary<string, Mod>
        {
            {"抵近射击Prime"   , PrimedPointBlank  },
            {"抵近射击"        , PointBlank        },
            {"恶性扩散"        , VicousSpread      },
            {"地狱弹膛"        , HellsChamber      },
            {"雷筒"            , Blunderbass       },
            {"破灭Prime"       , PrimedRavage      },
            {"破灭"            , Ravage            },
            {"急冻控场"        , ChillingGrasp     },
            {"充电弹头"        , ChargedShell      },
            {"燃烧外壳"        , IncendiaryCoat    },
            {"传染蔓延"        , ContagiousSpread  },
            {"冰冷疾风"        , FrigidBlast       },
            {"炼狱轰击"        , ScatteringInferno },
            {"电冲弹壳"        , ShellShock        },
            {"毒素弹幕"        , ToxicBarrage      },
            {"加速冲击"        , AcceleratedBlast  },
            {"表演时间"        , ShotgunSpazz      },
            {"虚弱动能"        , FrailMomentum     },
            {"烈焰"            , Blaze             },
            {"激冷装填"        , ChillingReload    },
            {"狂暴追猎"        , SeekingFury       },
            {"霰弹扩充"        , AmmoStock         },
            {"战术上膛"        , TacticalPump      },
            {"雷射瞄具"        , LazerSight        },
            {"破片射击"        , ShrapnelShot      },
            {"纳米涂覆"        , NanoApplicator    },
            {"转轮弹匣"        , RepeaterClip      },
            {"全面接触"        , FullContact       },
            {"破裂装填"        , BreachLoader      },
            {"扫荡锯齿"        , SweepingSerration },
        };
    }
}
