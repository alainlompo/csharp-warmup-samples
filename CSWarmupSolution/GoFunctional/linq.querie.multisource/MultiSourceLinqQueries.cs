using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.querie.multisource
{
    class MultiSourceLinqQueries
    {
        private static int[] fromZeroToTen = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private static int[] fromTenToZero = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

        public static void DoMultiSourceQueryDemo()
        {
            var sums = from n in fromZeroToTen
                       from z in fromTenToZero
                       select new { sum = n + z };
            foreach (var o in sums)
            {
                Console.WriteLine(o.sum);
            }
        }

    }
}
