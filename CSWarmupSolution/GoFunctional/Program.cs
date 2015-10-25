using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple demo of Func<T, TResult>....");
            TemperatureConverter tConv = new TemperatureConverter();
            tConv.DoConversionDemo();
        }
    }
}
