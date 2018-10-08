namespace LYMG.FitnessApparatusDemo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDisplayState = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPressureState = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnScavenging = new System.Windows.Forms.Button();
            this.globalTimer = new System.Windows.Forms.Timer(this.components);
            this.chkStandUp = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDisplayState);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输出健身仪器屏幕状态";
            // 
            // lblDisplayState
            // 
            this.lblDisplayState.AutoSize = true;
            this.lblDisplayState.Location = new System.Drawing.Point(49, 30);
            this.lblDisplayState.Name = "lblDisplayState";
            this.lblDisplayState.Size = new System.Drawing.Size(29, 12);
            this.lblDisplayState.TabIndex = 0;
            this.lblDisplayState.Text = "状态";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPressureState);
            this.groupBox2.Location = new System.Drawing.Point(13, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出健身仪器压力状态";
            // 
            // lblPressureState
            // 
            this.lblPressureState.AutoSize = true;
            this.lblPressureState.Location = new System.Drawing.Point(49, 29);
            this.lblPressureState.Name = "lblPressureState";
            this.lblPressureState.Size = new System.Drawing.Size(29, 12);
            this.lblPressureState.TabIndex = 0;
            this.lblPressureState.Text = "状态";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkStandUp);
            this.groupBox3.Controls.Add(this.btnScavenging);
            this.groupBox3.Location = new System.Drawing.Point(13, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输入用户动作";
            // 
            // btnScavenging
            // 
            this.btnScavenging.Location = new System.Drawing.Point(165, 21);
            this.btnScavenging.Name = "btnScavenging";
            this.btnScavenging.Size = new System.Drawing.Size(75, 23);
            this.btnScavenging.TabIndex = 1;
            this.btnScavenging.Text = "扫描二维码";
            this.btnScavenging.UseVisualStyleBackColor = true;
            this.btnScavenging.Click += new System.EventHandler(this.btnScavenging_Click);
            // 
            // globalTimer
            // 
            this.globalTimer.Enabled = true;
            this.globalTimer.Tick += new System.EventHandler(this.globalTimer_Tick);
            // 
            // chkStandUp
            // 
            this.chkStandUp.AutoSize = true;
            this.chkStandUp.Location = new System.Drawing.Point(33, 25);
            this.chkStandUp.Name = "chkStandUp";
            this.chkStandUp.Size = new System.Drawing.Size(108, 16);
            this.chkStandUp.TabIndex = 2;
            this.chkStandUp.Text = "站到健身仪器上";
            this.chkStandUp.UseVisualStyleBackColor = true;
            this.chkStandUp.CheckedChanged += new System.EventHandler(this.chkStandUp_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 254);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnScavenging;
        private System.Windows.Forms.Label lblDisplayState;
        private System.Windows.Forms.Label lblPressureState;
        private System.Windows.Forms.Timer globalTimer;
        private System.Windows.Forms.CheckBox chkStandUp;
    }
}

