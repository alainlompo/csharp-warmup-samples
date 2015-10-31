using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.zippping
{
    class LinqZippingDemo
    {
        private static string[] dotNetVersions = { "1.0", "1.1", "2.0", "3.0", "3.5", "4.0", "4.5", "4.5.1", "4.5.2", "4.6" };
        private static int[] dotNetReleaseYears = { 2002, 2003, 2005, 2006, 2007, 2010, 2012, 2013, 2014, 2015 };

        public static void DoZippingDemo()
        {
            var history = dotNetVersions.Zip(dotNetReleaseYears, (v, y) =>
                new
                {
                    version = v,
                    year = y

                });

            foreach (var h in history)
            {
                string msg = string.Format("In year {0}, version {1} was released....", h.year, h.version);
                Console.WriteLine(msg);
            }

            Console.WriteLine("To be continued....");
        }
    }
}
