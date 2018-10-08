using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYMG.FitnessApparatusDemo
{
    public class ApparatusStatusContext
    {
        private bool IsUpdated;
        private DisplayStatusBase _DisplayStatus;
        private PressureStatusBase _PressureStatus;

        public DisplayStatusBase DisplayStatus
        {
            get => _DisplayStatus;
            set
            {
                if (value == _DisplayStatus) return;
                _DisplayStatus = value;
                IsUpdated = true;
            }
        }

        public PressureStatusBase PressureStatus
        {
            get => _PressureStatus;
            set
            {
                if (value == _PressureStatus) return;
                _PressureStatus = value;
                IsUpdated = true;
            }
        }

        public int UpdateStatus(int tryCount)
        {
            for (int i = 1; i <= tryCount; i++)
            {
                IsUpdated = false;
                DisplayStatus?.UpdateStatus(this);
                PressureStatus?.UpdateStatus(this);
                if (!IsUpdated) return i;
            }
            throw new TimeoutException($"状态更新{tryCount}次都无法达到稳定，请修改状态切换机制");
        }
    }
}
