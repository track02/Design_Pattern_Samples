using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class Television
    {

        private string location;

        public Television(string location)
        {
            this.location = location;
        }

        public void on()
        {
            Console.WriteLine("TV in the " + location + " is on!");
        }

        public void off()
        {
            Console.WriteLine("TV in the " + location + " is on!");
        }

    }
}
