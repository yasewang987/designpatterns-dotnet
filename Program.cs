using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // 工厂模式
            Console.WriteLine($"Factory Pattern Start ------------");
            FactoryPattern.FactoryPatternDemo.Run();
            Console.WriteLine($"Factory Pattern End ------------\n");

            // 抽象工厂模式
            Console.WriteLine($"Abstract Factory Pattern Start ------------");
            AbstractFactoryPattern.AbstractFactoryPatternDemo.Run();
            Console.WriteLine($"Abstract Factory Pattern End ------------\n");

            // 单例模式
            Console.WriteLine($"Singleton Pattern Start ------------");
            SingletonPattern.SingletonPatternDemo.Run();
            Console.WriteLine($"Singleton Pattern End ------------\n");

            // 建造者模式
            Console.WriteLine($"Builder Pattern Start ------------");
            BuilderPattern.BuilderPatternDemo.Run();
            Console.WriteLine($"Builder Pattern End ------------\n");

            // 观察者模式
            Console.WriteLine($"Observer Pattern Start ------------");
            ObserverPattern.ObserverPatternDemo.Run();
            Console.WriteLine($"Observer Pattern End ------------\n");

            // 门面(外观)模式
            Console.WriteLine($"Facade Pattern Start ------------");
            FacadePattern.FacadePatternDemo.Run();
            Console.WriteLine($"Facade Pattern End ------------\n");
        }
    }
}
