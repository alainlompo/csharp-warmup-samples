// The using directive allows us to access to logical namespace contents
// provided that the enwrapped library is already referenced in our projects
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    
    /// <summary>
    /// Simple class with a static method in it.
    /// The Console object provides us with handy methods to read and write from and to the Console
    /// <remarks>You can use special tags to specialize to customize your class documentation</remarks>
    /// </summary>
 
    class WorldGreeter
    {
        public static void greetTheWorld()
        {
            // We can reference the Console object without mentionning its namespace
            // because of the above using System directive, otherwise we should have used System.Console.WriteLine... instead
            Console.WriteLine("Hello world...");
            Console.ReadKey();
        }
    }
}
