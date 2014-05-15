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
       private ICommand lastCommand;

       public void setCommand(ICommand command)
       {
           onCommands.Add(command);
       }


       public void onButtonPressed(int commandIndex)
       {
           onCommands[commandIndex].execute();
           lastCommand = onCommands[commandIndex];
       }

       public void undoPressed()
       {
           lastCommand.undo();
       }
       
    }
}
