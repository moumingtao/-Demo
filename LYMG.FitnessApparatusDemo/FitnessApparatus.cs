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
            context.DisplayStatus = new DisplayAdvertisement(context.PressureStatus);
            this.StatusContext = context;
        }
        public string DisplayText => StatusContext.DisplayStatus.Text;
        public string PressureText => StatusContext.PressureStatus.Text;

        internal void UpdateStatus() => StatusContext.UpdateStatus(1000);
    }
}
