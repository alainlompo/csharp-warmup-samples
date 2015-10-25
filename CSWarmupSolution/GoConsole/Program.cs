using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoConsole.events.handling;

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
            Console.WriteLine("Indexer demo .......................");
            IndexerDemo.DoDemo();

            Console.ReadKey();
            Console.WriteLine();
            AttributesDemo1.DoAttributesDemo1();

            Console.WriteLine();
            Console.WriteLine(" Illustrating the Action<T> delegate ....");
            Console.WriteLine();
            ActionTDemo.DoDemo();

            Console.WriteLine();
            Console.WriteLine(" Illustrating classic .Net event handling approach.... ");
            ButtonEventHandlingDemo eventHD = new ButtonEventHandlingDemo();
            eventHD.DoButtonEventHandlingDemo();

            Console.WriteLine();
            Console.WriteLine("Now simple word interop demo....");
            string filePath = @"C:\Hypernovae\Life\My Books\Douze Voeux\Douze Voeux.docx";
            String authorName = SimpleWordInterop.DoInteropDemo(filePath);
            Console.WriteLine("L'auteur du livre <Douze Voeux> est: " + authorName);
            Console.WriteLine();

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Now heating and cooling demo ....");
            Heater lgMegaAirConditionner = new Heater();
            lgMegaAirConditionner.StartConditionningTheAir();

        }
    }
}
