using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class GoldWrappingPaper : WrappingDecorator
    {

        private Present wrappedPresent;
        private String name = "Gold";
        private int cost = 1;

        public GoldWrappingPaper(Present wrapThis)
        {
            this.wrappedPresent = wrapThis;
        }


        public override String getName()
        {
            return this.name + "," + wrappedPresent.getName();
        }


        public override int getCost()
        {
            return this.cost + wrappedPresent.getCost();
        }


    }
}
