using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class DoodadB
    {

        public void activate()
        {
            Console.WriteLine("Spinning up doodad!");
        }

        public void deactivate()
        {
            Console.WriteLine("Spinning down doodad!");
        }


    }
}
