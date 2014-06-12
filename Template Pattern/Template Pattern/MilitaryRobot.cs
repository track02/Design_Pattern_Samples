using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Pattern
{
    class MilitaryRobot : RobotBuild
    {

        public override void addLegs()
        {
            Console.WriteLine("Tank tracks installed");
        }

        public override void addTorso()
        {
            Console.WriteLine("Armoured torso installed");
        }

        public override void addPaint()
        {
            Console.WriteLine("Camo paint applied");
        }



    }
}
