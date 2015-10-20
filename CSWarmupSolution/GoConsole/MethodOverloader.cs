using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    /// <summary>
    /// Demonstrate the method overloading principle
    /// <example>
    ///     MethodOverloader mO = new MethodOverloader(); 
    ///     mo.sum(1,2); 
    ///     mo.sum(1,2,3); 
    ///     mo.sum(1,2,3,4);
    /// </example>
    /// </summary>
    class MethodOverloader
    {
        /// <summary>
        /// The base method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int sum(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// First overload method, we do the computing the traditional way
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int sum(int a, int b, int c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Here we take advantage of the already existing methods to compute the sum
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public int sum(int a, int b, int c, int d)
        {
            return sum(sum(a, b), c, d);
        }
    }
}
