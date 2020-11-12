namespace DesignPatterns.FacadePattern
{
    public class FacadePatternDemo
    {
        public static void Run()
        {
            ShapeMaker sm = new ShapeMaker();

            sm.DrawCircle();
            sm.DrawRectangle();
            sm.DrawSquare();
        }
    }
}