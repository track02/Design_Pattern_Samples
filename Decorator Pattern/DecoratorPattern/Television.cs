using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Television : Present
    {

        private int cost = 200;
        private string name = "TV";

        public override string getName()
        {
            return this.name;
        }

        public override int getCost()
        {
            return this.cost;
        }


    }
}
