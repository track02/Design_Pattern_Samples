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


            //Setup on commands for each appliance
            TelevisionOnCommand tv1on = new TelevisionOnCommand(tv1);
            TelevisionOnCommand tv2on = new TelevisionOnCommand(tv2);
            TelevisionOnCommand tv3on = new TelevisionOnCommand(tv3);

            LightOnCommand l1on = new LightOnCommand(l1);
            LightOnCommand l2on = new LightOnCommand(l2);

            DoorOpenCommand d1on = new DoorOpenCommand(d1);

            //Setup off commands for each appliance
            TelevisionOffCommand tv1off = new TelevisionOffCommand(tv1);
            TelevisionOffCommand tv2off = new TelevisionOffCommand(tv2);
            TelevisionOffCommand tv3off = new TelevisionOffCommand(tv3);

            LightOffCommand l1off = new LightOffCommand(l1);
            LightOffCommand l2off = new LightOffCommand(l2);

            DoorCloseCommand d1off = new DoorCloseCommand(d1);


            //Macro command - turn on all tvs at once
            MacroCommand allTvOn = new MacroCommand(new ICommand[] {tv1on, tv2on, tv3on});


            //Bind commands to remote
            remote.setOnCommand(tv1on);
            remote.setOnCommand(tv2on);
            remote.setOnCommand(tv3on);
            remote.setOnCommand(l1on);
            remote.setOnCommand(l2on);
            remote.setOnCommand(d1on);
            
            //Add macro
            remote.setOnCommand(allTvOn);

            remote.setOffCommand(tv1off);
            remote.setOffCommand(tv2off);
            remote.setOffCommand(tv3off);
            remote.setOffCommand(l1off);
            remote.setOffCommand(l2off);
            remote.setOffCommand(d1off);


            
            //Activate devices around the home
            remote.onButtonPressed(0);
            remote.onButtonPressed(3);
            remote.onButtonPressed(4);
            remote.undoPressed();
            remote.onButtonPressed(5);
            remote.onButtonPressed(1);
            

            //Turns everything off
            remote.offButtonPressed(0);
            remote.offButtonPressed(3);
            remote.offButtonPressed(5);
            remote.offButtonPressed(1);
            

            //Activate macro command
            remote.onButtonPressed(6);
            //Undo
            remote.undoPressed();

            Console.ReadLine();



        }
    }
}
