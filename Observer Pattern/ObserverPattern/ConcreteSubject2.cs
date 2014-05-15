using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class ConcreteSubject2 : ISubject
    {

        private List<IObserve> observers = new List<IObserve>();

        public void registerObserver(IObserve obs)
        {
            observers.Add(obs);
        }

        public void unregisterObserver(IObserve obs)
        {
            observers.Remove(obs);
        }

        public void notifyObservers()
        {
            foreach (IObserve o in observers)
            {
                o.notify("Subject 2");
            }
        }



    }
}
