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
