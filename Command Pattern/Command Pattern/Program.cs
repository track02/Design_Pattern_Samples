using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a remote control

            RemoteControl remote = new RemoteControl();

            //Create appliances to be controlled
            Television tv1 = new Television("Living Room");
            Television tv2 = new Television("Bedroom");
            Television tv3 = new Television("Kitchen");


            Light l1 = new Light("Upstairs");
            Light l2 = new Light("Downstairs");

            Door d1 = new Door("Downstairs");


            //Setup commands for each appliance
            TelevisionOnCommand tv1com = new TelevisionOnCommand(tv1);
            TelevisionOnCommand tv2com = new TelevisionOnCommand(tv2);
            TelevisionOnCommand tv3com = new TelevisionOnCommand(tv3);

            LightOnCommand l1com = new LightOnCommand(l1);
            LightOnCommand l2com = new LightOnCommand(l2);

            DoorOpenCommand d1com = new DoorOpenCommand(d1);

            //Bind commands to remote
            remote.setCommand(tv1com);
            remote.setCommand(tv2com);
            remote.setCommand(tv3com);
            remote.setCommand(l1com);
            remote.setCommand(l2com);
            remote.setCommand(d1com);


            //Activate devices around the home
            remote.onButtonPressed(0);
            remote.onButtonPressed(3);
            remote.onButtonPressed(4);
            remote.undoPressed();
            remote.onButtonPressed(5);
            remote.onButtonPressed(1);

            Console.ReadLine();



        }
    }
}
