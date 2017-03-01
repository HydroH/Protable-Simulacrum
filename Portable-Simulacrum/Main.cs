using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Portable_Simulacrum
{
    public partial class Main : Form
    {
        private Data.WeaponType lastType = Data.WeaponType.Rifle;
        private Button lastDragBtn;
        private NumericLeftRight lastDragNlr;

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

            for (char i = '1'; i <= '8'; i++)
            {
                Controls.Find("btnMod" + i, true).FirstOrDefault().Tag = new Data.ModData(new Mod(), "", "", 0);
            }
        }

        public void ShowStats()
        {
            if (cbbWeapon.SelectedValue == null) return;
            Mod mod = SumMod();
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

        private bool AddMod(Mod mod, string name, string desc, int level)
        {
            Data.ModData modData;
            Button btn;
            NumericLeftRight nlr;
            for (char i = '1'; i <= '8'; i++)
            {
                btn = (Button)Controls.Find("btnMod" + i, true).FirstOrDefault();
                modData = (Data.ModData)btn.Tag;
                if (modData.name == "")
                {
                    btn.Tag = new Data.ModData(mod, name, desc, level);
                    btn.Text = name;
                    nlr = (NumericLeftRight)Controls.Find("nlrMod" + i, true).FirstOrDefault();
                    nlr.NumericUpDown.Maximum = mod.maxLevel;
                    nlr.NumericUpDown.Value = level;
                    return true;
                }
            }
            return false;
        }

        private Mod SumMod()
        {
            Mod mod = new Mod();
            Button btn;
            Data.ModData modData;
            for (char i = '1'; i <= '8'; i++)
            {
                btn = (Button)Controls.Find("btnMod" + i, true).FirstOrDefault();
                modData = (Data.ModData)btn.Tag;
                if (modData.name != "")
                {
                    mod.Combine(modData.mod.Scale(modData.level));
                }
            }
            return mod;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (cbbWeapon.SelectedIndex == -1) return;
            Data.Simdata result = new Data.Simdata(0, 0), temp = new Data.Simdata();
            bool timeExceed = false;
            string resultText = "";
            Enemy enemy = ((Enemy)cbbEnemyType.SelectedValue).Scale((int)nudEnemyLevel.Value);
            double fullHitpoint = enemy.health + enemy.shield;
            Mod mod = SumMod();

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
                if (newRiven.ShowDialog() != DialogResult.OK || !AddMod(newRiven.rivenMod, "裂罅MOD", "裂罅MOD", 0)) return;
            }
            else
            {
                if (!AddMod((Mod)cbbModList.SelectedValue, cbbModList.Text, cbbModList.Text, (int)nudModLevel.Value)) return;
            }

            ((BindingSource)cbbModList.DataSource).Remove(new KeyValuePair<string, Mod>(cbbModList.Text, (Mod)cbbModList.SelectedValue));
            if (cbbModList.SelectedValue != null) nudModLevel.Value = nudModLevel.Maximum = ((Mod)cbbModList.SelectedValue).maxLevel;
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
            for (char i = '1'; i <= '8'; i++)
            {
                Controls.Find("btnMod" + i, true).FirstOrDefault().Tag = new Data.ModData(new Mod(), "", "", 0);
            }
            lastType = currType;
            ShowStats();
        }

        private void cbbModList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nudModLevel.Enabled = true;
            if (cbbModList.SelectedValue != null) nudModLevel.Value = nudModLevel.Maximum = ((Mod)cbbModList.SelectedValue).maxLevel;
            btnAddMod.Enabled = true;
        }

        private void btn_MouseDown(Button btn, NumericLeftRight nlr, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) return;
            lastDragBtn = btn;
            lastDragNlr = nlr;
            btn.DoDragDrop(btn.Tag, DragDropEffects.Copy | DragDropEffects.Move);
        }
        private void btn_DragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Data.ModData)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void btn_DragDrop(Button btn, NumericLeftRight nlr, DragEventArgs e)
        {
            Data.ModData modData = ((Data.ModData)e.Data.GetData(typeof(Data.ModData))).Clone();
            lastDragBtn.Tag = btn.Tag;
            lastDragBtn.Text = btn.Text;
            lastDragNlr.NumericUpDown.Maximum = nlr.NumericUpDown.Maximum;
            lastDragNlr.NumericUpDown.Value = nlr.NumericUpDown.Value;
            btn.Tag = modData;
            btn.Text = modData.description;
            nlr.NumericUpDown.Maximum = modData.mod.maxLevel;
            nlr.NumericUpDown.Value = modData.level;
            ShowStats();
        }

        private void btnMod1_MouseDown(object sender, MouseEventArgs e) { btn_MouseDown(btnMod1, nlrMod1, e); }
        private void btnMod1_DragEnter(object sender, DragEventArgs e) { btn_DragEnter(e); }
        private void btnMod1_DragDrop(object sender, DragEventArgs e) { btn_DragDrop(btnMod1, nlrMod1, e); }

        private void btnMod2_MouseDown(object sender, MouseEventArgs e) { btn_MouseDown(btnMod2, nlrMod2, e); }
        private void btnMod2_DragEnter(object sender, DragEventArgs e) { btn_DragEnter(e); }
        private void btnMod2_DragDrop(object sender, DragEventArgs e) { btn_DragDrop(btnMod2, nlrMod2, e); }

        private void btnMod3_MouseDown(object sender, MouseEventArgs e) { btn_MouseDown(btnMod3, nlrMod3, e); }
        private void btnMod3_DragEnter(object sender, DragEventArgs e) { btn_DragEnter(e); }
        private void btnMod3_DragDrop(object sender, DragEventArgs e) { btn_DragDrop(btnMod3, nlrMod3, e); }

        private void btnMod4_MouseDown(object sender, MouseEventArgs e) { btn_MouseDown(btnMod4, nlrMod4, e); }
        private void btnMod4_DragEnter(object sender, DragEventArgs e) { btn_DragEnter(e); }
        private void btnMod4_DragDrop(object sender, DragEventArgs e) { btn_DragDrop(btnMod4, nlrMod4, e); }

        private void btnMod5_MouseDown(object sender, MouseEventArgs e) { btn_MouseDown(btnMod5, nlrMod5, e); }
        private void btnMod5_DragEnter(object sender, DragEventArgs e) { btn_DragEnter(e); }
        private void btnMod5_DragDrop(object sender, DragEventArgs e) { btn_DragDrop(btnMod5, nlrMod5, e); }

        private void btnMod6_MouseDown(object sender, MouseEventArgs e) { btn_MouseDown(btnMod6, nlrMod6, e); }
        private void btnMod6_DragEnter(object sender, DragEventArgs e) { btn_DragEnter(e); }
        private void btnMod6_DragDrop(object sender, DragEventArgs e) { btn_DragDrop(btnMod6, nlrMod6, e); }

        private void btnMod7_MouseDown(object sender, MouseEventArgs e) { btn_MouseDown(btnMod7, nlrMod7, e); }
        private void btnMod7_DragEnter(object sender, DragEventArgs e) { btn_DragEnter(e); }
        private void btnMod7_DragDrop(object sender, DragEventArgs e) { btn_DragDrop(btnMod7, nlrMod7, e); }

        private void btnMod8_MouseDown(object sender, MouseEventArgs e) { btn_MouseDown(btnMod8, nlrMod8, e); }
        private void btnMod8_DragEnter(object sender, DragEventArgs e) { btn_DragEnter(e); }
        private void btnMod8_DragDrop(object sender, DragEventArgs e) { btn_DragDrop(btnMod8, nlrMod8, e); }

        private void btnMod_Click(Button btn, NumericLeftRight nlr, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) return;
            if (!btn.ClientRectangle.Contains(e.Location)) return;
            Data.ModData modData = (Data.ModData)btn.Tag;
            if (modData.name == "") return;
            ((BindingSource)cbbModList.DataSource).Add(new KeyValuePair<string, Mod>(modData.name, modData.mod));
            btn.Tag = new Data.ModData(new Mod(), "", "", 0);
            btn.Text = "";
            nlr.NumericUpDown.Value = nlr.NumericUpDown.Maximum = 0;
            ShowStats();
        }

        private void btnMod1_MouseUp(object sender, MouseEventArgs e) { btnMod_Click(btnMod1, nlrMod1, e); }
        private void btnMod2_MouseUp(object sender, MouseEventArgs e) { btnMod_Click(btnMod2, nlrMod2, e); }
        private void btnMod3_MouseUp(object sender, MouseEventArgs e) { btnMod_Click(btnMod3, nlrMod3, e); }
        private void btnMod4_MouseUp(object sender, MouseEventArgs e) { btnMod_Click(btnMod4, nlrMod4, e); }
        private void btnMod5_MouseUp(object sender, MouseEventArgs e) { btnMod_Click(btnMod5, nlrMod5, e); }
        private void btnMod6_MouseUp(object sender, MouseEventArgs e) { btnMod_Click(btnMod6, nlrMod6, e); }
        private void btnMod7_MouseUp(object sender, MouseEventArgs e) { btnMod_Click(btnMod7, nlrMod7, e); }
        private void btnMod8_MouseUp(object sender, MouseEventArgs e) { btnMod_Click(btnMod8, nlrMod8, e); }

        private void nlrMod_Click(NumericLeftRight nlr, Button btn)
        {
            Data.ModData modData = (Data.ModData)btn.Tag;
            btn.Tag = new Data.ModData(modData.mod, modData.name, modData.description, (int)nlr.NumericUpDown.Value);
            ShowStats();
        }

        private void nlrMod1_ValueChanged(object sender, EventArgs e) { nlrMod_Click(nlrMod1, btnMod1); }
        private void nlrMod2_ValueChanged(object sender, EventArgs e) { nlrMod_Click(nlrMod2, btnMod2); }
        private void nlrMod3_ValueChanged(object sender, EventArgs e) { nlrMod_Click(nlrMod3, btnMod3); }
        private void nlrMod4_ValueChanged(object sender, EventArgs e) { nlrMod_Click(nlrMod4, btnMod4); }
        private void nlrMod5_ValueChanged(object sender, EventArgs e) { nlrMod_Click(nlrMod5, btnMod5); }
        private void nlrMod6_ValueChanged(object sender, EventArgs e) { nlrMod_Click(nlrMod6, btnMod6); }
        private void nlrMod7_ValueChanged(object sender, EventArgs e) { nlrMod_Click(nlrMod7, btnMod7); }
        private void nlrMod8_ValueChanged(object sender, EventArgs e) { nlrMod_Click(nlrMod8, btnMod8); }
    }
}
