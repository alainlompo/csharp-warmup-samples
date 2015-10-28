using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoFunctional.linq.extension.methods;

namespace GoFunctional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple demo of Func<T, TResult>....");
            TemperatureConverter tConv = new TemperatureConverter();
            tConv.DoConversionDemo();
            Console.WriteLine();
            Console.WriteLine("Method extension demo....");
            Console.Write("Input a string.....:");
            String src = Console.ReadLine();
            bool isPalyndrome = src.IsPalyndrome();
            if (isPalyndrome)
            {
                Console.WriteLine(src + " is a palyndrome...");
            }
            else
            {
                Console.WriteLine(src + " is not a palyndrome....");
            }

            Console.ReadKey();
        }
    }
}
