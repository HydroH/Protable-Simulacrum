using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Portable_Simulacrum.Data;

namespace Portable_Simulacrum
{
    public static class EnemyList
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
    }
}
