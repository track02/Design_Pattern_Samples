using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class WidgetX
    {

        public void go()
        {
            Console.WriteLine("Widget X activated!");
        }

        public void stop()
        {
            Console.WriteLine("Widget X deactivated!");
        }

    }
}
