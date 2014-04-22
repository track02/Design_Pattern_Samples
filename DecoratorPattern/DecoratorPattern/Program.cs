using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a new gift
            Present gift = new Car();

            //Wrap it up - Gold
            gift = new GoldWrappingPaper(gift);

            //Wrap it up again - Red
            gift = new RedWrappingPaper(gift);

            //And again - Green
            gift = new GreenWrappingPaper(gift);

            //Once more - Blue
            gift = new BlueWrappingPaper(gift);

            //Unwrap
            Console.WriteLine(gift.getName());
            
            //Count up cost [1000, 1, 5, 3, 2 = 1011]
            Console.WriteLine(gift.getCost());
            
            Console.ReadLine();
            
        }
    }
}
