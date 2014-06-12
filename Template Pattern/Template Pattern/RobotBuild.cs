using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Pattern
{

    
    abstract class RobotBuild
    {


        //Robot is made up of head, arms, legs and torso
        //Can also be painted

        //Only a standard head and arm type exist - handled by abstract
        //Unique legs and torso handled by subclasses


        public void buildRobot()
        {

            addHead();
            addTorso();
            addArms();
            addLegs();

            addPaint();

            Console.WriteLine("\n");

        }

        private void addHead()
        {
            Console.WriteLine("Standard head installed");
        }


        abstract public void addTorso();
 

        private void addArms()
        {
            Console.WriteLine("Standard arms installed");
        }
                
       abstract public void addLegs();
 
         
        //Hook - user can override this method for custom paint if wanted, else bot is left unpainted
        public virtual void addPaint()
        {
            Console.WriteLine("Bot left unpainted");
        }


    }
}
