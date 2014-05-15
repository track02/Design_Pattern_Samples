using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Sock : Present
    {
        private int cost = 1;
        private string name = "Sock";

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
