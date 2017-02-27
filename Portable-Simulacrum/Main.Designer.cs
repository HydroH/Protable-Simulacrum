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
            ((System.ComponentModel.ISupportInitialize)(this.nudEnemyLevel)).BeginInit();
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
            this.cbbEnemyType.Location = new System.Drawing.Point(358, 16);
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
            this.lblEnemyType.Location = new System.Drawing.Point(284, 19);
            this.lblEnemyType.Name = "lblEnemyType";
            this.lblEnemyType.Size = new System.Drawing.Size(67, 15);
            this.lblEnemyType.TabIndex = 21;
            this.lblEnemyType.Text = "敌人类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "敌人等级";
            // 
            // nudEnemyLevel
            // 
            this.nudEnemyLevel.Location = new System.Drawing.Point(358, 60);
            this.nudEnemyLevel.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudEnemyLevel.Name = "nudEnemyLevel";
            this.nudEnemyLevel.Size = new System.Drawing.Size(120, 25);
            this.nudEnemyLevel.TabIndex = 23;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 488);
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
    }
}

