using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class TelevisionOffCommand : ICommand
    {

         private Television tv;

        public TelevisionOffCommand(Television tv)
        {
            this.tv = tv;
        }

        public void execute()
        {
            tv.off();
        }

        public void undo()
        {
            tv.on();
        }


    }
}
