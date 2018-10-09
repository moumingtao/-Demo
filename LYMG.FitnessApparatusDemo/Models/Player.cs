using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYMG.FitnessApparatusDemo
{
    public class Player
    {
        private FitnessApparatus standUpApparatus;// 玩家当前站在哪一台健身仪器上
        public double Weight { get; set; }// 玩家体重

        // 扫码二维码
        public bool ScanQRCode(FitnessApparatus apparatus)
        {
            if (apparatus.StatusContext.DisplayStatus is DisplayQRCode qrCode)
            {
                return qrCode.Scavenging(apparatus.StatusContext);
            }
            return false;
        }

        // 站到健身仪器上
        public bool StandUp(FitnessApparatus apparatus)
        {
            if (standUpApparatus == apparatus) return false;
            apparatus.StatusContext.PressureStatus = new UnderPressure(this.Weight);
            standUpApparatus = apparatus;
            return true;
        }

        // 从健身仪器上下来
        public FitnessApparatus ComeDown()
        {
            var apparatus = standUpApparatus;
            if (apparatus == null) return null;
            apparatus.StatusContext.PressureStatus = new NoPressure();
            standUpApparatus = null;
            return apparatus;
        }
    }
}
