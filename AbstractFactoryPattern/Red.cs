using System;
namespace DesignPatterns.AbstractFactoryPattern
{
    public class Red : Color
    {
        public void fill()
        {
            Console.WriteLine("fill Red");
        }
    }
}