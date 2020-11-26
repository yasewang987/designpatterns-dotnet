using System;
using System.Collections.Generic;
using System.Linq;
namespace DesignPatterns.BuilderPattern
{
    public class Meal
    {
        private List<Item> items = new List<Item>();

        public void addItem(Item item)
        {
            items.Add(item);
        }

        public float getCost()
        {
            return items.Sum(i => i.price());
        }

        public void showItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"Item: {item.name()}, Packing:{item.packing()}, Price: {item.price()}");
            }
        }
    }
}