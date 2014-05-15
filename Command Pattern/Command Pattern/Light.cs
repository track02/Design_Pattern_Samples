using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class Light
    {

        private string location;

        public Light(string location)
        {
            this.location = location;
        }

        public void on()
        {
            Console.WriteLine(location + " light switched on!");
        }

        public void off()
        {
            Console.WriteLine(location + " light switched off!");
        }



    }
}
