using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCollections
{
    /// <summary>
    /// A generic interface for components with caching abilities
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="E"></typeparam>
    interface ICacher<T, E>
    {
         T GetElement(E idObject);

        /// <summary>
        /// Load the record
        /// </summary>
        /// <param name="idObject"></param>
        /// <returns></returns>
         T LoadRecord(E idObject);

        /// <summary>
        /// Checks if the record is stale or not
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
         bool IsStale(T result);

        /// <summary>
        /// Implements cache removal policy here
        /// </summary>
         void DiscardEntries();

    }
}
