using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.taking.and.skipping
{
    class TakingAndSkippingDemo
    {
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        public static void DoSkipAndTakeDemo(int numberToSkip, int numberToTake)
        {
            var leftNumbers = numbers.Skip(numberToSkip).Take(numberToTake);
            foreach (var n in leftNumbers)
            {
                Console.Write(n + "   ");
            }
                              
        }

    }
}
