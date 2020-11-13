using System;
namespace DesignPatterns.FactoryPattern
{
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine($"Draw Square - Factory");
        }
    }
}