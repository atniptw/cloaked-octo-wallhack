using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubspotAPIWrapper
{
    public class Email : BaseClass
    {
        private const string ProspectsApiVersion = "v1";

        public Email(string apiKey = null, string accessToken = null, string refreshToken = null,
                         string clientId = null) : base(apiKey, accessToken, refreshToken, clientId)
        {
        }

        protected override string GetPath(string method)
        {
            return string.Format("email/{0}/{1}", ProspectsApiVersion, method);
        }
    }
}
