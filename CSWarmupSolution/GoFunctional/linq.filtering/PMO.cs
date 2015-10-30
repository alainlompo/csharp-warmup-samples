using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.filtering
{
    class PMO:Employee
    {
        public PMO()
        {
        }

        public PMO(double salary):base()
        {
            this.salary = salary;
        }

        public override void Present()
        {
            Console.WriteLine("Hi there, I am a pmo, what a job!, I am n°" + number);
        }
    }
}
