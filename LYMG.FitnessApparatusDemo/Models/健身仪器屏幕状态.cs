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
        public virtual void UpdateStatus(ApparatusStatusContext context) { }
        public virtual void OnPressureStatusChanging(ApparatusStatusContext context, PressureStatusBase oldStatus, PressureStatusBase newStatus) { }
    }
    public sealed class DisplayAdvertisement : DisplayStatusBase
    {
        public DisplayAdvertisement()
        {
            this.Text = "播放广告";
        }
        public override void OnPressureStatusChanging(ApparatusStatusContext context, PressureStatusBase oldStatus, PressureStatusBase newStatus)
        {
            if (newStatus is UnderPressure)
            {
                // 2、无人到有人，切换到扫码状态
                context.DisplayStatus = new DisplayQRCode();
            }
        }
    }
    public sealed class DisplayQRCode : DisplayStatusBase
    {
        public DisplayQRCode()
        {
            this.Text = "扫描二维码";
        }

        public bool Scavenging(ApparatusStatusContext context)
        {
            ///3、扫码成功，进入测试状态
            context.DisplayStatus = new DisplayTest();
            return true;
        }
        public override void OnPressureStatusChanging(ApparatusStatusContext context, PressureStatusBase oldStatus, PressureStatusBase newStatus)
        {
            if (newStatus is NoPressure)
            {
                // 1、从有人到无人，切换到广告状态
                context.DisplayStatus = new DisplayAdvertisement();
            }
        }
    }
    public sealed class DisplayTest : DisplayStatusBase
    {
        public PropupStatusBase PropupStatus { get; set; }

        public DisplayTest()
        {
            this.Text = "测试";
        }
        public override void OnPressureStatusChanging(ApparatusStatusContext context, PressureStatusBase oldStatus, PressureStatusBase newStatus)
        {
            if (PropupStatus == null && newStatus is NoPressure)
            {
                // 4、有人到无人，进入无人弹窗状态
                PropupStatus = new PropupNoPeople();
            }
            PropupStatus?.OnPressureStatusChanging(context, oldStatus, newStatus);
        }
        public bool EndTest(ApparatusStatusContext context)
        {
            if (PropupStatus != null) return false;
            // 6、测试结束
            context.DisplayStatus = new DisplayQRCode();
            return true;
        }
        public bool ShowDialogBox()
        {
            if (PropupStatus != null) return false;
            // 7、出现对话框
            this.PropupStatus = new PropupDialogBox();
            return true;
        }
        public bool OnError()
        {
            if (PropupStatus != null) return false;
            // 11、发生错误，打开系统错误消息框
            this.PropupStatus = new PropupSystemError();
            return true;
        }
        public override void UpdateStatus(ApparatusStatusContext context)
        {
            PropupStatus?.UpdateStatus(context);
        }
    }
}
