using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Json;

namespace HubspotAPIWrapper
{
    public class Forms : BaseClass
    {
                private const string ProspectsApiVersion = "v1";

        public Forms(string apiKey = null, string accessToken = null, string refreshToken = null,
                         string clientId = null) : base(apiKey, accessToken, refreshToken, clientId)
        {
        }

        protected override string GetPath(string method)
        {
            return string.Format("contacts/{0}/{1}", ProspectsApiVersion, method);
        }
        public JsonObject SubmitFormData()
        {
            throw new NotImplementedException();
        }

        public JsonObject GetAllForms()
        {
            return Call(subpath: "forms");
        }

        public JsonObject GetFormById(string formGuId)
        {
            var subpath = string.Format("forms/{0}", formGuId);
            return Call(subpath: subpath);
        }

        public JsonObject CreateForm(string data)
        {
            return Call(subpath: "forms", method: "POST", contentType: "application/json", data: data);
        }

        public JsonObject UpdateExistingForm(string formGuId, string data)
        {
            var subpath = string.Format("forms/{0}", formGuId);
            return Call(subpath: subpath, method: "POST", contentType: "application/json", data: data);
        }

        public JsonObject DeleteExistingForm(string formGuId)
        {
            var subpath = string.Format("forms/{0}", formGuId);
            return Call(subpath: subpath, method: "DELETE");
        }

        public JsonObject GetAllFieldsFromForm(string formGuId)
        {
            var subpath = string.Format("fields/{0}", formGuId);
            return Call(subpath: subpath);
        }

        public JsonObject GetFieldFromForm(string formGuId, string fieldName)
        {
            var subpath = string.Format("fields/{0}/{1}", formGuId, fieldName);
            return Call(subpath: subpath);
        }
    }
}
