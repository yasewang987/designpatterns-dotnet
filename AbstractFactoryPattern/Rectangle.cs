using System;
namespace DesignPatterns.AbstractFactoryPattern
{
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine($"Draw Rectangle");
        }
    }
}