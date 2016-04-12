using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.design_pattern.com.creational_pattern
{
    /// <summary>
    /// 抽象产品A
    /// </summary>
    public abstract class AbstractProductA
    {
        /// <summary>
        /// 相互作用的抽象产品B
        /// </summary>
        /// <param name="b">抽象产品B的实现类对象</param>
        /// <returns>返回结果</returns>
        public abstract string Interact(AbstractProductB b);
    }
}
