using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole.enumeretable
{
    class IEnumerableDemo
    {
        public void DoIEnumerableDemo()
        {
            Enumeratorable<Student> holder = new Enumeratorable<Student>();
            List<Student> students = new List<Student>();
            students.Add(new Student("Alain Lompo", 19.5D));
            students.Add(new Student("Khah Trin", 17.5D));
            students.Add(new Student("Yeo Man", 18.00D));

            IEnumerable<String> rankedStudents = holder.AffectRank(students);
            foreach (String rankedStudent in rankedStudents)
            {
                Console.WriteLine(rankedStudent);
            }

            Console.ReadKey();

        }
    }
}
