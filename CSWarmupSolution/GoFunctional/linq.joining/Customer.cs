using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.joining
{
    class Customer
    {
        public List<Deal> Deals { get; set; }

        public static Customer GetDemoCustomerAndDeals()
        {
            Customer customer = new Customer();
            Deal d1 = new Deal("DRF0001A", 5895.5);
            Deal d2 = new Deal("DRF0002A", 135000);
            Deal d3 = new Deal("DRF0003A", 40000.5);
            customer.Deals = new List<Deal>();
            customer.Deals.Add(d1);
            customer.Deals.Add(d2);
            customer.Deals.Add(d3);
            return customer;
        }

    }
}
