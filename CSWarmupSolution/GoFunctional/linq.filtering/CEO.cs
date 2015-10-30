using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.filtering
{
    class CEO:Employee
    {
        public CEO() { }
        public CEO(double salary) : base() { this.salary = salary; }
        public override void Present()
        {
            Console.WriteLine("I am the boss around here (and I am bossy): I am n° " + number);
        }
    }
}
