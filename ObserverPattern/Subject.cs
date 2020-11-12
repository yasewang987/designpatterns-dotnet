using System.Collections.Generic;
namespace DesignPatterns.ObserverPattern
{
    public class Subject
    {
        private List<Observer> observers;
        private int state;

        public Subject()
        {
            observers = new List<Observer>();
            state = 0;
        }

        public void setState(int state)
        {
            this.state = state;
            this.notifyObservers();
        }

        public int getState()
        {
            return this.state;
        }

        public void attach(Observer observer)
        {
            this.observers.Add(observer);
        }

        public void notifyObservers()
        {
            foreach (var observer in this.observers)
            {
                observer.update();                
            }
        }
    }
}