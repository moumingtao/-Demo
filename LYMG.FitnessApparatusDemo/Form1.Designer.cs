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
            this.chkStandUp = new System.Windows.Forms.CheckBox();
            this.btnScavenging = new System.Windows.Forms.Button();
            this.globalTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblPropup = new System.Windows.Forms.Label();
            this.btnEndTest = new System.Windows.Forms.Button();
            this.btnShowDialogBox = new System.Windows.Forms.Button();
            this.btnCloseDialogBox = new System.Windows.Forms.Button();
            this.btnExitDialogBox = new System.Windows.Forms.Button();
            this.btnOnError = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.lblDisplayState);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 130);
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
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblPressureState);
            this.groupBox2.Location = new System.Drawing.Point(13, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 58);
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
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.chkStandUp);
            this.groupBox3.Controls.Add(this.btnScavenging);
            this.groupBox3.Location = new System.Drawing.Point(13, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "模拟用户动作";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPropup);
            this.groupBox4.Location = new System.Drawing.Point(51, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 58);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "屏幕弹窗";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnOnError);
            this.groupBox5.Controls.Add(this.btnExitDialogBox);
            this.groupBox5.Controls.Add(this.btnCloseDialogBox);
            this.groupBox5.Controls.Add(this.btnShowDialogBox);
            this.groupBox5.Controls.Add(this.btnEndTest);
            this.groupBox5.Location = new System.Drawing.Point(13, 276);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(433, 88);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "模拟健身仪器动作";
            // 
            // lblPropup
            // 
            this.lblPropup.AutoSize = true;
            this.lblPropup.Location = new System.Drawing.Point(30, 31);
            this.lblPropup.Name = "lblPropup";
            this.lblPropup.Size = new System.Drawing.Size(29, 12);
            this.lblPropup.TabIndex = 0;
            this.lblPropup.Text = "状态";
            // 
            // btnEndTest
            // 
            this.btnEndTest.Location = new System.Drawing.Point(7, 37);
            this.btnEndTest.Name = "btnEndTest";
            this.btnEndTest.Size = new System.Drawing.Size(75, 23);
            this.btnEndTest.TabIndex = 0;
            this.btnEndTest.Text = "测试结束";
            this.btnEndTest.UseVisualStyleBackColor = true;
            this.btnEndTest.Click += new System.EventHandler(this.btnEndTest_Click);
            // 
            // btnShowDialogBox
            // 
            this.btnShowDialogBox.Location = new System.Drawing.Point(89, 37);
            this.btnShowDialogBox.Name = "btnShowDialogBox";
            this.btnShowDialogBox.Size = new System.Drawing.Size(75, 23);
            this.btnShowDialogBox.TabIndex = 1;
            this.btnShowDialogBox.Text = "出现对话框";
            this.btnShowDialogBox.UseVisualStyleBackColor = true;
            this.btnShowDialogBox.Click += new System.EventHandler(this.btnShowDialogBox_Click);
            // 
            // btnCloseDialogBox
            // 
            this.btnCloseDialogBox.Location = new System.Drawing.Point(171, 37);
            this.btnCloseDialogBox.Name = "btnCloseDialogBox";
            this.btnCloseDialogBox.Size = new System.Drawing.Size(75, 23);
            this.btnCloseDialogBox.TabIndex = 2;
            this.btnCloseDialogBox.Text = "结束对话框";
            this.btnCloseDialogBox.UseVisualStyleBackColor = true;
            this.btnCloseDialogBox.Click += new System.EventHandler(this.btnCloseDialogBox_Click);
            // 
            // btnExitDialogBox
            // 
            this.btnExitDialogBox.Location = new System.Drawing.Point(253, 37);
            this.btnExitDialogBox.Name = "btnExitDialogBox";
            this.btnExitDialogBox.Size = new System.Drawing.Size(75, 23);
            this.btnExitDialogBox.TabIndex = 3;
            this.btnExitDialogBox.Text = "选择退出";
            this.btnExitDialogBox.UseVisualStyleBackColor = true;
            this.btnExitDialogBox.Click += new System.EventHandler(this.btnExitDialogBox_Click);
            // 
            // btnOnError
            // 
            this.btnOnError.Location = new System.Drawing.Point(335, 37);
            this.btnOnError.Name = "btnOnError";
            this.btnOnError.Size = new System.Drawing.Size(75, 23);
            this.btnOnError.TabIndex = 4;
            this.btnOnError.Text = "引发错误";
            this.btnOnError.UseVisualStyleBackColor = true;
            this.btnOnError.Click += new System.EventHandler(this.btnOnError_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 376);
            this.Controls.Add(this.groupBox5);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblPropup;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnExitDialogBox;
        private System.Windows.Forms.Button btnCloseDialogBox;
        private System.Windows.Forms.Button btnShowDialogBox;
        private System.Windows.Forms.Button btnEndTest;
        private System.Windows.Forms.Button btnOnError;
    }
}

