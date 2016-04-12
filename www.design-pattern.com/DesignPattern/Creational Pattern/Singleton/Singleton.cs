using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.design_pattern.com.creational_pattern;

namespace www.design_pattern.com.design_pattern.creational_pattern
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// 调用单例模式
        /// </summary>
        /// <returns></returns>
        public static void Invoke()
        {
            Console.WriteLine("----------创建单线程单例模式开始----------");
            Console.WriteLine(SingleThreadSingleton.Instance.GetType().Name);
            Console.WriteLine("----------创建单线程单例模式结束----------");
            Console.WriteLine();
            Console.WriteLine("----------创建多线程单例模式开始----------");
            Console.WriteLine(MultThreadSingleton.Instance.GetType().Name);
            Console.WriteLine("----------创建多线程单例模式结束----------");
            Console.WriteLine();
            Console.WriteLine("----------创建静态单例模式开始----------");
            Console.WriteLine(StaticSingleton.Instance.GetType().Name);
            Console.WriteLine("----------创建静态单例模式结束----------");
            Console.WriteLine();
        }
    }
}
