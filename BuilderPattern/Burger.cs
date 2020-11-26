namespace DesignPatterns.BuilderPattern
{
    public abstract class Burger : Item
    {
        public Packing packing()
        {
            return new Wapper();
        }

        public abstract string name();
        public abstract float price();
    }
}