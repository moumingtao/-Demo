using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYMG.FitnessApparatusDemo
{
    public abstract class PropupStatusBase
    {
        public string Text { get; protected set; }
        public virtual void UpdateStatus(ApparatusStatusContext context) { }
        public virtual void OnPressureStatusChanging(ApparatusStatusContext context, PressureStatusBase oldStatus, PressureStatusBase newStatus) { }
    }
    public sealed class PropupNoPeople: PropupStatusBase
    {
        private readonly DateTime BeginTime;

        public PropupNoPeople()
        {
            Text = "无人弹窗";
            this.BeginTime = DateTime.Now;
        }
        public override void OnPressureStatusChanging(ApparatusStatusContext context, PressureStatusBase oldStatus, PressureStatusBase newStatus)
        {
            if (newStatus is UnderPressure)
            {
                // 5、无人到有人，关闭弹窗
                ((DisplayTest)context.DisplayStatus).PropupStatus = null;
            }
        }
        public override void UpdateStatus(ApparatusStatusContext context)
        {
            TimeSpan time = (context.PropupNoPeopleTime - (DateTime.Now - BeginTime));
            if (time.Ticks < 0)
            {
                // 10、时间到
                context.DisplayStatus = new DisplayAdvertisement();
            }
            else
            {
                this.Text = $"无人弹窗将在{time}后关闭";
            }
        }
    }
    public sealed class PropupSystemError: PropupStatusBase
    {
        public PropupSystemError()
        {
            Text = "系统错误消息框";
        }
    }
    public sealed class PropupDialogBox: PropupStatusBase
    {
        public PropupDialogBox()
        {
            Text = "对话框";
        }
        public bool CloseDialogBox(DisplayTest context)
        {
            // 8、对话框结束
            context.PropupStatus = null;
            return true;
        }
        public override void OnPressureStatusChanging(ApparatusStatusContext context, PressureStatusBase oldStatus, PressureStatusBase newStatus)
        {
            if (newStatus is NoPressure)
            {
                // 9、有人到无人，无人弹窗
                ((DisplayTest)context.DisplayStatus).PropupStatus = new PropupNoPeople();
            }
        }
        public bool Exit(ApparatusStatusContext context)
        {
            // 12、选择退出
            context.DisplayStatus = new DisplayQRCode();
            return true;
        }
    }
}
