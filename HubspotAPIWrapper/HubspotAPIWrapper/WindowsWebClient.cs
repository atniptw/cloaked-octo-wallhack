using System.Net;

namespace HubspotAPIWrapper
{
    internal class WindowsWebClient : IWebClient
    {
        public string UploadString(string uri, string method = "GET", string contentType = "application/text", string data = "")
        {
            var client = new WebClient();

            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            client.Headers.Add("Content-Type", contentType);

            return client.UploadString(uri, method, data);
        }
    }
}