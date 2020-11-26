namespace DesignPatterns.BuilderPattern
{
  public class Pepsi : ColdDrink
  {
    public override string name()
    {
      return "Pepsi";
    }

    public override float price()
    {
        return 5;
    }
  }
}