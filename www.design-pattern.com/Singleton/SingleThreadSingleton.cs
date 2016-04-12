using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.design_pattern.com.creational_pattern
{
    /// <summary>
    /// 单线程单例模式
    /// </summary>
    public class SingleThreadSingleton
    {
        /// <summary>
        ///  私有静态实例字段
        /// </summary>
        private static SingleThreadSingleton instance = null;

        /// <summary>
        /// 私有构造函数
        /// </summary>
        private SingleThreadSingleton()
        {

        }

        /// <summary>
        /// 公有静态实例属性
        /// </summary>
        public static SingleThreadSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    return new SingleThreadSingleton();
                }
                else
                {
                    return instance;
                }
            }
        }
    }
}
