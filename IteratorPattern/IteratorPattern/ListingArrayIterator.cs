using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class ListingArrayIterator : Iterator
    {

        HovercraftListing[] listings;
        int index = 0;


        public ListingArrayIterator(HovercraftListing[] listings)
        {
            this.listings = listings;
        }


        public object next()
        {
            HovercraftListing listing = listings[index];
            index = index + 1;
            return listing;
        }

        public Boolean hasNext()
        {
            if (index >= listings.Length || listings[index] == null)
            {
                return false;
            }

            return true;
        }


    }
}
