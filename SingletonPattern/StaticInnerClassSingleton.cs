using System;
namespace DesignPatterns.SingletonPattern
{
    public class StaticInnerClassSingleton
    {
        private StaticInnerClassSingleton() {}
        private static class SingletonHolder
        {
            public static readonly StaticInnerClassSingleton INSTANCE = new StaticInnerClassSingleton();
        }

        public static StaticInnerClassSingleton getInstance()
        {
            return SingletonHolder.INSTANCE;
        }

        public void showMessage()
        {
            Console.WriteLine("show message StaticInnerClassSingleton");
        }
    }
}