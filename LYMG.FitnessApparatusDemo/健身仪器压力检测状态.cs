using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYMG.FitnessApparatusDemo
{
    public abstract class PressureStatusBase
    {
        public string Text { get; set; }
        public abstract void UpdateStatus(FitnessApparatus context);
    }
    public sealed class UnderPressure : PressureStatusBase
    {
        private bool isFirstUpdateStatus;
        public UnderPressure(int pressureValue)
        {
            Text = $"有 {pressureValue}Kg 的压力";
            isFirstUpdateStatus = true;
        }

        // 有人站到健身设备上时屏幕切换到扫码二维码状态
        public override void UpdateStatus(FitnessApparatus context)
        {
            if (!isFirstUpdateStatus) return;
            context.DisplayStatus = new DisplayQRCode();
            isFirstUpdateStatus = false;
        }
    }
    public sealed class NoPressure : PressureStatusBase
    {
        private DisplayAdvertisement displayStatus;

        public NoPressure()
        {
            Text = "没有压力";
            this.displayStatus = new DisplayAdvertisement(this);
        }

        public override void UpdateStatus(FitnessApparatus context)
        {
            //  没有人站在健身仪器上时，播放广告
            context.DisplayStatus = this.displayStatus;
        }
    }
}
