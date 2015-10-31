using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.aggregations
{
    class AggregationDemo
    {
        public static void DoAggregationDemo()
        {
            TransactionManager manager = new TransactionManager();
            double totalAmount = manager.Init()
               .AddTransaction(new Transaction(DateTime.Now, 5000.00D))
               .AddTransaction(new Transaction(new DateTime(2015, 5, 25), 9500))
               .AddTransaction(new Transaction(new DateTime(2015, 11, 18), 11000.52D)).GetTotalAmount();
            Console.WriteLine("The aggregated amount is " + totalAmount);



        }
    }
}
