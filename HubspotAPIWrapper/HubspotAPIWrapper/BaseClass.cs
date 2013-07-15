using System;
using System.Collections.Generic;
using System.Json;

namespace HubspotAPIWrapper
{
    public class BaseClass
    {
        private readonly string _accessToken;
        private readonly string _apiKey;
        private readonly Dictionary<string, object> _options;
        private readonly string _refreshToken;
        private string _clientId;

        public BaseClass(string apiKey = null, string accessToken = null, string refreshToken = null,
                         string clientId = null)
        {
            if (apiKey != null) _apiKey = apiKey;
            if (accessToken != null) _accessToken = accessToken;
            if (refreshToken != null) _refreshToken = refreshToken;
            if (clientId != null) _clientId = clientId;

            if (_apiKey != null && _accessToken != null)
            {
                throw new ArgumentException("Cannot use both api_key and access_token");
            }
            if ((_apiKey == null) && (_accessToken == null) && (_refreshToken == null))
            {
                throw new ArgumentException("Missing required credentials");
            }
            _options = new Dictionary<string, object>();
            _options["api_base"] = "api.hubapi.com";
        }

        public IWebClient UserWebClient { get; set; }

        private void PrepareConnectionType()
        {
            throw new NotImplementedException();
        }

        protected virtual string GetPath(string subPath)
        {
            throw new NotImplementedException();
        }

        private void Preparerequest(out object url, out object headers, out object data, string subpath,
                                    Dictionary<string, object> parameters, string query)
        {
            throw new NotImplementedException();
        }

        protected JsonObject Call(string subpath, Dictionary<string, object> parameters = null, string method = "GET",
                                  string query = "")
        {
            string result = CallRaw(subpath, parameters = parameters, method = method, query = query);
            return new JsonObject((JsonValue.Parse(result)));
        }

        private string CallRaw(string subpath, Dictionary<string, object> parameters, string method, string query)
        {
            return
                UserWebClient.GetWebResponse(String.Format("https://{0}/{1}?access_token={2}", _options["api_base"],
                                                           GetPath(subpath), _accessToken));
        }
    }
}