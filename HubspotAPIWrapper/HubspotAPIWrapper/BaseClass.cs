using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Json;
using System.Linq;
using Microsoft.Security.Application;

namespace HubspotAPIWrapper
{
    public class BaseClass : IBaseClass
    {
        private readonly string _accessToken;
        private readonly string _apiKey;
        private readonly Dictionary<string, object> _options;
        private readonly string _refreshToken;

        public BaseClass(string apiKey = null, string accessToken = null, string refreshToken = null,
                         string clientId = null)
        {
            if (apiKey != null) _apiKey = apiKey;
            if (accessToken != null) _accessToken = accessToken;
            if (refreshToken != null) _refreshToken = refreshToken;


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
            UserWebClient = new WindowsWebClient();
        }

        public IWebClient UserWebClient { get; set; }

        protected virtual string GetPath(string subPath)
        {
            throw new NotImplementedException();
        }

        protected JsonObject Call(string subpath, string method = "GET", string query = "", string contentType = "application/text",
                                  string data = "", Dictionary<string, string> optionalParams = null, string other = "")
        {
            string uri;

            if (_accessToken != null)
            {
                uri = String.Format("https://{0}/{1}?access_token={2}", _options["api_base"],
                                    GetPath(subpath), _accessToken);
            }
            else
            {
                uri = String.Format("https://{0}/{1}?hapikey={2}", _options["api_base"],
                                    GetPath(subpath), _apiKey);
            }

            if (query.Length > 0)
            {
                uri = string.Format("{0}&q={1}", uri, query);
            }

            if (other.Length > 0)
            {
                uri = string.Format("{0}&{1}", uri, other);
            }

            if (optionalParams != null)
            {
                uri = optionalParams.Aggregate(uri,
                                               (current, optionalParam) =>
                                               string.Format("{0}&{1}={2}", current, optionalParam.Key,
                                                             optionalParam.Value));
            }
            Debug.WriteLine(uri);
            var returnVal = UserWebClient.UploadString(uri, method: method, contentType: contentType, data: data);

            if (returnVal != null)
            {
                if (returnVal.Length > 0)
                {
                    return new JsonObject(JsonValue.Parse(returnVal));
                }
            }

            return new JsonObject();
        }
    }
}