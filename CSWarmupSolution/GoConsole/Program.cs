using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The classic Hello World
            WorldGreeter.greetTheWorld();

            // Exception handling demo
            ExceptionHandlingDemo.DoExceptionDemo();
            Console.ReadKey();

            // Arrays usage first demo
            ArraysDemo.DoDemo1();

            // Destroyer demo (You may not see this....)
            DestroyerDemo.DoDestructionDemo();
            Console.ReadKey();

            // Operator overload demo
            Console.WriteLine();
            Console.WriteLine("Operator overload demo...");
            OperatorOverloadingDemo.DoArrayPlusDemo();

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Now heating and cooling demo ....");
            Heater lgMegaAirConditionner = new Heater();
            lgMegaAirConditionner.StartConditionningTheAir();

        }
    }
}
