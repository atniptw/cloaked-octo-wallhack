using System;
using System.Json;

namespace HubspotAPIWrapper
{
    public class Workflows : BaseClass
    {

        private const string ProspectsApiVersion = "v2";

        public Workflows(string apiKey = null, string accessToken = null, string refreshToken = null,
                         string clientId = null)
            : base(apiKey, accessToken, refreshToken, clientId)
        {
        }

        protected override string GetPath(string method)
        {
            return string.Format("automation/{0}/{1}", ProspectsApiVersion, method);
        }

        public JsonObject GetAllWorkFlows()
        {
            return Call(subpath: "workflows");
        }

        public JsonObject GetWorkflowById(string workflowId)
        {
            var subpath = string.Format("workflows/{0}", workflowId);
            return Call(subpath: subpath);
        }

        public JsonObject EnrollContactIntoWorkflow(string workflowId, string contactEmail)
        {
            var subpath = string.Format("workflows/{0}/enrollments/contacts/{1}", workflowId, contactEmail);
            return Call(subpath: subpath, method: "POST");
        }

        public JsonObject RemoveContactFromWorkflow(string workflowId, string contactEmail)
        {
            var subpath = string.Format("workflows/{0}/enrollments/contacts/{1}", workflowId, contactEmail);
            return Call(subpath: subpath, method: "DELETE");
        }

        public JsonObject GetCurrentEnrollment()
        {
            throw new NotImplementedException();
        }

        public JsonObject LogEvents()
        {
            throw new NotImplementedException();
        }

        public JsonObject UpcomingEvents()
        {
            throw new NotImplementedException();
        }
    }
}