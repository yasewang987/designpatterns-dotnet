using System;
namespace DesignPatterns.FactoryPattern
{
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Draw Circle - Factory");
        }
    }
}