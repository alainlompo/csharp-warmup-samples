using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.extension.methods
{
    static class StringUtils
    {
        /// <summary>
        /// This particular method definition approach allow us to 
        /// define an extension method called IsPalyndrome that would appear
        /// on any string object that is processed where the library containing StringUtils
        /// is contextually present.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsPalyndrome(this string source)
        {
            char[] chars = source.ToCharArray();
            Array.Reverse(chars);
            String newString = new String(chars);
            return (source.Equals(newString));
        }
    }
}
