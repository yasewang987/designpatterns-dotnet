using System;
namespace DesignPatterns.FacadePattern
{
    public class Rectangle : Shape
    {
        public void draw() {
            Console.WriteLine("Draw Rectangle");
        }
    }
}