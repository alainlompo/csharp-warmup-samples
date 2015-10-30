using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.filtering
{
    class Employee
    {
        protected static int count = 0;
        protected int number;
        protected double salary;
        protected string country;


        public Employee(double salary, string country)
        {
            this.salary = salary;
            this.country = country;
        }

        public Employee(double salary)
        {
            this.salary = salary;
        }
        public Employee()
        {
            number = ++count;
        }
        public virtual void Present()
        {
            Console.WriteLine("I am the basic type of employee (not much to be proud of eh...) and I am n° " + number );
        }

        public double GetSalary()
        {
            return salary;
        }

        public string GetCountry()
        {
            return country;
        }

    }
}
