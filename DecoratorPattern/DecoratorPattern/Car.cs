using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Car : Present
    {

        private int cost = 10000;
        private string name = "Car";

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
