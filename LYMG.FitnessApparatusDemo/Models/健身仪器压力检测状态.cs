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
    }
    public sealed class UnderPressure : PressureStatusBase
    {
        public UnderPressure(double pressureValue)
        {
            Text = $"有 {pressureValue}Kg 的压力";
        }
    }
    public sealed class NoPressure : PressureStatusBase
    {
        public NoPressure()
        {
            Text = "没有压力";
        }
    }
}
