using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole.expl.interfaces.method
{
    class MotorByke:IDrivable
    {

        /// <summary>
        /// This is an EIMI or explicit interface method implementation
        /// for the IDrivable interface. A simple test will show that it is the method called
        /// when accessing the drive method from an IDrivable reference cast from a MotorByke reference
        /// </summary>
        /// <param name="speed"></param>
        public void IDrivable.drive(int speed)
        {
            Console.WriteLine("This is an explicit interface method implemention of the drive method from IDrivable");
        }

        /// <summary>
        /// This method is no longer considered the implementation for the interface drive method since
        /// there is an EIMI for that 
        /// </summary>
        /// <see cref=">">the drive method above</see>
        /// <param name="speed"></param>
        public void drive(int speed)
        {
            Console.WriteLine("Driving at the speed of " + speed + " km/h");
        }
    }
}
