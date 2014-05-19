using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class SystemFacade
    {

        DoodadB dB = new DoodadB();
        GizmoA gA = new GizmoA();

        WidgetX wX = new WidgetX();
        WidgetY wY = new WidgetY();
        WidgetZ wZ = new WidgetZ();

        public SystemFacade(DoodadB dB, GizmoA gA, WidgetX wX, WidgetY wY, WidgetZ wZ)
        {
            this.dB = dB;
            this.gA = gA;
            this.wX = wX;
            this.wY = wY;
            this.wZ = wZ;
        }


        public void startSystem()
        {

            dB.activate();
            gA.switchOn();
            wX.go();
            wY.run();
            wZ.start();

        }


        public void stopSystem()
        {

            dB.deactivate();
            gA.switchOff();
            wX.stop();
            wY.halt();
            wZ.start();

        }


    }
}
