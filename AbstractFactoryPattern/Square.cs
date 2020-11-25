using System;
namespace DesignPatterns.AbstractFactoryPattern
{
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine($"Draw Square");
        }
    }
}