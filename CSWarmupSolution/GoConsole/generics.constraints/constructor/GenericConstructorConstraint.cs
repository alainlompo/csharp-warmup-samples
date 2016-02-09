using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole.generics.constraints.constructor
{
    /// <summary>
    /// The constructor constraint species that whatever type is passed here as a
    /// reference it must have a parameterless constructor.
    /// Any value type will do fine since they all have an implicit parameterless constructor
    /// But a reference type must have one in order to comply to this constraint
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class GenericConstructorConstraint<T> where T:new ()
    {
        public static T buildSomeUsefullObject()
        {
            // Do something here
            return new T();
        }
    }
}
