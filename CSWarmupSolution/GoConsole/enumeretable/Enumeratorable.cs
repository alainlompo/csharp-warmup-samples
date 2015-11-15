using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole.enumeretable
{
    public class Enumeratorable<T>
    {
        public IEnumerable<String> AffectRank(IEnumerable<T> objects)
        {
            int rank = 0;
            foreach (T obj in objects)
            {
                yield return String.Format("[{0}]: {1}", rank, obj.ToString());
                rank += 1;

            }
        }
    }
}
