using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.filtering
{
    class PMO:Employee
    {
        public override void Present()
        {
            Console.WriteLine("Hi there, I am a pmo, what a job!, I am n°" + number);
        }
    }
}
