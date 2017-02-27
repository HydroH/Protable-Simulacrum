using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portable_Simulacrum
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            cbbEnemyType.DataSource = new BindingSource(EnemyList.enemyList, null);
            cbbEnemyType.DisplayMember = "Key";
            cbbEnemyType.ValueMember = "Value";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Data.Simdata result = new Data.Simdata(0, 0), temp = new Data.Simdata();
            bool timeExceed = false;
            Mod mod = new Mod();
            mod.Combine(ModList.Serration.Scale(10));

            for (int i = 0; i < Data.cycles; i++)
            {
                temp = WeaponList.SomaPrime.SimKill(EnemyList.CorpusTech.Scale(30), mod.Clone());
                if (temp.time >= Data.timeLimit)
                {
                    timeExceed = true;
                    break;
                }
                result.time += temp.time;
                result.shots += temp.shots;
            }
            result.time /= Data.cycles;
            result.shots /= Data.cycles;
            lblResultTime.Text = timeExceed ? "180秒以上" : result.time.ToString("N2");
            lblResultShots.Text = timeExceed ? "耗时过长" : result.shots.ToString("N2");
        }
    }
}
