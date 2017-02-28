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
            this.lblResultTime = new System.Windows.Forms.Label();
            this.lblResultShots = new System.Windows.Forms.Label();
            this.lblLabelShots = new System.Windows.Forms.Label();
            this.lblLabelTime = new System.Windows.Forms.Label();
            this.lblEnemyType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudEnemyLevel = new System.Windows.Forms.NumericUpDown();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.cbbWeapon = new System.Windows.Forms.ComboBox();
            this.dgvMod = new System.Windows.Forms.DataGridView();
            this.dgvcModName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcModLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModInstance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbModList = new System.Windows.Forms.ComboBox();
            this.btnAddMod = new System.Windows.Forms.Button();
            this.nudModLevel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnemyLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(448, 365);
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
            this.cbbEnemyType.Location = new System.Drawing.Point(402, 270);
            this.cbbEnemyType.Name = "cbbEnemyType";
            this.cbbEnemyType.Size = new System.Drawing.Size(121, 23);
            this.cbbEnemyType.TabIndex = 11;
            // 
            // lblResultTime
            // 
            this.lblResultTime.AutoSize = true;
            this.lblResultTime.Location = new System.Drawing.Point(494, 409);
            this.lblResultTime.Name = "lblResultTime";
            this.lblResultTime.Size = new System.Drawing.Size(31, 15);
            this.lblResultTime.TabIndex = 13;
            this.lblResultTime.Text = "N/A";
            // 
            // lblResultShots
            // 
            this.lblResultShots.AutoSize = true;
            this.lblResultShots.Location = new System.Drawing.Point(494, 440);
            this.lblResultShots.Name = "lblResultShots";
            this.lblResultShots.Size = new System.Drawing.Size(31, 15);
            this.lblResultShots.TabIndex = 14;
            this.lblResultShots.Text = "N/A";
            // 
            // lblLabelShots
            // 
            this.lblLabelShots.AutoSize = true;
            this.lblLabelShots.Location = new System.Drawing.Point(421, 440);
            this.lblLabelShots.Name = "lblLabelShots";
            this.lblLabelShots.Size = new System.Drawing.Size(67, 15);
            this.lblLabelShots.TabIndex = 20;
            this.lblLabelShots.Text = "子弹数：";
            // 
            // lblLabelTime
            // 
            this.lblLabelTime.AutoSize = true;
            this.lblLabelTime.Location = new System.Drawing.Point(435, 409);
            this.lblLabelTime.Name = "lblLabelTime";
            this.lblLabelTime.Size = new System.Drawing.Size(52, 15);
            this.lblLabelTime.TabIndex = 19;
            this.lblLabelTime.Text = "耗时：";
            // 
            // lblEnemyType
            // 
            this.lblEnemyType.AutoSize = true;
            this.lblEnemyType.Location = new System.Drawing.Point(329, 271);
            this.lblEnemyType.Name = "lblEnemyType";
            this.lblEnemyType.Size = new System.Drawing.Size(67, 15);
            this.lblEnemyType.TabIndex = 21;
            this.lblEnemyType.Text = "敌人类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "敌人等级";
            // 
            // nudEnemyLevel
            // 
            this.nudEnemyLevel.Location = new System.Drawing.Point(403, 309);
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
            this.lblWeapon.Location = new System.Drawing.Point(30, 24);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWeapon.Size = new System.Drawing.Size(37, 15);
            this.lblWeapon.TabIndex = 25;
            this.lblWeapon.Text = "武器";
            // 
            // cbbWeapon
            // 
            this.cbbWeapon.FormattingEnabled = true;
            this.cbbWeapon.Location = new System.Drawing.Point(73, 19);
            this.cbbWeapon.Name = "cbbWeapon";
            this.cbbWeapon.Size = new System.Drawing.Size(121, 23);
            this.cbbWeapon.TabIndex = 24;
            // 
            // dgvMod
            // 
            this.dgvMod.AllowUserToAddRows = false;
            this.dgvMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcModName,
            this.dgvcModLevel,
            this.ModInstance});
            this.dgvMod.Location = new System.Drawing.Point(33, 68);
            this.dgvMod.Name = "dgvMod";
            this.dgvMod.RowTemplate.Height = 27;
            this.dgvMod.Size = new System.Drawing.Size(278, 297);
            this.dgvMod.TabIndex = 26;
            this.dgvMod.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvMod_UserDeletingRow);
            // 
            // dgvcModName
            // 
            this.dgvcModName.HeaderText = "MOD名称";
            this.dgvcModName.Name = "dgvcModName";
            this.dgvcModName.ReadOnly = true;
            this.dgvcModName.Width = 80;
            // 
            // dgvcModLevel
            // 
            this.dgvcModLevel.HeaderText = "MOD等级";
            this.dgvcModLevel.Name = "dgvcModLevel";
            this.dgvcModLevel.Width = 80;
            // 
            // ModInstance
            // 
            this.ModInstance.HeaderText = "MOD实体";
            this.ModInstance.Name = "ModInstance";
            this.ModInstance.ReadOnly = true;
            this.ModInstance.Visible = false;
            // 
            // cbbModList
            // 
            this.cbbModList.FormattingEnabled = true;
            this.cbbModList.Location = new System.Drawing.Point(33, 401);
            this.cbbModList.Name = "cbbModList";
            this.cbbModList.Size = new System.Drawing.Size(121, 23);
            this.cbbModList.TabIndex = 28;
            // 
            // btnAddMod
            // 
            this.btnAddMod.Location = new System.Drawing.Point(236, 400);
            this.btnAddMod.Name = "btnAddMod";
            this.btnAddMod.Size = new System.Drawing.Size(75, 26);
            this.btnAddMod.TabIndex = 27;
            this.btnAddMod.Text = "添加MOD";
            this.btnAddMod.UseVisualStyleBackColor = true;
            this.btnAddMod.Click += new System.EventHandler(this.btnAddMod_Click);
            // 
            // nudModLevel
            // 
            this.nudModLevel.Location = new System.Drawing.Point(160, 401);
            this.nudModLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudModLevel.Name = "nudModLevel";
            this.nudModLevel.Size = new System.Drawing.Size(70, 25);
            this.nudModLevel.TabIndex = 29;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 488);
            this.Controls.Add(this.nudModLevel);
            this.Controls.Add(this.cbbModList);
            this.Controls.Add(this.btnAddMod);
            this.Controls.Add(this.dgvMod);
            this.Controls.Add(this.lblWeapon);
            this.Controls.Add(this.cbbWeapon);
            this.Controls.Add(this.nudEnemyLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnemyType);
            this.Controls.Add(this.lblLabelShots);
            this.Controls.Add(this.lblLabelTime);
            this.Controls.Add(this.lblResultShots);
            this.Controls.Add(this.lblResultTime);
            this.Controls.Add(this.cbbEnemyType);
            this.Controls.Add(this.btnCalc);
            this.Name = "Main";
            this.Text = "伪·幻影装置";
            ((System.ComponentModel.ISupportInitialize)(this.nudEnemyLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ComboBox cbbEnemyType;
        private System.Windows.Forms.Label lblResultTime;
        private System.Windows.Forms.Label lblResultShots;
        private System.Windows.Forms.Label lblLabelShots;
        private System.Windows.Forms.Label lblLabelTime;
        private System.Windows.Forms.Label lblEnemyType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudEnemyLevel;
        private System.Windows.Forms.Label lblWeapon;
        private System.Windows.Forms.ComboBox cbbWeapon;
        private System.Windows.Forms.DataGridView dgvMod;
        private System.Windows.Forms.ComboBox cbbModList;
        private System.Windows.Forms.Button btnAddMod;
        private System.Windows.Forms.NumericUpDown nudModLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcModName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcModLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModInstance;
    }
}

