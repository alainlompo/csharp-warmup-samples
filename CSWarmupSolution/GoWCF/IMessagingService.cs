using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GoWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IMessaging" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IMessagingService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        void SendSimpleMessage(string originator, string destinator, string message);
    }
}
