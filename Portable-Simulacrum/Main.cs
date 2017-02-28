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

        public void ShowStats()
        {
            Mod mod = new Mod();
            foreach (DataGridViewRow row in dgvMod.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[1].Value == null) break;
                mod.Combine(((Mod)row.Cells[2].Value).Scale(Convert.ToInt32(row.Cells[1].Value.ToString())));
            }
            Weapon modWeapon = ((Weapon)cbbWeapon.SelectedValue).Modify(mod);

            string statText = "";
            for (int i = 0; i < (int)Data.DamageType.Cap; i++)
            {
                if (modWeapon.damage.dmgArray[i] != 0)
                {
                    statText += Data.damageText[(Data.DamageType)i] + " " + (modWeapon.damage.dmgArray[i] * modWeapon.multiShot).ToString("N2") + "\n";
                }
            }
            statText += "\n";
            statText += "多重射击 " + modWeapon.multiShot.ToString("N2") + "\n";
            statText += "暴击几率 " + (100 * modWeapon.critChan).ToString("N2") + "%\n";
            statText += "暴击倍率 " + modWeapon.critMult.ToString("N2") + "x\n";
            statText += "总触发几率 " + (100 * modWeapon.totalStatChan).ToString("N2") + "%\n";
            statText += "弹片触发几率 " + (100 * modWeapon.pelletStatChan).ToString("N2") + "%\n";
            statText += "射速 " + modWeapon.fireRate.ToString("N2") + "\n";
            statText += "换弹时间 " + modWeapon.reload.ToString("N2") + "\n";
            statText += "弹匣 " + modWeapon.clip.ToString("N2") + "\n";
            lblStats.Text = statText;
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
                temp = ((Weapon)cbbWeapon.SelectedValue).SimKill(((Enemy)cbbEnemyType.SelectedValue).Scale((int)nudEnemyLevel.Value), mod.Clone(), cbHeadshot.Checked);
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
            if (cbbModList.Text == "裂罅MOD")
            {
                AddRiven newRiven = new AddRiven();
                if (newRiven.ShowDialog() == DialogResult.OK)
                {
                    int index = dgvMod.Rows.Add();
                    dgvMod.Rows[index].Cells[0].Value = "裂罅MOD";
                    dgvMod.Rows[index].Cells[1].Value = 0;
                    dgvMod.Rows[index].Cells[2].Value = newRiven.rivenMod;
                    ((BindingSource)cbbModList.DataSource).Remove(new KeyValuePair<string, Mod>((string)cbbModList.Text, (Mod)cbbModList.SelectedValue));
                    ShowStats();
                }
            }
            else
            {
                int index = dgvMod.Rows.Add();
                dgvMod.Rows[index].Cells[0].Value = cbbModList.Text;
                dgvMod.Rows[index].Cells[1].Value = (int)nudModLevel.Value;
                dgvMod.Rows[index].Cells[2].Value = cbbModList.SelectedValue;
                ((BindingSource)cbbModList.DataSource).Remove(new KeyValuePair<string, Mod>((string)dgvMod.Rows[index].Cells[0].Value, (Mod)dgvMod.Rows[index].Cells[2].Value));
                ShowStats();
            }
        }

        private void dgvMod_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            ((BindingSource)cbbModList.DataSource).Add(new KeyValuePair<string, Mod>((string)e.Row.Cells[0].Value, (Mod)e.Row.Cells[2].Value));
        }

        private void dgvMod_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            ShowStats();
        }

        private void dgvMod_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ShowStats();
        }
    }
}
