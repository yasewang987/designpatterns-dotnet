using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // 观察者模式
            Console.WriteLine($"Observer Pattern Start ------------");
            ObserverPattern.ObserverPatternDemo.Run();
            Console.WriteLine($"Observer Pattern End ------------\n");

            // 门面(外观)模式
        }
    }
}
