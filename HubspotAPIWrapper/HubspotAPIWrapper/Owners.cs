using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Json;

namespace HubspotAPIWrapper
{
    public class Owners : BaseClass
    {
        protected object OwnersApiVersion = "v2";

        public Owners(string apiKey = null, string accessToken = null, string refreshToken = null,
                 string clientId = null) : base(apiKey, accessToken, refreshToken, clientId)
        {
        }

        protected override string GetPath(string method)
        {
            return string.Format("owners/{0}/{1}", OwnersApiVersion, method);
        }

        public JsonObject GetAllOwners(bool includeInactive = false)
        {
            var optionalParams = new Dictionary<string, string>();
            
            optionalParams["includeInactive"] = includeInactive.ToString();
            
            return Call(subpath: "owners/", optionalParams: optionalParams);
        }

        public JsonObject GetOwnerByEmail(string email)
        {
            var optionalParams = new Dictionary<string, string>();

            optionalParams["email"] = email;

            return Call(subpath: "owners/", optionalParams: optionalParams);
        }

        public JsonObject CreateNewOwner(string owner)
        {
            return Call(subpath: "owners/", method: "POST", contentType: "application/json", data: owner);
        }

        public void UpdateExistingOwner(string ownerId, string data)
        {
            var subpath = string.Format("owners/{0}", ownerId);
            Call(subpath: subpath, method: "POST", contentType: "application/json", data: data);
        }

        public JsonObject ArchiveOwner(string ownerId)
        {
            var subPath = string.Format("owners/{0}/", ownerId);
            return Call(subpath: subPath);
        }

    }
}
