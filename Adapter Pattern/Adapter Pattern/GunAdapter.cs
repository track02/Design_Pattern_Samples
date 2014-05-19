using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class GunAdapter : IBow
    {

        IGun gun;

        public GunAdapter(IGun gun)
        {
            this.gun = gun;
        }


        public void notchArrow()
        {
            gun.loadBullets();
        }

        public void releaseArrow()
        {
            gun.pullTrigger();
        }

    }
}
