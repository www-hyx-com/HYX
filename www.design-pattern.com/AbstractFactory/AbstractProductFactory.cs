using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.design_pattern.com.creational_pattern
{
    /// <summary>
    /// 抽象产品工厂
    /// </summary>
    public abstract class AbstractProductFactory
    {
        /// <summary>
        /// 创建抽象产品A
        /// </summary>
        /// <returns>抽象产品A的实现类对象</returns>
        public abstract AbstractProductA CreateProductA();

        /// <summary>
        /// 创建抽象产品B
        /// </summary>
        /// <returns>抽象产品B的实现类对象</returns>
        public abstract AbstractProductB CreateProductB();
    }
}
