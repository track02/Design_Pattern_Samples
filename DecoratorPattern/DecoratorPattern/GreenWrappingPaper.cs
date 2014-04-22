using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class GreenWrappingPaper : WrappingDecorator
    {
        private Present wrappedPresent;
        private String name = "Green";
        private int cost = 3;

        public GreenWrappingPaper(Present wrapThis)
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
