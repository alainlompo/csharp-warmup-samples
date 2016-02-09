using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole.generics.constraints.primary
{
    class AGenericStructPrimaryConstraint<T> where T:struct
    {
        public static T GetUsableInstance()
        {
            // This is possible because all value type have an implicit parameterless constructor
            return new T();
        }
    }
}
