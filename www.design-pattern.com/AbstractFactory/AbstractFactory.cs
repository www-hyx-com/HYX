using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.design_pattern.com.creational_pattern
{
    /// <summary>
    /// 抽象工厂模式
    /// </summary>
    public class AbstractFactory
    {
        /// <summary>
        /// 抽象产品A对象
        /// </summary>
        private AbstractProductA abstractProductA;
        /// <summary>
        /// 抽象产品B对象
        /// </summary>
        private AbstractProductB abstractProductB;

        /// <summary>
        /// 带参数构造函数
        /// </summary>
        /// <param name="abstractProductFactory">抽象产品工厂对象</param>
        public AbstractFactory(AbstractProductFactory abstractProductFactory)
        {
            abstractProductA = abstractProductFactory.CreateProductA();
            abstractProductB = abstractProductFactory.CreateProductB();
        }

        /// <summary>
        /// 调用实例化产品A方法
        /// </summary>
        /// <returns>实例化产品A结果</returns>
        public string InvokeInteractProductA()
        {
            return abstractProductA.Interact(abstractProductB);
        }

        /// <summary>
        /// 调用实例化产品B方法
        /// </summary>
        /// <returns>实例化产品B结果</returns>
        public string InvokeInteractProductB()
        {
            return abstractProductB.Interact(abstractProductA);
        }
    }
}
