namespace DesignPatterns.AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract Shape GetShape(int shapeType);
        public abstract Color GetColor(int colorType);
    }
}