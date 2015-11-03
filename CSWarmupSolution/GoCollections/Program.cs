using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Doing generic sparse array demo....");
            GenericSparseArray<string> stringsSparseArray = new GenericSparseArray<string>();
            stringsSparseArray[10000000] = "Hello world....";
            stringsSparseArray[10] = "Hello galaxy....";
        }
    }
}
