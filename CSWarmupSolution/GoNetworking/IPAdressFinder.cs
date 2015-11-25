using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GoNetworking
{
    class IPAdressFinder
    {
        public static void DoLocalhostDemo()
        {
            IPHostEntry hostDnsEntry = Dns.GetHostEntry("localhost");
            foreach (IPAddress localAdress in hostDnsEntry.AddressList)
            {
                Console.WriteLine("Type {0}, Adress: {1}", localAdress.AddressFamily, localAdress);
            }

            Console.ReadKey();
        }

        public static void DoAnyUrlDemo(String url)
        {

            IPHostEntry hostDnsEntry = Dns.GetHostEntry(url);
            foreach (IPAddress anyAdress in hostDnsEntry.AddressList)
            {
                Console.WriteLine("Type {0}, Adress: {1}", anyAdress.AddressFamily, anyAdress);
            }

            Console.ReadKey();
        }

    }
}
