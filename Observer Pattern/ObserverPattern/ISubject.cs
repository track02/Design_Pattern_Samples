using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    interface ISubject
    {


        void registerObserver(IObserve obs);
        void unregisterObserver(IObserve obs);

         void notifyObservers();




    }
}
