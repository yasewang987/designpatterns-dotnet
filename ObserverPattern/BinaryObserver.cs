using System;
namespace DesignPatterns.ObserverPattern
{
  public class BinaryObserver : Observer
  {
    public BinaryObserver(Subject subject)
    {
        this.subject = subject;
        this.subject.attach(this);
    }

    public override void update()
    {
      Console.WriteLine($"BinaryObserver Get Notify : {this.subject.getState()}");
    }
  }
}