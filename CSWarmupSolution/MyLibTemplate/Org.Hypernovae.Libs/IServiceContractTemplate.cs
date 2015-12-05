using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibTemplate.Org.Hypernovae.Libs
{
    public interface IServiceContractTemplate<T,U>
    {
        U executeContract(T inData);
    }
}
