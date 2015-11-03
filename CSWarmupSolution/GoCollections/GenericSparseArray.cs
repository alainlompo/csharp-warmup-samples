using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCollections
{
    /// <summary>
    /// This structure allows the handling of a huge array with only a few non default (or non null) values
    /// Similar structures are used to handle spread sheets for example
    /// </summary>
    /// <typeparam name="E"></typeparam>
    class GenericSparseArray<E>
    {
        private Dictionary<long, E> datas = new Dictionary<long, E>();

        public E this[long index]
        {
            get
            {
                E result;
                datas.TryGetValue(index, out result);
                return result;
            }

            set
            {
                datas[index] = value;
            }
        }
    }
}
