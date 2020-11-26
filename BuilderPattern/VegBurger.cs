namespace DesignPatterns.BuilderPattern
{
    public class VegBurger : Burger
    {
        public override string name()
        {
            return "Veg Burger";
        }
        public override float price()
        {
            return 20;
        }
    }
}