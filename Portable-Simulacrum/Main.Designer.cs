namespace Portable_Simulacrum
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalc = new System.Windows.Forms.Button();
            this.cbbEnemyType = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblEnemyType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudEnemyLevel = new System.Windows.Forms.NumericUpDown();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.cbbWeapon = new System.Windows.Forms.ComboBox();
            this.cbbModList = new System.Windows.Forms.ComboBox();
            this.btnAddMod = new System.Windows.Forms.Button();
            this.nudModLevel = new System.Windows.Forms.NumericUpDown();
            this.cbHeadshot = new System.Windows.Forms.CheckBox();
            this.lblStats = new System.Windows.Forms.Label();
            this.btnMod1 = new System.Windows.Forms.Button();
            this.btnMod2 = new System.Windows.Forms.Button();
            this.btnMod3 = new System.Windows.Forms.Button();
            this.btnMod4 = new System.Windows.Forms.Button();
            this.btnMod5 = new System.Windows.Forms.Button();
            this.btnMod6 = new System.Windows.Forms.Button();
            this.btnMod7 = new System.Windows.Forms.Button();
            this.btnMod8 = new System.Windows.Forms.Button();
            this.nlrMod8 = new Portable_Simulacrum.NumericLeftRight();
            this.nlrMod7 = new Portable_Simulacrum.NumericLeftRight();
            this.nlrMod6 = new Portable_Simulacrum.NumericLeftRight();
            this.nlrMod5 = new Portable_Simulacrum.NumericLeftRight();
            this.nlrMod4 = new Portable_Simulacrum.NumericLeftRight();
            this.nlrMod3 = new Portable_Simulacrum.NumericLeftRight();
            this.nlrMod2 = new Portable_Simulacrum.NumericLeftRight();
            this.nlrMod1 = new Portable_Simulacrum.NumericLeftRight();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnemyLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Enabled = false;
            this.btnCalc.Location = new System.Drawing.Point(562, 425);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "计算！";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // cbbEnemyType
            // 
            this.cbbEnemyType.FormattingEnabled = true;
            this.cbbEnemyType.Location = new System.Drawing.Point(516, 343);
            this.cbbEnemyType.Name = "cbbEnemyType";
            this.cbbEnemyType.Size = new System.Drawing.Size(121, 23);
            this.cbbEnemyType.TabIndex = 11;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(448, 469);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 19;
            // 
            // lblEnemyType
            // 
            this.lblEnemyType.AutoSize = true;
            this.lblEnemyType.Location = new System.Drawing.Point(443, 344);
            this.lblEnemyType.Name = "lblEnemyType";
            this.lblEnemyType.Size = new System.Drawing.Size(67, 15);
            this.lblEnemyType.TabIndex = 21;
            this.lblEnemyType.Text = "敌人类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "敌人等级";
            // 
            // nudEnemyLevel
            // 
            this.nudEnemyLevel.Location = new System.Drawing.Point(517, 382);
            this.nudEnemyLevel.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudEnemyLevel.Name = "nudEnemyLevel";
            this.nudEnemyLevel.Size = new System.Drawing.Size(120, 25);
            this.nudEnemyLevel.TabIndex = 23;
            // 
            // lblWeapon
            // 
            this.lblWeapon.AutoSize = true;
            this.lblWeapon.Location = new System.Drawing.Point(44, 24);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWeapon.Size = new System.Drawing.Size(37, 15);
            this.lblWeapon.TabIndex = 25;
            this.lblWeapon.Text = "武器";
            // 
            // cbbWeapon
            // 
            this.cbbWeapon.FormattingEnabled = true;
            this.cbbWeapon.Location = new System.Drawing.Point(87, 19);
            this.cbbWeapon.Name = "cbbWeapon";
            this.cbbWeapon.Size = new System.Drawing.Size(157, 23);
            this.cbbWeapon.TabIndex = 24;
            this.cbbWeapon.SelectionChangeCommitted += new System.EventHandler(this.cbbWeapon_SelectionChangeCommitted);
            // 
            // cbbModList
            // 
            this.cbbModList.Enabled = false;
            this.cbbModList.FormattingEnabled = true;
            this.cbbModList.Location = new System.Drawing.Point(389, 17);
            this.cbbModList.Name = "cbbModList";
            this.cbbModList.Size = new System.Drawing.Size(121, 23);
            this.cbbModList.TabIndex = 28;
            this.cbbModList.SelectionChangeCommitted += new System.EventHandler(this.cbbModList_SelectionChangeCommitted);
            // 
            // btnAddMod
            // 
            this.btnAddMod.Enabled = false;
            this.btnAddMod.Location = new System.Drawing.Point(592, 16);
            this.btnAddMod.Name = "btnAddMod";
            this.btnAddMod.Size = new System.Drawing.Size(75, 26);
            this.btnAddMod.TabIndex = 27;
            this.btnAddMod.Text = "添加MOD";
            this.btnAddMod.UseVisualStyleBackColor = true;
            this.btnAddMod.Click += new System.EventHandler(this.btnAddMod_Click);
            // 
            // nudModLevel
            // 
            this.nudModLevel.Enabled = false;
            this.nudModLevel.Location = new System.Drawing.Point(516, 17);
            this.nudModLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudModLevel.Name = "nudModLevel";
            this.nudModLevel.Size = new System.Drawing.Size(70, 25);
            this.nudModLevel.TabIndex = 29;
            // 
            // cbHeadshot
            // 
            this.cbHeadshot.AutoSize = true;
            this.cbHeadshot.Location = new System.Drawing.Point(451, 429);
            this.cbHeadshot.Name = "cbHeadshot";
            this.cbHeadshot.Size = new System.Drawing.Size(59, 19);
            this.cbHeadshot.TabIndex = 30;
            this.cbHeadshot.Text = "爆头";
            this.cbHeadshot.UseVisualStyleBackColor = true;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(75, 341);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(0, 15);
            this.lblStats.TabIndex = 31;
            // 
            // btnMod1
            // 
            this.btnMod1.AllowDrop = true;
            this.btnMod1.Location = new System.Drawing.Point(48, 65);
            this.btnMod1.Name = "btnMod1";
            this.btnMod1.Size = new System.Drawing.Size(151, 100);
            this.btnMod1.TabIndex = 32;
            this.btnMod1.UseVisualStyleBackColor = true;
            this.btnMod1.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnMod1_DragDrop);
            this.btnMod1.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnMod1_DragEnter);
            this.btnMod1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMod1_MouseDown);
            this.btnMod1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMod1_MouseUp);
            // 
            // btnMod2
            // 
            this.btnMod2.AllowDrop = true;
            this.btnMod2.Location = new System.Drawing.Point(204, 65);
            this.btnMod2.Name = "btnMod2";
            this.btnMod2.Size = new System.Drawing.Size(151, 100);
            this.btnMod2.TabIndex = 33;
            this.btnMod2.UseVisualStyleBackColor = true;
            this.btnMod2.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnMod2_DragDrop);
            this.btnMod2.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnMod2_DragEnter);
            this.btnMod2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMod2_MouseDown);
            this.btnMod2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMod2_MouseUp);
            // 
            // btnMod3
            // 
            this.btnMod3.AllowDrop = true;
            this.btnMod3.Location = new System.Drawing.Point(360, 65);
            this.btnMod3.Name = "btnMod3";
            this.btnMod3.Size = new System.Drawing.Size(151, 100);
            this.btnMod3.TabIndex = 34;
            this.btnMod3.UseVisualStyleBackColor = true;
            this.btnMod3.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnMod3_DragDrop);
            this.btnMod3.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnMod3_DragEnter);
            this.btnMod3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMod3_MouseDown);
            this.btnMod3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMod3_MouseUp);
            // 
            // btnMod4
            // 
            this.btnMod4.AllowDrop = true;
            this.btnMod4.Location = new System.Drawing.Point(516, 65);
            this.btnMod4.Name = "btnMod4";
            this.btnMod4.Size = new System.Drawing.Size(151, 100);
            this.btnMod4.TabIndex = 35;
            this.btnMod4.UseVisualStyleBackColor = true;
            this.btnMod4.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnMod4_DragDrop);
            this.btnMod4.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnMod4_DragEnter);
            this.btnMod4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMod4_MouseDown);
            this.btnMod4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMod4_MouseUp);
            // 
            // btnMod5
            // 
            this.btnMod5.AllowDrop = true;
            this.btnMod5.Location = new System.Drawing.Point(48, 199);
            this.btnMod5.Name = "btnMod5";
            this.btnMod5.Size = new System.Drawing.Size(151, 100);
            this.btnMod5.TabIndex = 36;
            this.btnMod5.UseVisualStyleBackColor = true;
            this.btnMod5.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnMod5_DragDrop);
            this.btnMod5.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnMod5_DragEnter);
            this.btnMod5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMod5_MouseDown);
            this.btnMod5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMod5_MouseUp);
            // 
            // btnMod6
            // 
            this.btnMod6.AllowDrop = true;
            this.btnMod6.Location = new System.Drawing.Point(204, 199);
            this.btnMod6.Name = "btnMod6";
            this.btnMod6.Size = new System.Drawing.Size(151, 100);
            this.btnMod6.TabIndex = 37;
            this.btnMod6.UseVisualStyleBackColor = true;
            this.btnMod6.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnMod6_DragDrop);
            this.btnMod6.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnMod6_DragEnter);
            this.btnMod6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMod6_MouseDown);
            this.btnMod6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMod6_MouseUp);
            // 
            // btnMod7
            // 
            this.btnMod7.AllowDrop = true;
            this.btnMod7.Location = new System.Drawing.Point(360, 199);
            this.btnMod7.Name = "btnMod7";
            this.btnMod7.Size = new System.Drawing.Size(151, 100);
            this.btnMod7.TabIndex = 38;
            this.btnMod7.UseVisualStyleBackColor = true;
            this.btnMod7.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnMod7_DragDrop);
            this.btnMod7.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnMod7_DragEnter);
            this.btnMod7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMod7_MouseDown);
            this.btnMod7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMod7_MouseUp);
            // 
            // btnMod8
            // 
            this.btnMod8.AllowDrop = true;
            this.btnMod8.Location = new System.Drawing.Point(516, 199);
            this.btnMod8.Name = "btnMod8";
            this.btnMod8.Size = new System.Drawing.Size(151, 100);
            this.btnMod8.TabIndex = 39;
            this.btnMod8.UseVisualStyleBackColor = true;
            this.btnMod8.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnMod8_DragDrop);
            this.btnMod8.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnMod8_DragEnter);
            this.btnMod8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMod8_MouseDown);
            this.btnMod8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMod8_MouseUp);
            // 
            // nlrMod8
            // 
            this.nlrMod8.Location = new System.Drawing.Point(517, 298);
            this.nlrMod8.Name = "nlrMod8";
            this.nlrMod8.Size = new System.Drawing.Size(149, 25);
            this.nlrMod8.TabIndex = 47;
            this.nlrMod8.ValueChanged += new System.EventHandler(this.nlrMod8_ValueChanged);
            // 
            // nlrMod7
            // 
            this.nlrMod7.Location = new System.Drawing.Point(361, 298);
            this.nlrMod7.Name = "nlrMod7";
            this.nlrMod7.Size = new System.Drawing.Size(149, 25);
            this.nlrMod7.TabIndex = 46;
            this.nlrMod7.ValueChanged += new System.EventHandler(this.nlrMod7_ValueChanged);
            // 
            // nlrMod6
            // 
            this.nlrMod6.Location = new System.Drawing.Point(205, 298);
            this.nlrMod6.Name = "nlrMod6";
            this.nlrMod6.Size = new System.Drawing.Size(149, 25);
            this.nlrMod6.TabIndex = 45;
            this.nlrMod6.ValueChanged += new System.EventHandler(this.nlrMod6_ValueChanged);
            // 
            // nlrMod5
            // 
            this.nlrMod5.Location = new System.Drawing.Point(49, 298);
            this.nlrMod5.Name = "nlrMod5";
            this.nlrMod5.Size = new System.Drawing.Size(149, 25);
            this.nlrMod5.TabIndex = 44;
            this.nlrMod5.ValueChanged += new System.EventHandler(this.nlrMod5_ValueChanged);
            // 
            // nlrMod4
            // 
            this.nlrMod4.Location = new System.Drawing.Point(517, 164);
            this.nlrMod4.Name = "nlrMod4";
            this.nlrMod4.Size = new System.Drawing.Size(149, 25);
            this.nlrMod4.TabIndex = 43;
            this.nlrMod4.ValueChanged += new System.EventHandler(this.nlrMod4_ValueChanged);
            // 
            // nlrMod3
            // 
            this.nlrMod3.Location = new System.Drawing.Point(361, 164);
            this.nlrMod3.Name = "nlrMod3";
            this.nlrMod3.Size = new System.Drawing.Size(149, 25);
            this.nlrMod3.TabIndex = 42;
            this.nlrMod3.ValueChanged += new System.EventHandler(this.nlrMod3_ValueChanged);
            // 
            // nlrMod2
            // 
            this.nlrMod2.Location = new System.Drawing.Point(205, 164);
            this.nlrMod2.Name = "nlrMod2";
            this.nlrMod2.Size = new System.Drawing.Size(149, 25);
            this.nlrMod2.TabIndex = 41;
            this.nlrMod2.ValueChanged += new System.EventHandler(this.nlrMod2_ValueChanged);
            // 
            // nlrMod1
            // 
            this.nlrMod1.Location = new System.Drawing.Point(49, 164);
            this.nlrMod1.Name = "nlrMod1";
            this.nlrMod1.Size = new System.Drawing.Size(149, 25);
            this.nlrMod1.TabIndex = 40;
            this.nlrMod1.ValueChanged += new System.EventHandler(this.nlrMod1_ValueChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 597);
            this.Controls.Add(this.nlrMod8);
            this.Controls.Add(this.nlrMod7);
            this.Controls.Add(this.nlrMod6);
            this.Controls.Add(this.nlrMod5);
            this.Controls.Add(this.nlrMod4);
            this.Controls.Add(this.nlrMod3);
            this.Controls.Add(this.nlrMod2);
            this.Controls.Add(this.nlrMod1);
            this.Controls.Add(this.btnMod8);
            this.Controls.Add(this.btnMod7);
            this.Controls.Add(this.btnMod6);
            this.Controls.Add(this.btnMod5);
            this.Controls.Add(this.btnMod4);
            this.Controls.Add(this.btnMod3);
            this.Controls.Add(this.btnMod2);
            this.Controls.Add(this.btnMod1);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.cbHeadshot);
            this.Controls.Add(this.nudModLevel);
            this.Controls.Add(this.cbbModList);
            this.Controls.Add(this.btnAddMod);
            this.Controls.Add(this.lblWeapon);
            this.Controls.Add(this.cbbWeapon);
            this.Controls.Add(this.nudEnemyLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnemyType);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cbbEnemyType);
            this.Controls.Add(this.btnCalc);
            this.Name = "Main";
            this.Text = "伪·幻影装置";
            ((System.ComponentModel.ISupportInitialize)(this.nudEnemyLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ComboBox cbbEnemyType;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblEnemyType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudEnemyLevel;
        private System.Windows.Forms.Label lblWeapon;
        private System.Windows.Forms.ComboBox cbbWeapon;
        private System.Windows.Forms.ComboBox cbbModList;
        private System.Windows.Forms.Button btnAddMod;
        private System.Windows.Forms.NumericUpDown nudModLevel;
        private System.Windows.Forms.CheckBox cbHeadshot;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnMod1;
        private System.Windows.Forms.Button btnMod2;
        private System.Windows.Forms.Button btnMod3;
        private System.Windows.Forms.Button btnMod4;
        private System.Windows.Forms.Button btnMod5;
        private System.Windows.Forms.Button btnMod6;
        private System.Windows.Forms.Button btnMod7;
        private System.Windows.Forms.Button btnMod8;
        private NumericLeftRight nlrMod1;
        private NumericLeftRight nlrMod2;
        private NumericLeftRight nlrMod3;
        private NumericLeftRight nlrMod4;
        private NumericLeftRight nlrMod5;
        private NumericLeftRight nlrMod6;
        private NumericLeftRight nlrMod7;
        private NumericLeftRight nlrMod8;
    }
}

