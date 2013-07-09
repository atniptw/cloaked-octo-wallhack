using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubspotAPIWrapper
{
    public class BaseClass
    {
        private string api_key;
        private string access_token;
        private string refresh_token;
        private string client_id;
        private Dictionary<string, object> options;
        public BaseClass(string api_key=null, string access_token=null, string refresh_token=null, string client_id=null)
        {
            this.api_key = api_key;
            this.access_token = access_token;
            this.refresh_token = refresh_token;
            this.client_id = client_id;

            if ((this.api_key.Equals(null)) && (this.access_token.Equals(null)))
            {
                throw new ArgumentException("Cannot use both api_key and access_token");
            }
            if ((this.api_key.Equals(null)) & (this.access_token.Equals(null)) && (this.refresh_token.Equals(null)))
            {
                throw new ArgumentException("Missing required credentials");
            }
            this.options = new Dictionary<string, object>(); //{"api_base": "api.hubapi.com"};
            this.options["api_base"] = "api.hubapi.com";
        }

        protected object call(string subpath, Dictionary<string, object> parameters=null)
        {
            throw new NotImplementedException();
        }
    }
}
