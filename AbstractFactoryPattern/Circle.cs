using System;
namespace DesignPatterns.AbstractFactoryPattern
{
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
}