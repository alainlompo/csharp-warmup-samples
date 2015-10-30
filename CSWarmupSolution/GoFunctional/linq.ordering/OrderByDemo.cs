using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoFunctional.linq.filtering;

namespace GoFunctional.linq.ordering
{
    class OrderByDemo
    {
        public static void DoOrderByDemo()
        {
            List<Employee> employees = GetBunchOfEmployees(10000, 550000);
            var orderedEmps = from emp in employees
                              orderby emp.GetSalary() descending
                              select emp;
            foreach (Employee emp in orderedEmps)
            {
                emp.Present();
                Console.WriteLine("==> Salary: " + emp.GetSalary());
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
                int choice = rnd.Next(1, 4);
                Employee emp = null;
                int salary = rnd.Next(minSalary, maxSalary + 1);
                switch (choice)
                {
                    case 1:
                        emp = new Employee(salary);
                        break;
                    case 2:
                        emp = new PMO(salary);
                        break;
                    case 3:
                        emp = new CEO(salary);
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
