using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibTemplate.Org.Hypernovae.Libs
{
    public static class ServicesFactory
    {
        private static IServiceContractTemplate<String, String> stringProcessingService;

        public static IServiceContractTemplate<String, String> GetStringProcessingService()
        {
            if (stringProcessingService == null)
            {
                stringProcessingService = new StringProcessingService();
            }

            return stringProcessingService;
        }

    }
}
