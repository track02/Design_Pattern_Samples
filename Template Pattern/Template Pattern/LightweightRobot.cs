using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Pattern
{
    class LightweightRobot : RobotBuild
    {
        
        public override void addLegs()
        {
            Console.WriteLine("Hollow legs installed");
        }


        public override void addTorso()
        {
            Console.WriteLine("Lightweight torso installed");
        }
        

    }
}
