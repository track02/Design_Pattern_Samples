using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Have some system composed of various parts and pieces
            WidgetX wX = new WidgetX();
            WidgetY wY = new WidgetY();
            WidgetZ wZ = new WidgetZ();
            DoodadB dB = new DoodadB();
            GizmoA gA = new GizmoA();


            Console.WriteLine("\n\nManual Start Up\n\n");

            //Can manually start up the system
            dB.activate();
            gA.switchOn();
            wX.go();
            wY.run();
            wZ.start();

            Console.WriteLine("\n\nManual Shut Down\n\n");

            //And manually shutdown
            dB.deactivate();
            gA.switchOff();
            wX.stop();
            wY.halt();
            wZ.end();


            //Or use a facade to provide a more simple interface
            SystemFacade facade = new SystemFacade(dB, gA, wX, wY, wZ);

            Console.WriteLine("\n\nFacade Start Up\n\n");
            facade.startSystem();

            Console.WriteLine("\n\nFacade Shut Down\n\n");
            facade.stopSystem();

            Console.ReadLine();


        }
    }
}
