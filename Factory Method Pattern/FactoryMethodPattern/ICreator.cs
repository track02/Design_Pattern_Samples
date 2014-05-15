using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    abstract class ICreator
    {

        public abstract IProduct factoryMethod();


    }
}
