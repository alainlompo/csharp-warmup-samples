using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    class IntArrHolder
    {
        private int[] array;
        public IntArrHolder(int[] arr)
        {
            this.array = arr;
        }

        public int[] getArray()
        {
            return array;
        }

        public static IntArrHolder operator +(IntArrHolder array1, IntArrHolder array2)
        {
            int minSize = Math.Min(array1.getArray().GetLength(0), array2.getArray().GetLength(0));
            int[] result = new int[minSize];
            int[] arr1 = array1.getArray();
            int[] arr2 = array2.getArray();

            for (int i = 0; i < minSize; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }

            return new IntArrHolder(result);


        }
    }
}
