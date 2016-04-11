using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.design_pattern.com.structured_pattern
{
    /// <summary>
    /// 桥接模式
    /// </summary>
    public class Bridge
    {
        /// <summary>
        /// 调用桥接模式
        /// </summary>
        public static void Main()
        {
            ISwitch fancy = new Fancy();
            IElectricalEquipment light = new Light();
            fancy.ElectricalEquipment = light;
            fancy.On();
            Console.WriteLine("----------通过花式开关打开电灯泡----------");
            fancy.Off();
            Console.WriteLine("----------通过花式开关关闭电灯泡----------");

            var normal = new Normal();
            normal.ElectricalEquipment = new MacBook();
            normal.On();
            Console.WriteLine("----------通过普通开关打开笔记本电脑----------");
            normal.Off();
            Console.WriteLine("----------通过普通开关关闭笔记本电脑----------");
        }
    }
}
