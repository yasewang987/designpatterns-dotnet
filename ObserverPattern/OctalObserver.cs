using System;
namespace DesignPatterns.ObserverPattern
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }

        public override void update()
        {
            Console.WriteLine($"OctalObserver Get Notify : {this.subject.getState()}");
        }
    }
}