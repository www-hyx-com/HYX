using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace www.design_pattern.com.structured_pattern
{
    /// <summary>
    /// 普通开关
    /// </summary>
    public class Normal : ISwitch
    {
        /// <summary>
        /// 电器对象
        /// </summary>
        public IElectricalEquipment ElectricalEquipment
        {
            get;
            set;
        }

        /// <summary>
        /// 关
        /// </summary>
        public void Off()
        {
            ElectricalEquipment.PowerOff();
        }

        /// <summary>
        /// 开
        /// </summary>
        public void On()
        {
            ElectricalEquipment.PowerOn();
        }
    }
}