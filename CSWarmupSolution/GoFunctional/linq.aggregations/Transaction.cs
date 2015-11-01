using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.aggregations
{
    class Transaction
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Reference { get; set; }

        public Transaction(DateTime date, double amount)
        {
            Date = date;
            Amount = amount;
        }

        public Transaction(DateTime date, double amount, String reference)
        {
            Date = date;
            Amount = amount;
            this.Reference = reference;
        }


    }
}
