using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole.generics.constraints.primary
{
    /// <summary>
    /// The Primary constraint on the generic parameter let us know that
    /// the parameter is a 'Stream' which means it is a concreat Stream instance
    /// or any of its descendant
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AGenericType<T> where T:System.IO.Stream
    {
        private T genericStream;
        public AGenericType(T stream)
        {
            this.genericStream = stream;
        }
    }
}
