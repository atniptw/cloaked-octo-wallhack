using System;
using System.Json;

namespace HubspotAPIWrapper
{
    public class ContactProperty : BaseClass
    {

        private const string ContactListsApiVersion = "v1";

        public ContactProperty(string apiKey = null, string accessToken = null, string refreshToken = null,
                                string clientId = null)
            : base(apiKey, accessToken, refreshToken, clientId)
        {
        }

        protected override string GetPath(string method)
        {
            return string.Format("contacts/{0}/{1}", ContactListsApiVersion, method);
        }

        public JsonObject GetAllProperties()
        {
            return Call(subpath: "properties");
        }

        public JsonObject CreateNewCustomProperty(string property, string data)
        {
            var subpath = string.Format("properties/{0}", property);
            return Call(subpath: subpath, method: "PUT", contentType: " application/json", data: data);
        }

        public JsonObject UpdateExistingProperty(string property, string data)
        {
            var subpath = string.Format("properties/{0}", property);
            return Call(subpath: subpath, method: "POST", contentType: " application/json", data: data);
        }

        public JsonObject DeleteProperty(string property)
        {
            var subpath = string.Format("properties/{0}", property);
            return Call(subpath: subpath, method: "DELETE");
        }

        public JsonObject GetContactPropertyGroup(string groupName = "")
        {
            string subpath = groupName.Length > 0 ? string.Format("groups/{0}", groupName) : "groups";
            return Call(subpath: subpath);
        }

        public JsonObject CreateContactPropertyGroup(string groupName, string properties = "")
        {
            string subpath = string.Format("groups/{0}", groupName);
            return Call(subpath: subpath, method: "PUT", data: properties, contentType: "application/json");
        }

        public JsonObject UpdateContactPropertyGroup(string groupName, string properties = "")
        {
            string subpath = string.Format("groups/{0}", groupName);
            return Call(subpath: subpath, method: "POST", data: properties, contentType: "application/json");
        }

        public JsonObject DeleteContactPropertyGroup(string groupName)
        {
            string subpath = string.Format("groups/{0}", groupName);
            return Call(subpath: subpath, method: "DELETE");
        }
    }
}