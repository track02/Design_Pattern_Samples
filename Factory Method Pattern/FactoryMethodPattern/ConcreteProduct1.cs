using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class ConcreteProduct1 : IProduct
    {

        public string getName()
        {
            return "Concrete Product 1";
        }

    }
}
