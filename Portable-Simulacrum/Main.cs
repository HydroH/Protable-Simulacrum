using System;
using System.Collections.Generic;
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

            cbbModList.DataSource = new BindingSource(ModList.rifleModList, null);
            cbbModList.DisplayMember = "Key";
            cbbModList.ValueMember = "Value";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Data.Simdata result = new Data.Simdata(0, 0), temp = new Data.Simdata();
            bool timeExceed = false;
            Mod mod = new Mod();
            foreach (DataGridViewRow row in dgvMod.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[1].Value == null) break;
                mod.Combine(((Mod)row.Cells[2].Value).Scale(Convert.ToInt32(row.Cells[1].Value.ToString())));
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

        private void btnAddMod_Click(object sender, EventArgs e)
        {
            int index = dgvMod.Rows.Add();
            dgvMod.Rows[index].Cells[0].Value = cbbModList.Text;
            dgvMod.Rows[index].Cells[1].Value = (int)nudModLevel.Value;
            dgvMod.Rows[index].Cells[2].Value = cbbModList.SelectedValue;
            
            ((BindingSource)cbbModList.DataSource).Remove(new KeyValuePair<string, Mod>((string)dgvMod.Rows[index].Cells[0].Value, (Mod)dgvMod.Rows[index].Cells[2].Value));
        }

        private void dgvMod_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            ((BindingSource)cbbModList.DataSource).Add(new KeyValuePair<string, Mod>((string)e.Row.Cells[0].Value, (Mod)e.Row.Cells[2].Value));
        }
    }
}
