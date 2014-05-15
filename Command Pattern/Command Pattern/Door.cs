using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class Door
    {

                private string location;

        public Door(string location)
        {
            this.location = location;
        }


        public void open()
        {
            Console.WriteLine("Door opened " + location);
        }


        public void close()
        {
            Console.WriteLine("Door closed " + location);
        }

    }
}
