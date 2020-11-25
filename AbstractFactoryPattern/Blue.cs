using System;
namespace DesignPatterns.AbstractFactoryPattern
{
    public class Blue : Color
    {
        public void fill()
        {
            Console.WriteLine("fill Blue");
        }
    }
}