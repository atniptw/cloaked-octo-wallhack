using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HubspotAPIWrapper
{
    class WindowsWebClient : IWebClient
    {
        public string GetWebResponse(string uri)
        {
            var client = new WebClient();
            //client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            var data = client.OpenRead(uri);
            string response = null;
            if (data != null)
            {
                var reader = new StreamReader(data);
                response = reader.ReadToEnd();
            }
            return response;
        }
    }
}
