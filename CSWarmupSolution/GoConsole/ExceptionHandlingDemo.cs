using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    class ExceptionHandlingDemo
    {
        public static void DoExceptionDemo()
        {
            Console.WriteLine("Exception handling demo....");

            // The program logic you want to watch over goes into the try block
            try
            {
                Console.WriteLine("Input a number (Hint: in fact input something wrong....)");
                int i = int.Parse(Console.ReadLine());

                Console.WriteLine("Input a second number (Hint: input zero or something wrong....)");
                int j = int.Parse(Console.ReadLine());
                int k = i / j;

                Console.WriteLine(i + " / " + j + " = " + k);
                Console.ReadKey();
            }
            // The catch blocks contain the exception handling code
            // We can have many exception blocks and should arrange them
            // from the most specialized exception type to the most general exception type
            catch (DivideByZeroException dBZE)
            {
                Console.WriteLine("A division by zero occured : " + dBZE.Message);

            }
            catch (OverflowException oFE)
            {
                Console.WriteLine("An overflow condition occured : " + oFE.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception has been caught: " + ex.Message);
                Console.WriteLine("Here is the stack trace: " + ex.StackTrace);

            }
        }
    }
}
