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
            cbbEnemyType.DataSource = new BindingSource(EnemyType.enemyList, null);
            cbbEnemyType.DisplayMember = "Key";
            cbbEnemyType.ValueMember = "Value";

            cbbDmg1.DataSource = new BindingSource(Basics.damageList, null);
            cbbDmg1.DisplayMember = "Key";
            cbbDmg1.ValueMember = "Value";

            cbbDmg2.DataSource = new BindingSource(Basics.damageList, null);
            cbbDmg2.DisplayMember = "Key";
            cbbDmg2.ValueMember = "Value";

            cbbDmg3.DataSource = new BindingSource(Basics.damageList, null);
            cbbDmg3.DisplayMember = "Key";
            cbbDmg3.ValueMember = "Value";

            cbbDmg4.DataSource = new BindingSource(Basics.damageList, null);
            cbbDmg4.DisplayMember = "Key";
            cbbDmg4.ValueMember = "Value";

            cbbDmg5.DataSource = new BindingSource(Basics.damageList, null);
            cbbDmg5.DisplayMember = "Key";
            cbbDmg5.ValueMember = "Value";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Basics.Simdata result = new Basics.Simdata(0, 0), temp = new Basics.Simdata();
            double[] dmg = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            dmg[(int)cbbDmg1.SelectedValue] += (double)nudDmg1.Value / (double)nudMulti.Value;
            dmg[(int)cbbDmg2.SelectedValue] += (double)nudDmg2.Value / (double)nudMulti.Value;
            dmg[(int)cbbDmg3.SelectedValue] += (double)nudDmg3.Value / (double)nudMulti.Value;
            dmg[(int)cbbDmg4.SelectedValue] += (double)nudDmg4.Value / (double)nudMulti.Value;
            dmg[(int)cbbDmg5.SelectedValue] += (double)nudDmg5.Value / (double)nudMulti.Value;
            for (int i = 0; i < (int)Basics.Damage.Total; i++)
            {
                dmg[(int)Basics.Damage.Total] += dmg[i];
            }
            Basics.Weapon weapon = new Basics.Weapon((double)nudMulti.Value, (double)nudFireRate.Value, (double)nudCritChan.Value, (double)nudCritMult.Value, (double)nudStatChan.Value, (double)nudReload.Value, (int)nudClip.Value, dmg, (double)nudToxinRatio.Value, (double)nudElemMult.Value);
            bool timeExceed = false;
            for (int i = 0; i < 300; i++)
            {
                temp = Evaluation.SimKill(EnemyType.Scale((Basics.Enemy)cbbEnemyType.SelectedValue, (int)nudEnemyLevel.Value), weapon);
                if (temp.time >= 180)
                {
                    timeExceed = true;
                    break;
                }
                result.time += temp.time;
                result.shots += temp.shots;
            }
            result.time /= 300;
            result.shots /= 300;
            lblResultTime.Text = timeExceed ? "180秒以上" : result.time.ToString("N2");
            lblResultShots.Text = timeExceed ? "耗时过长" : result.shots.ToString("N2");
        }
    }
}
