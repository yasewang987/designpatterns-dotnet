using System;
namespace DesignPatterns.SingletonPattern
{
    public class LazySingleton
    {
        private static LazySingleton instance;
        private static object lockObj = new object();
        private LazySingleton() {}
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static LazySingleton getInstance()
        {
            lock(lockObj)
            {
                if(instance == null)
                {
                    instance = new LazySingleton();
                }
                return instance;
            }
        }

        /// <summary>
        /// 双重校验,性能较高
        /// </summary>
        /// <returns></returns>
        public static LazySingleton getInstanceDoubleCheck()
        {
            if(instance == null)
            {
                lock(lockObj)
                {
                    if(instance == null)
                    {
                        instance = new LazySingleton();
                    }
                }
            }
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine("show message LazySingleton");
        }
    }
}