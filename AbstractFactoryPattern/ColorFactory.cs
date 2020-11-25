namespace DesignPatterns.AbstractFactoryPattern
{
    public class ColorFactory : AbstractFactory
    {
        public const int Red = 0;
        public const int Green = 1;
        public const int Blue = 2;

        public override Color GetColor(int colorType)
        {
            switch (colorType)
            {
                case Red:
                    return new Red();
                case Green:
                    return new Green();
                case Blue:
                    return new Blue();
            }

            return null;
        }
        public override Shape GetShape(int shapeType)
        {
            return null;
        }
    }
}