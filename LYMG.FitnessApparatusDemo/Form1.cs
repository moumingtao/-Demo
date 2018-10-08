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
/*
 我的需求是这样的，我做一个健身仪器，没有用户站在上面是播放广告，用户站上去是扫码，
 测试过程中用户下来就会提示并倒数15秒，倒数结束就结束测试返回广告页面，
 还有些操作会要求弹窗并倒数一定秒数
*/
namespace LYMG.FitnessApparatusDemo
{
    public partial class Form1 : Form
    {
        private readonly FitnessApparatus FitnessApparatus;// 健身仪器对象
        private readonly Player Player;// 玩家对象，玩家的动作会修改健身仪器的状态

        public Form1()
        {
            InitializeComponent();
            FitnessApparatus = new FitnessApparatus();
            this.Player = new Player() { Weight = 52 };
        }

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

        private void globalTimer_Tick(object sender, EventArgs e)
        {
            FitnessApparatus.UpdateStatus();

            lblDisplayState.Text = FitnessApparatus.DisplayText;
            lblPressureState.Text = FitnessApparatus.PressureText;
        }
    }
}
