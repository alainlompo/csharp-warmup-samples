using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibTemplate.Org.Hypernovae.Libs
{
    internal class ServiceContract<T,U>:IServiceContractTemplate<T,U>
    {

        public virtual U executeContract(T inData)
        {
            throw new NotImplementedException();
        }
    }
}
