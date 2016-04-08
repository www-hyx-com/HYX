using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.design_pattern.com
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bridge.ISwitch fancy = new Bridge.Fancy();
            fancy.ElectricalEquipment = new Bridge.Light();
            fancy.On();
            fancy.Off();

            fancy.ElectricalEquipment = new Bridge.MacBook();
            fancy.On();
            fancy.Off();
        }
    }
}
