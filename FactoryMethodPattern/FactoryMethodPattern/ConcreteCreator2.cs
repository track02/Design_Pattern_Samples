using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class ConcreteCreator2 : ICreator
    {

        public override IProduct factoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
