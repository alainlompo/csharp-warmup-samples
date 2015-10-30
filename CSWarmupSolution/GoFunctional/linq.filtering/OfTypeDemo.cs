using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.filtering
{
    class OfTypeDemo
    {
        public static void DoOfTypeDemo()
        {
            List<Employee> emps = new List<Employee>();
            emps.Add(new Employee());
            emps.Add(new CEO());
            emps.Add(new PMO());
            emps.Add(new Employee());
            emps.Add(new Employee());
            emps.Add(new CEO());
            emps.Add(new PMO());

            var ceos = from emp in emps.OfType<CEO>()
                       select emp;

            var pmos = from emp in emps.OfType<PMO>()
                       select emp;

            Console.WriteLine("The bosses are ....");
            foreach (CEO ceo in ceos)
            {
                ceo.Present();
            }

            Console.WriteLine();
            Console.WriteLine("The pmos (the hard workers) are ....");
            foreach (PMO pmo in pmos)
            {
                pmo.Present();
            }

        }
    }
}
