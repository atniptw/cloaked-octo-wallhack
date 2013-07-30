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
    }
}
