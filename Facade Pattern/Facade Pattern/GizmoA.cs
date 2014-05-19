using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class GizmoA
    {


        public void switchOn()
        {
            Console.WriteLine("Gizmo ready!");
        }

        public void switchOff()
        {
            Console.WriteLine("Gizmo off!");
        }


    }
}
