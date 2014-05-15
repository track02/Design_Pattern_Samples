using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class DoorOpenCommand : ICommand
    {

        private Door door;

        public DoorOpenCommand(Door door)
        {
            this.door = door;
        }

        public void execute()
        {
            door.open();
        }


        public void undo()
        {
            door.close();
        }

    }
}
