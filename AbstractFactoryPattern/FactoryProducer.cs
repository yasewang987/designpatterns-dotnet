namespace DesignPatterns.AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public const int ShapeFactory = 0;
        public const int ColorFactory = 1;
        public static AbstractFactory GetFactory(int factoryType)
        {
            switch (factoryType)
            {
                case ShapeFactory:
                    return new ShapeFactory();
                case ColorFactory:
                    return new ColorFactory();
            }

            return null;
        }
    }
}