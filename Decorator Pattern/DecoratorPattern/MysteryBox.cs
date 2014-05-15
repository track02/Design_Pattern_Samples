using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class MysteryBox : Present
    {

        private int cost = 0;
        private string name = "Mystery Box";

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
