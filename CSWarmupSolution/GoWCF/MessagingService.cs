﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GoWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Messaging" à la fois dans le code et le fichier de configuration.
    public class MessagingService : IMessagingService
    {
       

        void IMessagingService.DoWork()
        {
            throw new NotImplementedException();
        }

        void IMessagingService.SendSimpleMessage(string originator, string destinator, string message)
        {
            throw new NotImplementedException();
        }
    }
}
