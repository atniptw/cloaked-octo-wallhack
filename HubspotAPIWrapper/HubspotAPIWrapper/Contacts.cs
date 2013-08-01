using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Json;

namespace HubspotAPIWrapper
{
    public class Contacts : BaseClass
    {
        protected object ProspectsApiVersion = "v1";

        public Contacts(string apiKey = null, string accessToken = null, string refreshToken = null,
                 string clientId = null) : base(apiKey, accessToken, refreshToken, clientId)
        {
        }

        protected override string GetPath(string method)
        {
            return string.Format("contacts/{0}/{1}", ProspectsApiVersion, method);
        }

        public JsonObject CreateNewContact(string contact)
        {
            return Call(subpath: "contact", method: "POST", contentType: "application/json", data: contact);
        }

        public void UpdateExistingContact(string contactId, string data)
        {
            var subpath = string.Format("contact/vid/{0}/profile", contactId);
            Call(subpath: subpath, method: "POST", contentType: "application/json", data: data);
        }

        public void ArchiveContact(string contactId)
        {
            var subpath = string.Format("contact/vid/{0}", contactId);
            Call(subpath: subpath, method: "DELETE");
        }

        public JsonObject GetAllContacts(string count = "", string property = "", string contactOffset = "")
        {
            var optionalParams = new Dictionary<string, string>();
            if (count.Length > 0)
            {
                optionalParams["count"] = count;
            }
            if (property.Length > 0)
            {
                optionalParams["property"] = property;
            }
            if (count.Length > 0)
            {
                optionalParams["vidOffset"] = contactOffset;
            }

            return Call(subpath: "lists/all/contacts/all", optionalParams: optionalParams);
        }

        public JsonObject GetRecentlyUpdatedContacts(string count = "", string timeOffset = "", string contactOffset = "")
        {
            var optionalParams = new Dictionary<string, string>();
            if (count.Length > 0)
            {
                optionalParams["count"] = count;
            }
            if (timeOffset.Length > 0)
            {
                optionalParams["timeOffset"] = timeOffset;
            }
            if (count.Length > 0)
            {
                optionalParams["vidOffset"] = contactOffset;
            }

            return Call(subpath: "lists/recently_updated/contacts/recent", optionalParams: optionalParams);
        }

        public JsonObject GetContactById(string contactId)
        {
            var subPath = string.Format("contact/vid/{0}/profile", contactId);
            return Call(subpath: subPath);
        }

        public JsonObject GetContactByEmailAddress(string emailAddress)
        {
            var subPath = string.Format("contact/email/{0}/profile", emailAddress);
            return Call(subpath: subPath);
        }

        public JsonObject GetContactByUserToken(string token)
        {
            var subPath = string.Format("contact/utk/{0}/profile", token);
            return Call(subpath: subPath);
        }

        public JsonObject SearchContacts(string query, string count = "", string offset = "")
        {
            var optionalParams = new Dictionary<string, string>();
            if (count.Length > 0)
            {
                optionalParams["count"] = count;
            }
            if (offset.Length > 0)
            {
                optionalParams["offset"] = offset;
            }
            return Call(subpath: "search/query", query: query, optionalParams: optionalParams);
        }

        public JsonObject GetContactStatistics()
        {
            return Call(subpath: "contacts/statistics");
        }
    }
}
