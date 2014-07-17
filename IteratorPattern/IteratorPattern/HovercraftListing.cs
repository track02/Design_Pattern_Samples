using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class HovercraftListing
    {

        private string name;
        private string price;
        private string colour;


        public HovercraftListing(string name, string price, string colour)
        {
            this.name = name;
            this.price = price;
            this.colour = colour;

        }

        public string toString()
        {
            return "Name: " + name + "\nPrice: " + price + "\nColour: " + colour;
        }


    }
}
