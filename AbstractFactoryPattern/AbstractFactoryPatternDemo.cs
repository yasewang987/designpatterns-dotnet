namespace DesignPatterns.AbstractFactoryPattern
{
    public class AbstractFactoryPatternDemo
    {
        public static void Run()
        {
            var shapeFactory = FactoryProducer.GetFactory(FactoryProducer.ShapeFactory);
            var square = shapeFactory.GetShape(ShapeFactory.Square);
            square.draw();
            var rectangle = shapeFactory.GetShape(ShapeFactory.Rectangle);
            rectangle.draw();
            var circle = shapeFactory.GetShape(ShapeFactory.CirCle);
            circle.draw();

            var colorFactory = FactoryProducer.GetFactory(FactoryProducer.ColorFactory);
            var red = colorFactory.GetColor(ColorFactory.Red);
            red.fill();
            var green = colorFactory.GetColor(ColorFactory.Green);
            green.fill();
            var blue = colorFactory.GetColor(ColorFactory.Blue);
            blue.fill();
        }
    }
}