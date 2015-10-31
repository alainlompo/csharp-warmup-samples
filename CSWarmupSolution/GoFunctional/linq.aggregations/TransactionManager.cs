using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.aggregations
{
    class TransactionManager
    {
        public List<Transaction> Transactions { get; set; }

        public TransactionManager Init()
        {
            Transactions = new List<Transaction>();
            return this;
        }

        public TransactionManager AddTransaction(Transaction t)
        {
            Transactions.Add(t);
            return this;

        }

        public double GetTotalAmount()
        {
            return Transactions.Sum(t => t.Amount);
        }
    }
}
