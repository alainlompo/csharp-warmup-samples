using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    class OperatorOverloadingDemo
    {
        public static void DoArrayPlusDemo()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] arr2 = { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            IntArrHolder iAH1 = new IntArrHolder(arr1);
            IntArrHolder iAH2 = new IntArrHolder(arr2);
            IntArrHolder iAH3 = iAH1 + iAH2;

            Console.Write("[");
            foreach (int x in iAH3.getArray())
            {
                
                Console.Write(x + " ");
               
            }
            Console.Write("]");

        }
       
    }
}
