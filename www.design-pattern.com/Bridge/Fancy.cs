using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class Fancy : ISwitch
    {
        public IElectricalEquipment ElectricalEquipment
        {
            get
            {
                return ElectricalEquipment;
            }

            set
            {
                ElectricalEquipment = value;
            }
        }

        public void Off()
        {
            ElectricalEquipment.PowerOff();
        }

        public void On()
        {
            ElectricalEquipment.PowerOn();
        }
    }
}