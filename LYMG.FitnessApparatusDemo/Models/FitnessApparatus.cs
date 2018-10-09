using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYMG.FitnessApparatusDemo
{
    public class FitnessApparatus
    {
        public readonly ApparatusStatusContext StatusContext;
        public FitnessApparatus()
        {
            var context = new ApparatusStatusContext();
            context.PressureStatus = new NoPressure();
            context.DisplayStatus = new DisplayAdvertisement();
            context.PropupNoPeopleTime = TimeSpan.FromSeconds(5);
            this.StatusContext = context;
        }

        #region 状态
        public string DisplayText => StatusContext.DisplayStatus.Text;
        public string PressureText => StatusContext.PressureStatus.Text;
        public string PropupText
        {
            get
            {
                if (StatusContext.DisplayStatus is DisplayTest display && display.PropupStatus != null)
                {
                    return display.PropupStatus.Text;
                }
                return string.Empty;
            }
        }
        internal void UpdateStatus() => StatusContext.UpdateStatus(1000);
        #endregion

        #region 动作
        public bool EndTest()
        {
            if (this.StatusContext.DisplayStatus is DisplayTest display)
            {
                return display.EndTest(this.StatusContext);
            }
            return false;
        }
        public bool ShowDialogBox()
        {
            if (this.StatusContext.DisplayStatus is DisplayTest display)
            {
                return display.ShowDialogBox();
            }
            return false;
        }
        public bool CloseDialogBox()
        {
            if (this.StatusContext.DisplayStatus is DisplayTest display)
            {
                if (display.PropupStatus is PropupDialogBox dialogBox)
                {
                    return dialogBox.CloseDialogBox(display);
                }
                return false;
            }
            return false;
        }
        public bool ExitDialogBox()
        {
            if (this.StatusContext.DisplayStatus is DisplayTest display)
            {
                if (display.PropupStatus is PropupDialogBox dialogBox)
                {
                    return dialogBox.Exit(this.StatusContext);
                }
                return false;
            }
            return false;
        }
        public bool OnError()
        {
            if (this.StatusContext.DisplayStatus is DisplayTest display)
            {
                return display.OnError();
            }
            return false;
        }
        #endregion
    }
}
