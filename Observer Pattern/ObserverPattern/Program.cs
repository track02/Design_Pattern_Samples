using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            ISubject subject1 = new ConcreteSubject1();
            ISubject subject2 = new ConcreteSubject2();

            IObserve obs1 = new ConcreteObserver1();
            IObserve obs2 = new ConcreteObserver2();
            IObserve obs3 = new ConcreteObserver3();
            
            subject1.registerObserver(obs1);
            subject1.registerObserver(obs2);

            subject2.registerObserver(obs2);
            subject2.registerObserver(obs3);
            

            subject1.notifyObservers();
            subject2.notifyObservers();

            subject2.unregisterObserver(obs3);
            subject1.registerObserver(obs3);

            Console.WriteLine();
            Console.WriteLine();

            subject1.notifyObservers();
            subject2.notifyObservers();
            
            Console.ReadLine();


        }
    }
}
