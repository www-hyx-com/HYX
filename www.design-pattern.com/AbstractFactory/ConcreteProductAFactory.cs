using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.design_pattern.com.creational_pattern
{
    /// <summary>
    /// 具体产品A工厂
    /// </summary>
    public class ConcreteProductAFactory : AbstractProductFactory
    {
        /// <summary>
        /// 创建抽象产品A
        /// </summary>
        /// <returns>抽象产品A的实现类对象</returns>
        public override AbstractProductA CreateProductA()
        {
            return new ProductA();
        }

        /// <summary>
        /// 创建抽象产品B
        /// </summary>
        /// <returns>抽象产品B的实现类对象</returns>
        public override AbstractProductB CreateProductB()
        {
            return new ProductB();
        }
    }
}
