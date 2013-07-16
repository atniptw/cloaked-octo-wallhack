using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        protected virtual string GetPath(string subPath)
        {
            throw new NotImplementedException();
        }

        protected JsonObject Call(string subpath, string method = "GET", string query = "", string contentType="")
        {
            string uri = String.Format("https://{0}/{1}?access_token={2}", _options["api_base"],
                                       GetPath(subpath), _accessToken);
            if (query.Length > 0)
            {
                uri = string.Format("{0}&q={1}", uri, query);
            }

            Debug.WriteLine(uri);
            var returnVal = UserWebClient.UploadString(uri, method: method, contentType: contentType);

            if (returnVal != null)
            {
                return new JsonObject(JsonValue.Parse(returnVal));
            }
            else
            {
                return new JsonObject();
            }
        }
    }
}