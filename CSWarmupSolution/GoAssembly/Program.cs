using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibTemplate.Org.Hypernovae.Libs.StringProcessingService service
                = new MyLibTemplate.Org.Hypernovae.Libs.StringProcessingService();
            Console.Write("Input a string : ");
            String source = Console.ReadLine();
            String reversed = service.executeContract(source);
            Console.WriteLine("The source string reversed becomes: " + reversed);
            Console.ReadKey();
        }
    }
}
