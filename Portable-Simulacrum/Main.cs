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

            cbbWeapon.DataSource = new BindingSource(WeaponList.weaponList, null);
            cbbWeapon.DisplayMember = "Key";
            cbbWeapon.ValueMember = "Value";

            cbbEnemyType.DataSource = new BindingSource(EnemyList.enemyList, null);
            cbbEnemyType.DisplayMember = "Key";
            cbbEnemyType.ValueMember = "Value";

            dgvcModType.DataSource = new BindingSource(ModList.rifleModList, null);
            dgvcModType.DisplayMember = "Key";
            dgvcModType.ValueMember = "Value";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Data.Simdata result = new Data.Simdata(0, 0), temp = new Data.Simdata();
            bool timeExceed = false;
            Mod mod = new Mod();
            foreach (DataGridViewRow row in dgvMod.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[1].Value == null) break;
                mod.Combine(((Mod)row.Cells[0].Value).Scale(Convert.ToInt32(row.Cells[1].Value.ToString())));
            }

            for (int i = 0; i < Data.cycles; i++)
            {
                temp = ((Weapon)cbbWeapon.SelectedValue).SimKill(((Enemy)cbbEnemyType.SelectedValue).Scale((int)nudEnemyLevel.Value), mod.Clone());
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
