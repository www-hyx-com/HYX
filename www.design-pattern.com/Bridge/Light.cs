using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace www.design_pattern.com.structured_pattern
{
    /// <summary>
    /// 电灯泡
    /// </summary>
    public class Light : IElectricalEquipment
    {
        /// <summary>
        /// 关闭电灯泡电源
        /// </summary>
        public void PowerOff()
        {
            Console.WriteLine("关闭电灯泡电源.");
        }

        /// <summary>
        /// 打开电灯泡电源
        /// </summary>
        public void PowerOn()
        {
            Console.WriteLine("打开电灯泡电源.");
        }
    }
}