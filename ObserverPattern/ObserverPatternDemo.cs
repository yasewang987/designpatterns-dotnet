using System;
namespace DesignPatterns.ObserverPattern
{
    public class ObserverPatternDemo
    {
        public static void Run()
        {
            Subject subject = new Subject();

            Observer binaryObserver = new BinaryObserver(subject);
            Observer octalObserver = new OctalObserver(subject);

            Console.WriteLine($"First state change 100");
            subject.setState(100);

            Console.WriteLine($"Second state change 222");
            subject.setState(222);
        }
    }
}