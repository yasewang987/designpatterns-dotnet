using System;
namespace DesignPatterns.FactoryPattern
{
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine($"Draw Rectangle - Factory");
        }
    }
}