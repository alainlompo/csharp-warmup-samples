using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole.generics.constraints.primary
{
    /// <summary>
    /// T can be a class type, an interface type, a delegate type or array type but not a struct
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class AGenericClassPrimaryConstraint<T> where T:class
    {
    }
}
