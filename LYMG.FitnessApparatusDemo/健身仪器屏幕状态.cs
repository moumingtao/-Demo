using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYMG.FitnessApparatusDemo
{
    public abstract class DisplayStatusBase
    {
        public string Text { get; protected set; }
        public abstract void UpdateStatus(ApparatusStatusContext context);
    }
    public sealed class DisplayAdvertisement : DisplayStatusBase
    {
        private readonly PressureStatusBase BeginPressureStatus;// 开始播放广告时的压力状态
        public DisplayAdvertisement(PressureStatusBase beginStatus)
        {
            this.Text = "播放广告";
            this.BeginPressureStatus = beginStatus;
        }
        public override void UpdateStatus(ApparatusStatusContext context)
        {
            if (context.PressureStatus is UnderPressure)// 有人站在健身仪器上
            {
                if (context.PressureStatus == this.BeginPressureStatus)
                {// 播放广告开始到现在，一直都是同一个人站在上面就不切换状态
                }
                else
                {
                    context.DisplayStatus = new DisplayQRCode();
                }
            }
        }
    }
    public sealed class DisplayQRCode : DisplayStatusBase
    {
        private DateTime BeginTime;
        public int RemainingTime => Math.Max(5 - (int)(DateTime.Now - BeginTime).TotalSeconds, 0);// 倒计时

        public DisplayQRCode()
        {
            this.Text = "扫描二维码";
            this.BeginTime = DateTime.Now;
        }
        public override void UpdateStatus(ApparatusStatusContext context)
        {
            var remainingTime = RemainingTime;
            this.Text = $"请扫码二维码，剩余{remainingTime}秒";
            if (remainingTime == 0)// 扫码倒计时结束，切换到播放广告状态
                context.DisplayStatus = new DisplayAdvertisement(context.PressureStatus);
        }
        public bool Scavenging(ApparatusStatusContext context)
        {
            // 扫码成功，健身仪器进入正常运行状态
            context.DisplayStatus = new DisplayRuning();
            return true;
        }
    }
    public sealed class DisplayRuning : DisplayStatusBase
    {
        private DateTime BeginTime;
        public int RemainingTime => Math.Max(15 - (int)(DateTime.Now - BeginTime).TotalSeconds, 0);// 倒计时

        public DisplayRuning()
        {
            this.Text = "正常运行状态";
            this.BeginTime = DateTime.Now;
        }
        public override void UpdateStatus(ApparatusStatusContext context)
        {
            var remainingTime = RemainingTime;
            this.Text = $"处于正常运行状态，{remainingTime}秒后结束";
            if (remainingTime == 0)// 本次使用时间结束，需要重新扫码
                context.DisplayStatus = new DisplayQRCode();
        }
    }
}
