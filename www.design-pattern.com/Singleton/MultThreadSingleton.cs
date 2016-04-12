using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.design_pattern.com.creational_pattern
{
    /// <summary>
    /// 多线程单例模式
    /// </summary>
    public class MultThreadSingleton
    {
        /// <summary>
        /// 私有静态辅助对象
        /// </summary>
        private static object obj = new object();
        /// <summary>
        /// 私有静态实例字段
        /// </summary>
        private static volatile MultThreadSingleton instance = null;

        /// <summary>
        /// 私有构造函数
        /// </summary>
        private MultThreadSingleton()
        {

        }

        /// <summary>
        /// 公有静态实例属性
        /// </summary>
        public static MultThreadSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            return new MultThreadSingleton();
                        }
                        else
                        {
                            return instance;
                        }
                    }
                }
                else
                {
                    return instance;
                }
            }
        }
    }
}
