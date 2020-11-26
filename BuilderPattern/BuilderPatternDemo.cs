using System;
namespace DesignPatterns.BuilderPattern
{
    public class BuilderPatternDemo
    {
        public static void Run()
        {
            MealBuilder mb = new MealBuilder();
            var vegMeal = mb.prepareVegMeal();
            vegMeal.showItems();
            Console.WriteLine($"Total: {vegMeal.getCost()}");

            var chickenMeal = mb.prepareChickenMeal();
            chickenMeal.showItems();
            Console.WriteLine($"Total: {chickenMeal.getCost()}");
        }
    }
}