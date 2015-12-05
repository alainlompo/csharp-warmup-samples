using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibTemplate.Org.Hypernovae.Libs
{
    internal class StringProcessingService:ServiceContract<String, String>
    {
        public override string executeContract(string inData)
        {
            if (inData == null || inData.Trim().Equals(""))
            {
                return "";
            }

            StringBuilder builder = new StringBuilder();
            IEnumerable<char> reverseDatas = inData.Reverse();
            foreach (char c in reverseDatas)
            {
                builder.Append(c);
            }

            return builder.ToString();
        }

    }
}
