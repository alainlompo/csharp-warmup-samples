using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoFunctional.linq.filtering;

namespace GoFunctional.linq.grouping
{
    /// <summary>
    /// Illustrating linq group by feature...
    /// </summary>
    class GroupByDemo
    {
        public static void DoGroupByDemo()
        {
            List<Employee> emps = GetBunchOfEmployees(10000, 554950);
            var employeesByCountry = from emp in emps
                            orderby emp.GetSalary(), emp.GetCountry()
                            group emp by emp.GetCountry();
            foreach (var country in employeesByCountry)
            {
                
                Console.WriteLine("==> events for " + country.Key);
                foreach (var item in country)
                {
                    item.Present();
                    Console.WriteLine("... I make " + item.GetSalary());
                }
            }

                            
                            
        }

        public static List<Employee> GetBunchOfEmployees(int minSalary, int maxSalary)
        {
            List<Employee> emps = new List<Employee>();
            Console.WriteLine("We are an equal opportunity company (that means you can earn as much as a CEO)...");
            Random rnd = new Random();
            int numOfEmps = rnd.Next(10, 50);
            
            
            for (int i = 0; i < numOfEmps; i++)
            {
                int countryNum = rnd.Next(1,4);
                String country = null;
                switch (countryNum)
                {
                    case 1:
                        country = "USA";
                        break;
                    case 2:
                        country = "New Zealand";
                        break;
                    case 3:
                        country = "Netherlands";
                        break;
                    default:
                        country = "USA";
                        break;
                }

                int choice = rnd.Next(1, 4);
                Employee emp = null;
                int salary = rnd.Next(minSalary, maxSalary + 1);
                switch (choice)
                {
                    case 1:
                        emp = new Employee(salary, country);
                        break;
                    case 2:
                        emp = new PMO(salary, country);
                        break;
                    case 3:
                        emp = new CEO(salary,country);
                        break;
                    default:
                        emp = new Employee(salary);
                        break;
                }

                emps.Add(emp);
            }
            return emps;
        }
    }
    
}
