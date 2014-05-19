using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class Rifle : IGun
    {
        public void pullTrigger()
        {
            Console.WriteLine("Shot fired!");
        }

        public void loadBullets()
        {
            Console.WriteLine("Ammo loaded!");
        }


    }
}
