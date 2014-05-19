using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class ShortBow : IBow
    {

        public void releaseArrow()
        {
            Console.WriteLine("Fired an arrow!");
            
        }

        public void notchArrow()
        {
            Console.WriteLine("Arrow ready!");
        }

    }
}
