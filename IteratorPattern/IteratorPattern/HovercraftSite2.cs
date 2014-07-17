using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{

    class HovercraftSite2 : SalesSite
    {
        private Dictionary<string, HovercraftListing> listings;

        public HovercraftSite2()
        {

            listings = new Dictionary<string, HovercraftListing>();
            listings.Add("Mid Range", new HovercraftListing("Skimmer", "£5000", "Blue"));
            listings.Add("Low Range", new HovercraftListing("Flipper", "£1000", "White"));
            listings.Add("High Range", new HovercraftListing("Speedster", "20000", "Gold"));
         }

        public Iterator createIterator()
        {
            return new ListingDictIterator(listings);
        }


    }
}
