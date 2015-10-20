using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    class DestroyerDemo
    {
        ~DestroyerDemo()
        {
            Console.WriteLine("Invocation of the DestroyerDemo's class destroyer....");
        }

        public static void DoDestructionDemo()
        {
            DestroyerDemo dD = new DestroyerDemo();
            dD = null;

        }
    }
}
