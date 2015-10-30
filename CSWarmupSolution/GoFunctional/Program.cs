using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoFunctional.linq.datasources;
using GoFunctional.linq.extension.methods;
using GoFunctional.linq.filtering;

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

            Console.WriteLine();
            Console.WriteLine(" Illustrate customized data source for linq....");
            TextDataSource dataSource = new TextDataSource();
            dataSource.fromMemory("Un break de batterie \n Coule sur la FM \n Et se mele a mon sang pour faire de moi...");
            var result = from f in dataSource
                         where f.getReservoir().Count == 3
                         select f.getReservoir()[1];
            Console.WriteLine(result);
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("OfType demo .......");
            OfTypeDemo.DoOfTypeDemo();
            Console.ReadKey();
        }
    }
}
