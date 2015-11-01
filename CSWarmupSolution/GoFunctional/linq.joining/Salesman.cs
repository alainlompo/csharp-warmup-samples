using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoFunctional.linq.aggregations;

namespace GoFunctional.linq.joining
{
    class Salesman
    {
        public List<Transaction> Transactions { get; set; }
        public static Salesman GetDemoSalesman()
        {
            Salesman salesman = new Salesman();
            Transaction t1 = new Transaction(DateTime.Now, 5895.5, "DRF0001A");
            Transaction t2 = new Transaction(DateTime.Now, 135000, "DRF0002A");
            Transaction t3 = new Transaction(DateTime.Now, 40000.5, "DRF0003A");
            salesman.Transactions = new List<Transaction>();
            salesman.Transactions.Add(t1);
            salesman.Transactions.Add(t2);
            salesman.Transactions.Add(t3);

            
            return salesman;
        }

    }
}
