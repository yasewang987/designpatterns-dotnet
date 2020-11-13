namespace DesignPatterns.FactoryPattern
{
    public class FactoryPatternDemo
    {
        public static void Run()
        {
            ShapeFactory sf = new ShapeFactory();

            var circle = sf.GetShape(ShapeFactory.CirCle);
            circle.draw();
            
            var rectangle = sf.GetShape(ShapeFactory.Rectangle);
            rectangle.draw();

            var square = sf.GetShape(ShapeFactory.Square);
            square.draw();
        }
    }
}