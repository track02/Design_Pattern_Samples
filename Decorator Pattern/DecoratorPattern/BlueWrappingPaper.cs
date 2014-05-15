using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class BlueWrappingPaper : WrappingDecorator
    {
        private Present wrappedPresent;
        private String name = "Blue";
        private int cost = 2;

        public BlueWrappingPaper(Present wrapThis)
        {
            this.wrappedPresent = wrapThis;
        }


        public override string getName()
        {
            return this.name + "," + wrappedPresent.getName();
        }


        public override int getCost()
        {
            return this.cost + wrappedPresent.getCost();
        }
    }
}
