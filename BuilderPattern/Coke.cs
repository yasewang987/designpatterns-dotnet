namespace DesignPatterns.BuilderPattern
{
  public class Coke : ColdDrink
  {
    public override string name()
    {
        return "Coke";
    }

    public override float price()
    {
        return 4;
    }
  }
}