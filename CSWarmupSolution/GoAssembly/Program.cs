using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibTemplate.Org.Hypernovae.Libs;

namespace GoAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceContractTemplate<String, String>
                myStringService = ServicesFactory.GetStringProcessingService();
            Console.Write("Input a string : ");
            String source = Console.ReadLine();
            String reversed = myStringService.executeContract(source);
            Console.WriteLine("The source string reversed becomes: " + reversed);
            Console.ReadKey();
        }
    }
}
