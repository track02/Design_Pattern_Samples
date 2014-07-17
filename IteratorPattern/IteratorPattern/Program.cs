using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {


            //Two websites selling hovercrafts
            SalesSite site1 = new HovercraftSite1();
            SalesSite site2 = new HovercraftSite2();

            //Site 1 holds its sale listings in an array, site 2 uses a dictionary
            //Can loop through both using the same method w/ an iterator

            Console.WriteLine("Site 1 Listings\n");
            printHovercraftListings(site1);
            Console.WriteLine("Site 2 Listings\n");
            printHovercraftListings(site2);

            Console.ReadLine();
            
        }


        private static void printHovercraftListings(SalesSite site)
        {
            Iterator listingIterator = site.createIterator();
            HovercraftListing current;

            while (listingIterator.hasNext())
            {
                current = (HovercraftListing) listingIterator.next();
                Console.WriteLine(current.toString() + "\n");
            }

        }
    }
}
