using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public interface ISwitch
    {
        /// <summary>
        /// 电器对象
        /// </summary>
        IElectricalEquipment ElectricalEquipment { get; set; }
        
        /// <summary>
        /// 开
        /// </summary>
        void On();
        /// <summary>
        /// 关
        /// </summary>
        void Off();
    }
}