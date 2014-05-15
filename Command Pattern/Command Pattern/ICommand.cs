using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    //Interface for all commands
    interface ICommand
    {

        //Executes the command
        void execute();

        //Reverses the command
        void undo();


    }
}
