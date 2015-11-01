using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.joining
{
    class Deal
    {
        public string Reference { get; set; }
        public double Amount { get; set; }

        public Deal(string reference, double amount)
        {
            this.Reference = reference;
            this.Amount = amount;
        }
    }
}
