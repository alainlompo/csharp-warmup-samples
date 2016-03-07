using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    /// <summary>
    /// A class used for demo
    /// </summary>
    class Employe
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int IdNumber { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + "(" + IdNumber + ")";
        }

        public Employe()
        {
        }

        public Employe(String fN, String lN, int idN)
        {
            FirstName = fN;
            LastName = lN;
            IdNumber = idN;
        }
    }
}
