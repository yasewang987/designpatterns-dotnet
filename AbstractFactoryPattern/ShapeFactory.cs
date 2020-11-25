namespace DesignPatterns.AbstractFactoryPattern
{
    public class ShapeFactory : AbstractFactory
    {
        public const int CirCle = 1;
        public const int Rectangle = 2;
        public const int Square = 3;

        public override Shape GetShape(int shapeType)
        {
            switch (shapeType)
            {
                case CirCle:
                    return new Circle();
                case Rectangle:
                    return new Rectangle();
                case Square:
                    return new Square();
                default:
                    return new Circle();
            }
        }

        public override Color GetColor(int colorType)
        {
            return null;
        }
    }
}