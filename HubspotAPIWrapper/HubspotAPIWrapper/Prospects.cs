using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubspotAPIWrapper
{
    class Prospects : BaseClass
    {
        private string PROSPECTS_API_VERSION = "v1";

        public string get_path(string method)
        {
            return string.Format("prospects/{0}/{1}", PROSPECTS_API_VERSION, method);
        }

        public object get_prospects(int offset=0, string orgoffset=null, int limit=0)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            if (limit > 0)
            {
                parameters["count"] = limit;
            }

            if (offset > 0)
            {
                parameters["timeOffset"] = offset;
                parameters["orgOffset"] = orgoffset;
            }

            return this.call("timeline", parameters);
        }

        object get_company(string company_slug)
        {
            return this.call(string.Format("timeline/{0}", company_slug));
        }
    }
}
