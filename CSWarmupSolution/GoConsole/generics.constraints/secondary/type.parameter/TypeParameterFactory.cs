using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole.generics.constraints.secondary.type.parameter
{
    class TypeParameterFactory
    {
        /// <summary>
        /// 
        /// We are using a secondary [type parameter constraint]. It indicates
        /// a relationship between the two generic parameters (inheritance)
        /// T is a type that is a [K] meaning a concrete K or a type descending from K
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<K> DoSomethingWithIList<T, K>(IList<T> list) where T : K
        {
            List<K> baseList = new List<K>(list.Count);
            foreach (T t in list)
            {
                baseList.Add(t);
            }
            return baseList;
        }
    }
}
