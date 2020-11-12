namespace DesignPatterns.FacadePattern
{
    public class ShapeMaker
    {
        private Shape _circle;
        private Shape _rectangle;
        private Shape _square;

        public ShapeMaker()
        {
            _circle = new Circle();
            _rectangle = new Rectangle();
            _square = new Square();
        }

        public void DrawCircle()
        {
            _circle.draw();
        }

        public void DrawRectangle()
        {
            _rectangle.draw();
        }

        public void DrawSquare()
        {
            _square.draw();
        }
    }
}