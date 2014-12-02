using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Json;

namespace HubspotAPIWrapper
{
    class Deals : BaseClass
    {
        protected object DealsApiVersion = "v1";

        public Deals(string apiKey = null, string accessToken = null, string refreshToken = null,
                 string clientId = null)
            : base(apiKey, accessToken, refreshToken, clientId)
        {
        }

        protected override string GetPath(string method)
        {
            return string.Format("deals/{0}/{1}", DealsApiVersion, method);
        }

        public JsonObject CreateNewDeal(string deal)
        {
            return Call(subpath: "deal", method: "POST", contentType: "application/json", data: deal);
        }

        public void UpdateExistingDeal(string dealId, string data)
        {
            var subpath = string.Format("deal/{0}", dealId);
            Call(subpath: subpath, method: "POST", contentType: "application/json", data: data);
        }

        public void ArchiveDeal(string dealId)
        {
            var subpath = string.Format("deal/{0}", dealId);
            Call(subpath: subpath, method: "DELETE");
        }

        public JsonObject GetDealById(string dealId)
        {
            var subPath = string.Format("deal/{0}", dealId);
            return Call(subpath: subPath);
        }

    }
}
