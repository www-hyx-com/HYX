using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.design_pattern.com.creational_pattern
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// 调用单线程单例模式
        /// </summary>
        /// <returns></returns>
        public SingleThreadSingleton InvokeSingleThreadSingleton()
        {
            return SingleThreadSingleton.Instance;
        }

        /// <summary>
        /// 调用多线程单例模式
        /// </summary>
        /// <returns></returns>
        public MultThreadSingleton InvokeMultThreadSingleton()
        {
            return MultThreadSingleton.Instance;
        }

        /// <summary>
        /// 调用静态单例模式
        /// </summary>
        /// <returns></returns>
        public StaticSingleton InvokeStaticSingleton()
        {
            return StaticSingleton.Instance;
        }
    }
}
