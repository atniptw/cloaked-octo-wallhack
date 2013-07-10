using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubspotAPIWrapper
{
    public class BaseClass
    {
        private readonly string _apiKey;
        private readonly string _accessToken;
        private readonly string _refreshToken;
        private string _clientId;
        private readonly Dictionary<string, object> _options;
        public BaseClass(string apiKey=null, string accessToken=null, string refreshToken=null, string clientId=null)
        {
            _apiKey = apiKey;
            _accessToken = accessToken;
            _refreshToken = refreshToken;
            _clientId = clientId;

            if ((_apiKey != null) && (this._accessToken != null))
            {
                throw new ArgumentException("Cannot use both api_key and access_token");
            }
            if ((_apiKey == null) & (_accessToken == null) && (_refreshToken == null))
            {
                throw new ArgumentException("Missing required credentials");
            }
            _options = new Dictionary<string, object>();
            _options["api_base"] = "api.hubapi.com";
        }

        protected object Call(string subpath, Dictionary<string, object> parameters=null, string method="GET", string query="")
        {
            var result = this.Callraw(subpath, parameters = parameters, method = method, query = query);
            return Digestresult(result.body);
        }

        private object Callraw(string subpath, Dictionary<string, object> parameters, string method, string query)
        {
            object url;
            object headers;
            object data;

            Preparerequest(out url, out headers, out data, subpath, parameters, query);
        }

        private void Preparerequest(out object url, out object headers, out object data, string subpath, Dictionary<string, object> parameters, string query)
        {
            throw new NotImplementedException();
        }

        private object Digestresult(object body)
        {
            throw new NotImplementedException();
        }
    }
}
