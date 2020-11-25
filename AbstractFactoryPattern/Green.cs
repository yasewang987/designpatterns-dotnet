using System;
namespace DesignPatterns.AbstractFactoryPattern
{
    public class Green : Color
    {
        public void fill()
        {
            Console.WriteLine("fill Green");
        }
    }
}