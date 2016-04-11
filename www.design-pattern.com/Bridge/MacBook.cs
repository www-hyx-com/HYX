using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace www.design_pattern.com.structured_pattern
{
    /// <summary>
    /// 笔记本电脑
    /// </summary>
    public class MacBook : IElectricalEquipment
    {
        /// <summary>
        /// 关闭电源
        /// </summary>
        public void PowerOff()
        {
            Console.WriteLine("关闭笔记本电源.");
        }

        /// <summary>
        /// 打开电源
        /// </summary>
        public void PowerOn()
        {
            Console.WriteLine("打开笔记本电源.");
        }
    }
}