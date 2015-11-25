using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoNetworking.Web;

namespace GoNetworking
{
    class Program
    {
        static void Main(string[] args)
        {
            RequestAndResponseDemo.DoRequestResponseDemo();
            IPAdressFinder.DoLocalhostDemo();
            Console.Write("Input a url, example:google.com: ");
            string url = Console.ReadLine();
            IPAdressFinder.DoAnyUrlDemo(url);

        }
    }
}
