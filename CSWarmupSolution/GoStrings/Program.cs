using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Displaying the cultures of the world ...");
            CultureInfoShow.DoCultureInfoShow();
            Console.ReadKey();
            EncodingShow.DoEncodingShow();
        }
    }
}
