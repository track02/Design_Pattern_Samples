using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class RedWrappingPaper : WrappingDecorator
    {

        private Present wrappedPresent;
        private String name = "Red";
        private int cost = 5;

        public RedWrappingPaper(Present wrapThis)
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
