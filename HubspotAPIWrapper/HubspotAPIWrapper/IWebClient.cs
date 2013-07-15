namespace HubspotAPIWrapper
{
    public interface IWebClient
    {
        string UploadString(string uri, string method = "", string data = "", string contentType = "");
    }
}