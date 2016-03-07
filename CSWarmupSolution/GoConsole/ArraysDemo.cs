using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    /// <summary>
    /// 
    /// </summary>
    class ArraysDemo
    {
        /// <summary>
        /// Simple illustration of numbers usage
        /// 
        /// </summary>
        public static void DoDemo1()
        {
            Console.WriteLine();
            long[] numbers = new long[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = i % 3;
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Sorting the array....");
            Array.Sort(numbers);
            for (int i = 0; i < 10; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.ReadKey();
        }

    }
}
