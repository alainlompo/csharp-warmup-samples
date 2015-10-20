using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    class Employees
    {
        List<Employe> emps = new List<Employe>();
        public void SetUpDatas()
        {
            emps.Add(new Employe("Alain", "Lompo", 10001));
            emps.Add(new Employe("Jacques", "Duiz N Heuf", 10002));
            emps.Add(new Employe("Rachid", "Al Oh Mahri", 444554));
        }

        public Employe this[int index]
        {
            get
            {
                return emps[index];
            }
        }

        

    }
}
