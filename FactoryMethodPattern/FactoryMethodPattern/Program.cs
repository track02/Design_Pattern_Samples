using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            IFactory[] factories = new IFactory[2];

            factories[0] = new ConcreteFactory1();
            factories[1] = new ConcreteFactory2();

            foreach(IFactory f in factories)
            {
                IProduct newprod = f.factoryMethod();
                Console.WriteLine(newprod.getName());
            }

            Console.ReadLine();

        }
    }
}
