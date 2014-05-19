using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {


            //Create some bows and rifles representing cowboys and indians
            IGun rifle1 = new Rifle();
            IGun rifle2 = new Rifle();
            IGun rifle3 = new Rifle();
            IGun rifle4 = new Rifle();

            IBow bow1 = new ShortBow();
            IBow bow2 = new ShortBow();
            IBow bow3 = new ShortBow();
            IBow bow4 = new ShortBow();

            //Some change sides

            //Adapt rifle 4 as a bow 4
            rifle4 = new BowAdapter(bow4);

            //Adapt bow 1 as rifle 1
            bow1 = new GunAdapter(rifle1);


            IGun[] guns = { rifle1, rifle2, rifle3, rifle4 };
            IBow[] bows = { bow1, bow2, bow3, bow4 };


            Console.WriteLine("\n\nCowboys firing!\n\n");

            //Fire
            for (int i = 0; i < guns.Length; i++)
            {

                guns[i].pullTrigger();
                guns[i].loadBullets();
                guns[i].pullTrigger();
                Console.WriteLine("\n");

            }

            Console.WriteLine("\n\nIndians firing!\n\n");

            for (int i = 0; i < bows.Length; i++)
            {

                bows[i].releaseArrow();
                bows[i].notchArrow();
                bows[i].releaseArrow();
                Console.WriteLine("\n");

            }

            Console.ReadLine();

        }
    }
}
