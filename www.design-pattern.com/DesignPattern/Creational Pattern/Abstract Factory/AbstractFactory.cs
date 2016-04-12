using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.design_pattern.com.design_pattern.creational_pattern
{
    /// <summary>
    /// 抽象工厂模式
    /// </summary>
    public class AbstractFactory
    {
        public static void Invoke()
        {
            var abstractProductAFactory = new com.creational_pattern.ConcreteProductAFactory();
            var abstractFactoryA = new com.creational_pattern.AbstractFactory(abstractProductAFactory);
            Console.WriteLine("----------通过A抽象工厂调用实例化抽象产品A开始----------");
            Console.WriteLine(abstractFactoryA.InvokeInteractProductA());
            Console.WriteLine("----------通过A抽象工厂调用实例化抽象产品A结束----------");
            Console.WriteLine();
            Console.WriteLine("----------通过A抽象工厂调用实例化抽象产品B开始----------");
            Console.WriteLine(abstractFactoryA.InvokeInteractProductB());
            Console.WriteLine("----------通过A抽象工厂调用实例化抽象产品B结束----------");
            Console.WriteLine();

            var abstractProductBFactory = new com.creational_pattern.ConcreteProductBFactory();
            var abstractFactoryB = new com.creational_pattern.AbstractFactory(abstractProductBFactory);
            Console.WriteLine("----------通过B抽象工厂调用实例化抽象产品A开始----------");
            Console.WriteLine(abstractFactoryB.InvokeInteractProductA());
            Console.WriteLine("----------通过B抽象工厂调用实例化抽象产品A结束----------");
            Console.WriteLine();
            Console.WriteLine("----------通过B抽象工厂调用实例化抽象产品B开始----------");
            Console.WriteLine(abstractFactoryB.InvokeInteractProductB());
            Console.WriteLine("----------通过B抽象工厂调用实例化抽象产品B结束----------");
            Console.WriteLine();
        }
    }
}
