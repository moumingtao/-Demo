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
        public Form1()
        {
            InitializeComponent();
            FitnessApparatus = new FitnessApparatus();
            // 开始时没有人站在健身仪器上面
            FitnessApparatus.PressureStatus = new NoPressure();
            // 开始的时候播放广告
            FitnessApparatus.DisplayStatus = new DisplayAdvertisement(FitnessApparatus.PressureStatus);
        }

        private void chkStandUp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStandUp.Checked)
            {
                Random random = new Random();
                int pressure = random.Next(50, 80);
                FitnessApparatus.PressureStatus = new UnderPressure(pressure);
            }
            else
            {
                FitnessApparatus.PressureStatus = new NoPressure();
            }
        }

        private void btnScavenging_Click(object sender, EventArgs e)
        {
            if (FitnessApparatus.DisplayStatus is DisplayQRCode qrCode)
            {
                qrCode.Scavenging(FitnessApparatus);
            }
        }

        private void globalTimer_Tick(object sender, EventArgs e)
        {
            FitnessApparatus.DisplayStatus.UpdateStatus(FitnessApparatus);
            FitnessApparatus.PressureStatus.UpdateStatus(FitnessApparatus);

            lblDisplayState.Text = FitnessApparatus.DisplayStatus.Text;
            lblPressureState.Text = FitnessApparatus.PressureStatus.Text;
        }
    }

    #region 健身仪器状态上下文
    public class FitnessApparatus
    {
        public DisplayStatusBase DisplayStatus { get; set; }
        public PressureStatusBase PressureStatus { get; set; }
    }
    #endregion
}
