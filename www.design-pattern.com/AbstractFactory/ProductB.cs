using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.design_pattern.com.creational_pattern
{
    /// <summary>
    /// 产品B
    /// </summary>
    public class ProductB : AbstractProductB
    {
        /// <summary>
        /// 实现抽象产品B的相互作用方法
        /// </summary>
        /// <param name="a">抽象产品A的实现类对象</param>
        /// <returns>返回结果</returns>
        public override string Interact(AbstractProductA a)
        {
            return this.GetType().Name + "作用于" + a.GetType().Name;
        }
    }
}
