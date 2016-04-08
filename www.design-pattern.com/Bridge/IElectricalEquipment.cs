using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// 电器接口
    /// </summary>
    public interface IElectricalEquipment
    {
        /// <summary>
        /// 打开电源
        /// </summary>
        void PowerOn();
        /// <summary>
        /// 关闭电源
        /// </summary>
        void PowerOff();
    }
}
