using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class Light : IElectricalEquipment
    {
        public void PowerOff()
        {
            Console.WriteLine("关闭灯电源.");
        }

        public void PowerOn()
        {
            Console.WriteLine("打开灯电源.");
        }
    }
}