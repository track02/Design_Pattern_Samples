using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class BowAdapter : IGun
    {

        IBow bow;

        public BowAdapter(IBow bow)
        {
            this.bow = bow;
        }

        public void pullTrigger()
        {
            bow.releaseArrow();
        }

        public void loadBullets()
        {
            bow.notchArrow();
        }


    }
}
