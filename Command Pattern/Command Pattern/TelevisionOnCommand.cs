using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class TelevisionOnCommand : ICommand
    {

        private Television tv;

        public TelevisionOnCommand(Television tv)
        {
            this.tv = tv;
        }


        public void execute()
        {
            tv.on();
        }

        public void undo()
        {
            tv.off();
        }

    }
}
