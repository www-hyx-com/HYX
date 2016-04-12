using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.design_pattern.com.creational_pattern
{
    /// <summary>
    /// 静态单例模式
    /// </summary>
    public class StaticSingleton
    {
        /// <summary>
        /// 公有静态只读实例属性
        /// </summary>
        public static readonly StaticSingleton Instance;

        /// <summary>
        /// 静态构造函数
        /// </summary>
        static StaticSingleton()
        {
            Instance = new StaticSingleton();
        }

        /// <summary>
        /// 私有构造函数
        /// </summary>
        private StaticSingleton()
        {

        }
    }
}
