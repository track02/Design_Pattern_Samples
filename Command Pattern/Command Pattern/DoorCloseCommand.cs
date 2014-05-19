using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class DoorCloseCommand : ICommand
    {

                private Door door;

        public DoorCloseCommand(Door door)
        {
            this.door = door;
        }

        public void execute()
        {
            door.close();
        }


        public void undo()
        {
            door.open();
        }


    }
}
