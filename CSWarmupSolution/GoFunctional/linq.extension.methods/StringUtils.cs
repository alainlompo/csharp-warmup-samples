using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.extension.methods
{
    static class StringUtils
    {
        public static bool IsPalyndrome(this string source)
        {
            char[] chars = source.ToCharArray();
            Array.Reverse(chars);
            String newString = new String(chars);
            return (source.Equals(newString));
        }
    }
}
