using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.joining
{
    class LinqJoinDemo
    {
        public static void DoLinqJoinDemo()
        {
            Customer demoCustomer = Customer.GetDemoCustomerAndDeals();
            Salesman demoSalesMan = Salesman.GetDemoSalesman();
            var businessOp = from deal in demoCustomer.Deals
                             join tx in demoSalesMan.Transactions
                             on deal.Reference
                             equals tx.Reference
                             select new { OpCustomer = "demoCustomer", OpSalesman = "demoSalesman", Reference = deal.Reference, Amount = tx.Amount };
            foreach (var bO in businessOp)
            {
                Console.WriteLine(String.Format("Customer: {0}, Salesman: {1}, Transaction reference: {2}, Amount: {3}", bO.OpCustomer, bO.OpSalesman, bO.Reference, bO.Amount));

            }
        }
    }
}
