using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Json;
using System.Web.Script.Serialization;

namespace HubspotAPIWrapper
{
    public class BaseClass
    {
        private readonly string _accessToken;
        private readonly string _apiKey;
        private readonly Dictionary<string, object> _options;
        private readonly string _refreshToken;
        private string _clientId;
        public IWebClient WebClient { get; set; }

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

        private void PrepareConnectionType()
        {
            throw new NotImplementedException();
        }

        private string GetPath(string subPath)
        {
            throw new NotImplementedException();
        }

        private void Preparerequest(out object url, out object headers, out object data, string subpath,
                                    Dictionary<string, object> parameters, string query)
        {
            throw new NotImplementedException();
        }

        protected object Call(string subpath, Dictionary<string, object> parameters = null, string method = "GET",
                              string query = "")
        {
            string result = CallRaw(subpath, parameters = parameters, method = method, query = query);
            return DigestResult(result);
        }

        private string CallRaw(string subpath, Dictionary<string, object> parameters, string method, string query)
        {
            object url;
            object headers;
           
            var client = new WebClient();

            var data = client.OpenRead("");
            string response = null;
            if (data != null)
            {
                var reader = new StreamReader(data);
                response = reader.ReadToEnd();
            }
            return response;
        }



        private JsonObject DigestResult(string body)
        {
            JsonObject data = null;
            if (body != null)
            {
                var serializer = new JavaScriptSerializer();
                data = serializer.Deserialize<JsonObject>(body);
            }

            return data;
        }
    }


}