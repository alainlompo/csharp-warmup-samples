using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole.enumeretable
{
    class Student
    {
        public double Grade { get; set; }
        public String Name { get; set; }

        public override string ToString()
        {
            return "Name : " + Name + ", and grade: " + Grade;
        }

        public Student(String name, double grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}
