using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    class IndexerDemo
    {
        public static void DoDemo()
        {
            Employees boss = new Employees();
            boss.SetUpDatas();
            Employe n2 = boss[1];
            Console.WriteLine("The picked up employee using indexers is ... " + n2);
            Console.ReadKey();
        }
    }
}
