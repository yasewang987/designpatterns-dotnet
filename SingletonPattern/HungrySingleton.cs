using System;
namespace DesignPatterns.SingletonPattern
{
    public class HungrySingleton
    {
        private static HungrySingleton instance = new HungrySingleton();
        private HungrySingleton() {}
        public static HungrySingleton getInstance()
        {
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine("show message HungrySingleton");
        }
    }
}