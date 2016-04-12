using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.design_pattern.com.creational_pattern
{
    /// <summary>
    /// 抽象产品B
    /// </summary>
    public abstract class AbstractProductB
    {
        /// <summary>
        /// 相互作用的抽象产品A
        /// </summary>
        /// <param name="a">抽象产品A的实现类对象</param>
        /// <returns>返回结果</returns>
        public abstract string Interact(AbstractProductA a);
    }
}
