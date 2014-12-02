using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Json;

namespace HubspotAPIWrapper
{
    public class Companies : BaseClass
    {
        protected object CompaniesApiVersion = "v2";

        public Companies(string apiKey = null, string accessToken = null, string refreshToken = null,
                 string clientId = null)
            : base(apiKey, accessToken, refreshToken, clientId)
        {
        }

        protected override string GetPath(string method)
        {
            return string.Format("companies/{0}/{1}", CompaniesApiVersion, method);
        }

        public JsonObject CreateNewCompany(string company)
        {
            return Call(subpath: "companies", method: "POST", contentType: "application/json", data: company);
        }

        public void UpdateExistingCompany(string companyId, string data)
        {
            var subpath = string.Format("companies/{0}", companyId);
            Call(subpath: subpath, method: "POST", contentType: "application/json", data: data);
        }

        public void ArchiveCompany(string companyId)
        {
            var subpath = string.Format("companies/{0}", companyId);
            Call(subpath: subpath, method: "DELETE");
        }

        public JsonObject GetCompanyById(string companyId)
        {
            var subPath = string.Format("companies/{0}", companyId);
            return Call(subpath: subPath);
        }

        public JsonObject GetContactsOfCompany(string companyId)
        {
            var subPath = string.Format("companies/{0}/contacts", companyId);
            return Call(subpath: subPath);
        }

        public JsonObject GetContactIdsByCompany(string companyId)
        {
            var subPath = string.Format("companies/{0}/vids", companyId);
            return Call(subpath: subPath);
        }
    }
}
