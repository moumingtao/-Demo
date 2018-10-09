using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LYMG.FitnessApparatusDemo
{
    public partial class Form1 : Form
    {
        private readonly FitnessApparatus FitnessApparatus;// 健身仪器对象
        private readonly Player Player;// 玩家对象

        public Form1()
        {
            InitializeComponent();
            FitnessApparatus = new FitnessApparatus();
            this.Player = new Player() { Weight = 52 };
        }

        private void globalTimer_Tick(object sender, EventArgs e)
        {
            FitnessApparatus.UpdateStatus();

            lblDisplayState.Text = FitnessApparatus.DisplayText;
            lblPropup.Text = FitnessApparatus.PropupText;
            lblPressureState.Text = FitnessApparatus.PressureText;
        }

        #region 模拟用户动作
        private void chkStandUp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStandUp.Checked)
            {
                bool success = Player.StandUp(FitnessApparatus);
                if (success) this.Text = "站到健身仪器上";
            }
            else
            {
                var apparatus = Player.ComeDown();
                if (apparatus != null) this.Text = "从健身仪器下来";
            }
        }

        private void btnScavenging_Click(object sender, EventArgs e)
        {
            bool success = Player.ScanQRCode(FitnessApparatus);
            this.Text = success ? "扫码成功" : "扫码失败";
        }
        #endregion

        #region 模拟健身仪器动作
        private void btnEndTest_Click(object sender, EventArgs e)
        {
            if (FitnessApparatus.EndTest())
                this.Text = "操作成功";
            else
                this.Text = "操作失败";
        }

        private void btnShowDialogBox_Click(object sender, EventArgs e)
        {
            if (FitnessApparatus.ShowDialogBox())
                this.Text = "操作成功";
            else
                this.Text = "操作失败";
        }

        private void btnCloseDialogBox_Click(object sender, EventArgs e)
        {
            if (FitnessApparatus.CloseDialogBox())
                this.Text = "操作成功";
            else
                this.Text = "操作失败";
        }

        private void btnExitDialogBox_Click(object sender, EventArgs e)
        {
            if (FitnessApparatus.ExitDialogBox())
                this.Text = "操作成功";
            else
                this.Text = "操作失败";
        }
        private void btnOnError_Click(object sender, EventArgs e)
        {
            if (FitnessApparatus.OnError())
                this.Text = "操作成功";
            else
                this.Text = "操作失败";
        }
        #endregion

    }
}
