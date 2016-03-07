using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCollections
{
    /// <summary>
    /// An abstract generic component that implements the ICacher<T,E> GetElement method using a Dictionary<T,E> object
    /// The other methods of the ICacher interface remain abstract in order to be implemented
    /// by a concrete subclass of DicoBasedCache<T,E>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="E"></typeparam>
    abstract class DicoBasedCache<T,E>: ICacher<T,E>
    {
        private Dictionary<E, T> cachedItems = new Dictionary<E, T>();

        public T GetElement(E idObject)
        {
            T result;
            if (cachedItems.TryGetValue(idObject, out result))
            {
                // If there is an item then we need to assess that it is not stale
                if (IsStale(result))
                {
                    result = default(T);
                }
                
            }

            if (result == null)
            {
                result = LoadRecord(idObject);
                cachedItems[idObject] = result;
            }

            DiscardEntries();
            return result;
        }

        public abstract T LoadRecord(E idObject);

        public abstract bool IsStale(T result);
      
        public abstract void DiscardEntries();
    }
}
