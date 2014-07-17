using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class HovercraftSite1 : SalesSite
    {


        private HovercraftListing[] listings;



        public HovercraftSite1()
        {

            listings = new HovercraftListing[3];
            listings[0] = new HovercraftListing("Screamer 41000X2", "£400000", "Silver");
            listings[1] = new HovercraftListing("Red Devil 91 Extreme Turbo", "£1000000", "Red");
            listings[2] = new HovercraftListing("Bathtub", "£1000", "White");          
  
        }

        public Iterator createIterator()
        {
            return new ListingArrayIterator(listings);
        }

     }
}
