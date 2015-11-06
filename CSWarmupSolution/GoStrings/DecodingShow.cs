using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoStrings
{
    class DecodingShow
    {
        public static string decode(byte[] bytes, Encoding encoding)
        {
            return encoding.GetString(bytes);
        }

        public static void DemoDecode()
        {
            string source = "Hello world, ! we are the éxtra development quator";
            byte[] btes8 = Encoding.UTF8.GetBytes(source);
            byte[] btes7 = Encoding.UTF7.GetBytes(source);

            Console.WriteLine("Decoding the utf 7 encoded bytes....");
            DoDecodingShow(btes7);

            Console.WriteLine("Decoding the utf 8 encoeded bytes....");
            DoDecodingShow(btes8);
            

        }
        public static void DoDecodingShow(byte[] bytes)
        {
            String utf7Decoded = decode(bytes, Encoding.UTF7);
            String utf8Decoded = decode(bytes, Encoding.UTF8);

            Console.WriteLine("Decoded using utf7: " + utf7Decoded);
            Console.WriteLine("Decoded using utf8: " + utf8Decoded);
            Console.ReadKey();


        }
    }
}
