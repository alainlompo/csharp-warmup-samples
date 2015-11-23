using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GoNetworking.Web
{
    class RequestAndResponseDemo
    {
        public static void DoRequestResponseDemo()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://github.com/alainlompo");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                string pageDatas = reader.ReadToEnd();
                Console.WriteLine(pageDatas);
                Console.ReadKey();
            }
        }
    }
}
