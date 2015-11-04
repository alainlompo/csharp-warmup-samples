using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoStrings
{
    class EncodingShow
    {
        public static void printBytes(byte[] bytes)
        {
            foreach (byte b in bytes)
            {
                Console.Write(b);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        public static void DoEncodingShow()
        {
            Console.WriteLine("Input a string ");
            string source = Console.ReadLine();
            byte[] utf7Bytes = Encoding.UTF7.GetBytes(source);
            byte[] utf8Bytes = Encoding.UTF8.GetBytes(source);

            Console.WriteLine();
            Console.WriteLine("UTF - 7, encoded : ");
            printBytes(utf7Bytes);
            Console.WriteLine();
            Console.WriteLine("UTF - 8, encoded : ");
            printBytes(utf8Bytes);
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
