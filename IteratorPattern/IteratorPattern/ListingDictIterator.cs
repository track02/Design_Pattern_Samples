using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class ListingDictIterator : Iterator
    {

        Dictionary<string, HovercraftListing> listings;
        HovercraftListing[] values;
        int index;

        public ListingDictIterator(Dictionary<string, HovercraftListing> listings)
        {
            this.listings = listings;
            values = listings.Values.ToArray();
        }

        public object next()
        {
            HovercraftListing listing = values[index];
            index++;
            return listing;
        }

        public Boolean hasNext()
        {
            if (index >= values.Length || values[index] == null)
            {
                return false;
            }
            return true;
        }

    }
}
