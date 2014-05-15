using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class ConcreteObserver1 : IObserve
    {

        public void notify(Object args)
        {
            Console.WriteLine("Concrete Observer 1 Notified!");

            if(args.GetType() == typeof(String))
            {
                Console.WriteLine("Received String: " + (String)args);
            }

        }


    }
}
