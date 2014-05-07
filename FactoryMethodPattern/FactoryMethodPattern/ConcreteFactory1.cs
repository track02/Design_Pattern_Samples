using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class ConcreteFactory1 : IFactory
    {

        public override IProduct factoryMethod()
        {
            return new ConcreteProduct1();
        }

    }
}
