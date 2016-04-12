using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.design_pattern.com.creational_pattern
{
    /// <summary>
    /// 产品A
    /// </summary>
    public class ProductA : AbstractProductA
    {
        /// <summary>
        /// 实现抽象产品A的相互作用方法
        /// </summary>
        /// <param name="b">抽象产品B的实现类对象</param>
        /// <returns>返回结果</returns>
        public override string Interact(AbstractProductB b)
        {
            return this.GetType().Name + "作用于" + b.GetType().Name;
        }
    }
}
