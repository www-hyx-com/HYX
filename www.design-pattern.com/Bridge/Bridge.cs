using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Bridge
    {
        public static void Main(string[] args)
        {
            ISwitch fancy = new Fancy();
            IElectricalEquipment light = new Light();
            fancy.ElectricalEquipment = light;
            fancy.On();
            fancy.Off();

            fancy.ElectricalEquipment = new MacBook();
            fancy.On();
            fancy.Off();
        }
    }
}
