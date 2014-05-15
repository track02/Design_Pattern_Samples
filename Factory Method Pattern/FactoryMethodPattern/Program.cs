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

            ICreator[] factories = new ICreator[2];

            factories[0] = new ConcreteCreator1();
            factories[1] = new ConcreteCreator2();

            foreach(ICreator f in factories)
            {
                IProduct newprod = f.factoryMethod();
                Console.WriteLine(newprod.getName());
            }

            Console.ReadLine();

        }
    }
}
