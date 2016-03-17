using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole.expl.interfaces.method
{
    class Car:IDrivable
    {
        /// <summary>
        /// This methods signature matches that of the IDrivable interface
        /// so the C# considers it as the interface's drive method implementation
        /// </summary>
        /// <param name="speed"></param>
 
        public void drive(int speed)
        {
            Console.WriteLine("This car is going at the speed of " + speed + " km/h");

        }


    }
}
