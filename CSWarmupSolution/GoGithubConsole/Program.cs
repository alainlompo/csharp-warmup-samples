using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoGithubConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            GoGithub.SimpleApiDemo sAD = new GoGithub.SimpleApiDemo();
            sAD.DoGitDemo();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
