using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {


            RobotBuild military = new MilitaryRobot();
            RobotBuild lightweight = new LightweightRobot();


            military.buildRobot();
            lightweight.buildRobot();

            Console.ReadLine();



        }
    }
}
