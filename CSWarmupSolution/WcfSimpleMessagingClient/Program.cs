using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using GoWCF;

namespace WcfSimpleMessagingServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost messagingHost = new ServiceHost(typeof(GoWCF.MessagingService)))
            {
                messagingHost.Open();
                Console.WriteLine("Messaging service initialized...");
                Console.WriteLine("Type quit to close the service and exit....");
                String text = null;
                while (true)
                {
                    text = Console.ReadLine();
                    if (text.Trim().ToUpper().Equals("QUIT"))
                    {
                        break;
                    }
                }

                Console.WriteLine("Terminating the messaging service host....");
                messagingHost.Close(TimeSpan.FromSeconds(5.00D));
            }
        }
    }
}
