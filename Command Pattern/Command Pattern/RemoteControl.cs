using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{

    //Invoker - Holds and executes commands
    class RemoteControl
    {

       private List<ICommand> onCommands = new List<ICommand>();
       private List<ICommand> offCommands = new List<ICommand>();

       private ICommand lastCommand;

       public void setOnCommand(ICommand command)
       {
           onCommands.Add(command);
       }

       public void setOffCommand(ICommand command)
       {
           offCommands.Add(command);
       }


       public void onButtonPressed(int commandIndex)
       {
           onCommands[commandIndex].execute();
           lastCommand = onCommands[commandIndex];
       }


        public void offButtonPressed(int commandIndex)
       {
           offCommands[commandIndex].execute();
           lastCommand = offCommands[commandIndex];

       }



        
       public void undoPressed()
       {
           lastCommand.undo();
       }
       
    }
}
