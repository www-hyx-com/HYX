using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class MacBook : IElectricalEquipment
    {
        public void PowerOff()
        {
            Console.WriteLine("关闭笔记本电源.");
        }

        public void PowerOn()
        {
            Console.WriteLine("打开笔记本电源.");
        }
    }
}