using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            String baseFolder = @"C:\Hypernovae\Technical\repositories\csharp-warmup-samples\CSWarmupSolution\GoStreams\";
            DuplicateFileFinder.FindDuplicates(new string[] { "/recurse", baseFolder });
            Console.ReadKey();
        }
    }
}
