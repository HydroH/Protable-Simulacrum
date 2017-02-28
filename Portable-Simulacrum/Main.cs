using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Portable_Simulacrum
{
    public partial class Main : Form
    {
        private Data.WeaponType lastType = Data.WeaponType.Rifle;

        public Main()
        {
            InitializeComponent();

            cbbWeapon.DataSource = new BindingSource(WeaponList.weaponList, null);
            cbbWeapon.DisplayMember = "Key";
            cbbWeapon.ValueMember = "Value";
            cbbWeapon.SelectedIndex = -1;

            cbbEnemyType.DataSource = new BindingSource(EnemyList.enemyList, null);
            cbbEnemyType.DisplayMember = "Key";
            cbbEnemyType.ValueMember = "Value";

            cbbModList.DataSource = new BindingSource(ModList.rifleModList, null);
            cbbModList.DisplayMember = "Key";
            cbbModList.ValueMember = "Value";
            cbbModList.SelectedIndex = -1;
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
            statText += "弹匣 " + modWeapon.clip.ToString("N2") + "\n\n";

            int critInt = (int)modWeapon.critChan;
            double critDec = modWeapon.critChan - (double)critInt;
            double theoryDPS = modWeapon.damage.totalDmg * modWeapon.multiShot * ((critDec * (1 + critInt) + (1 - critDec) * critInt) * (modWeapon.critMult - 1) + 1) * modWeapon.fireRate;
            statText += "理论爆发DPS " + theoryDPS.ToString("N2") + "\n";
            statText += "理论持续DPS " + (theoryDPS * ((modWeapon.clip / modWeapon.fireRate) / (modWeapon.clip / modWeapon.fireRate + modWeapon.reload))).ToString("N2");
            lblStats.Text = statText;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (cbbWeapon.SelectedIndex == -1) return;
            Data.Simdata result = new Data.Simdata(0, 0), temp = new Data.Simdata();
            bool timeExceed = false;
            string resultText = "";
            Enemy enemy = ((Enemy)cbbEnemyType.SelectedValue).Scale((int)nudEnemyLevel.Value);
            double fullHitpoint = enemy.health + enemy.shield;
            Mod mod = new Mod();
            foreach (DataGridViewRow row in dgvMod.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[1].Value == null) break;
                mod.Combine(((Mod)row.Cells[2].Value).Scale(Convert.ToInt32(row.Cells[1].Value.ToString())));
            }

            for (int i = 0; i < Data.cycles; i++)
            {
                temp = ((Weapon)cbbWeapon.SelectedValue).SimKill(enemy.Clone(), mod.Clone(), cbHeadshot.Checked);
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
            resultText += "耗时 " + (timeExceed ? "180秒以上" : (result.time.ToString("N2") + "s")) + "\n";
            resultText += "耗弹 " + (timeExceed ? "耗时过长" : result.shots.ToString("N2")) + "\n";
            resultText += "实际DPS " + (timeExceed ? "N/A" : (fullHitpoint / result.time).ToString("N2")) + "\n";
            lblResult.Text = resultText;
        }

        private void btnAddMod_Click(object sender, EventArgs e)
        {
            if (cbbModList.SelectedIndex == -1) return;
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
                    nudModLevel.Value = nudModLevel.Maximum = ((Mod)cbbModList.SelectedValue).maxLevel;
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
                if (cbbModList.SelectedValue != null) nudModLevel.Value = nudModLevel.Maximum = ((Mod)cbbModList.SelectedValue).maxLevel;
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

        private void cbbWeapon_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbbModList.Enabled = true;
            btnCalc.Enabled = true;
            Data.WeaponType currType = ((Weapon)cbbWeapon.SelectedValue).type;
            if (lastType == currType || (lastType == Data.WeaponType.Rifle && currType == Data.WeaponType.Bow) || (lastType == Data.WeaponType.Bow && currType == Data.WeaponType.Rifle))
            {
                ShowStats();
                return;
            }
            switch (currType)
            {
                case Data.WeaponType.Rifle:
                case Data.WeaponType.Bow:
                    cbbModList.DataSource = new BindingSource(ModList.rifleModList, null);
                    break;
                case Data.WeaponType.Shotgun:
                    cbbModList.DataSource = new BindingSource(ModList.shotgunModList, null);
                    break;
            }
            cbbModList.DisplayMember = "Key";
            cbbModList.ValueMember = "Value";
            cbbModList.SelectedIndex = -1;
            dgvMod.Rows.Clear();
            lastType = currType;
            ShowStats();
        }

        private void cbbModList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nudModLevel.Enabled = true;
            if (cbbModList.SelectedValue != null) nudModLevel.Value = nudModLevel.Maximum = ((Mod)cbbModList.SelectedValue).maxLevel;
            btnAddMod.Enabled = true;
        }
    }
}
