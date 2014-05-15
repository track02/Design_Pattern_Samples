using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    class Singleton_Eager_Instantiation
    {

        //Eager instantiation of singleton
        private static Singleton_Eager_Instantiation uniqueInstance = new Singleton_Eager_Instantiation();

        //Private constructor
        private Singleton_Eager_Instantiation() { }

        public static Singleton_Eager_Instantiation getInstance()
        {
            return uniqueInstance;
        }
    }
}
