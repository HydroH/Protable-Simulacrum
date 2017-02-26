using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Portable_Simulacrum.Basics;

namespace Portable_Simulacrum
{
    public static class EnemyType
    {
        public static Enemy CorruptedHeavyGunner =
            new Enemy(700, Hitpoint.ClonedFlesh, 0, Hitpoint.None, 500, Hitpoint.FerriteArmor, 8);
        public static Enemy CorpusTech =
            new Enemy(700, Hitpoint.Flesh, 250, Hitpoint.ProtoShield, 0, Hitpoint.None, 15);

        public static SortedDictionary<string, Enemy> enemyList = new SortedDictionary<string, Enemy>
        {
            {"堕落重型机枪手"  , CorruptedHeavyGunner      },
            {"Corpus技师"     , CorpusTech                },
        };

        public static Enemy Scale(Enemy enemy, int level)
        {
            const double
                healthExp = 2.0f,
                healthCo = 0.015f,
                shieldExp = 2.0f,
                shieldCo = 0.0075f,
                armorExp = 1.75f,
                armorCo = 0.005f;

            Enemy newEnemy = enemy;
            int effLevel = level - enemy.level;
            if (effLevel <= 0) return enemy;
            newEnemy.health = enemy.health * (1 + healthCo * Math.Pow(effLevel, healthExp));
            newEnemy.shield = enemy.shield * (1 + shieldCo * Math.Pow(effLevel, shieldExp));
            newEnemy.armor = enemy.armor * (1 + armorCo * Math.Pow(effLevel, armorExp));
            newEnemy.level = level;
            return newEnemy;
        }
    }
}
