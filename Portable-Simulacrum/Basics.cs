using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portable_Simulacrum
{
    public static class Basics
    {
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

        public struct Enemy
        {
            public double health;
            public Hitpoint healthType;
            public double shield;
            public Hitpoint shieldType;
            public double armor;
            public Hitpoint armorType;
            public int level;

            public Enemy(double _health, Hitpoint _healthType, double _shield, Hitpoint _shieldType, double _armor, Hitpoint _armorType, int _level)
            {
                health = _health;
                healthType = _healthType;
                shield = _shield;
                shieldType = _shieldType;
                armor = _armor;
                armorType = _armorType;
                level = _level;
            }
        }

        public enum Damage
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
            Total,
            Cap,
        }

        public static Dictionary<string, Damage> damageList = new Dictionary<string, Damage>
        {
            {"冲击", Damage.Impact        },
            {"穿刺", Damage.Puncture      },
            {"切割", Damage.Slash         },
            {"冰冻", Damage.Cold          },
            {"电击", Damage.Electricity   },
            {"火焰", Damage.Heat          },
            {"毒素", Damage.Toxin         },
            {"爆炸", Damage.Blast         },
            {"腐蚀", Damage.Corrosive     },
            {"毒气", Damage.Gas           },
            {"磁力", Damage.Magnetic      },
            {"辐射", Damage.Radiation     },
            {"病毒", Damage.Viral         },
        };          

        public static double[,] dmgMult =
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

        public static double[] Crit(double[] dmg, double critMult)
        {
            for (int i = 0; i < dmg.Count(); i++)
            {
                dmg[i] *= critMult;
            }
            return dmg;
        }

        public static double[] Status(double[] dmg, Damage statType)
        {
            dmg[(int)Damage.Cap] = (double)statType;
            return dmg;
        }

        public static double[] PureDmg(double dmgNum, Damage dmgType)
        {
            double[] dmg = new double[(int)Damage.Cap + 1];
            dmg[(int)dmgType] = dmgNum;
            return dmg;
        }

        public struct Weapon
        {
            public double multi, fireRate, critChan, critMult, statChan, reload;
            public int clip;
            public double[] dmg;
            public double toxinRatio, elemBonus;

            public Weapon(double _multi, double _fireRate, double _critChan, double _critMult, double _statChan, double _reload, int _clip, double[] _dmg, double _toxinRatio, double _elemBonus)
            {
                _statChan /= 100;
                multi = _multi;
                fireRate = _fireRate;
                critChan = _critChan;
                critMult = _critMult;
                statChan = 1 - Math.Pow(1 - _statChan, 1 / _multi);
                reload = _reload;
                clip = _clip;
                dmg = _dmg;
                toxinRatio = _toxinRatio / 100;
                elemBonus = _elemBonus / 100;
            }
        }

        public static Enemy dmgApply(Enemy enemy, double[] dmg)
        {
            double damage = 0;
            double remainRatio = 1;
            if (enemy.shield > 0)
            {
                for (int i = 0; i < (int)Damage.Total; i++)
                {
                    if (i != (int)Damage.Toxin && i != (int)Damage.Finishing)
                    {
                        damage += dmg[i] * (1 + dmgMult[i, (int)enemy.shieldType]);
                    }
                }
                if (damage > enemy.shield)
                {
                    enemy.shield = 0;
                    remainRatio = 1 - enemy.shield / damage;
                }
                else
                {
                    enemy.shield -= damage;
                    remainRatio = 0;
                }
            }

            damage = 0;
            for (int i = 0; i < (int)Damage.Total; i++)
            {
                if (i != (int)Damage.Toxin && i != (int)Damage.Finishing)
                {
                    damage += dmg[i] * (1 + dmgMult[i, (int)enemy.armorType]) * (1 + dmgMult[i, (int)enemy.healthType]) / (1 + (enemy.armor * (1 - dmgMult[i, (int)enemy.armorType]) / 300));
                }
            }
            damage *= remainRatio;
            damage += dmg[(int)Damage.Toxin] * (1 + dmgMult[(int)Damage.Toxin, (int)enemy.armorType]) * (1 + dmgMult[(int)Damage.Toxin, (int)enemy.healthType]) / (1 + (enemy.armor * (1 - dmgMult[(int)Damage.Toxin, (int)enemy.armorType]) / 300));
            damage += dmg[(int)Damage.Finishing] * (1 + dmgMult[(int)Damage.Finishing, (int)enemy.healthType]);
            enemy.health -= damage;
            return enemy;
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
