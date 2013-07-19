using System;
using System.Collections.Generic;
using System.Json;

namespace HubspotAPIWrapper
{
    public class Prospects : BaseClass, IProspects
    {
        private const string ProspectsApiVersion = "v1";

        public Prospects(string apiKey = null, string accessToken = null, string refreshToken = null,
                         string clientId = null) : base(apiKey, accessToken, refreshToken, clientId)
        {
        }

        protected override string GetPath(string method)
        {
            return string.Format("prospects/{0}/{1}", ProspectsApiVersion, method);
        }

        public JsonObject GetProspects(string timeOffset = "", string orgOffset = "")
        {
            if ((timeOffset.Length > 0 && orgOffset.Length <= 0) || (orgOffset.Length > 0 && timeOffset.Length <= 0))
            {
                throw new ArgumentException("Need both Time Offset and Organization Offset");
            }

            var optionalParams = new Dictionary<string, string>();
            if (timeOffset.Length > 0 && orgOffset.Length > 0)
            {
                optionalParams["timeOffset"] = timeOffset;
                optionalParams["orgOffset"] = orgOffset;
            }
            return Call("timeline", optionalParams: optionalParams);
        }

        /// <summary>
        ///     For a given portal, return information about a specific prospect organization in JSON format.
        /// </summary>
        /// <param name="organization">
        ///     The organization you're requesting prospects from.
        ///     Please Note That if the company that you're looking for contains a space
        ///     in its name, then you need to replace that space with a dash ("-") character.
        ///     URL encoding the space (replacing with a "%20" will not work and return 404).
        /// </param>
        /// <returns></returns>
        public JsonObject GetProspectInfo(string organization)
        {
            return Call(string.Format("timeline/{0}", organization));
        }

        public JsonObject SearchForProspects(string searchType, string query, int timeOffset = 0, string orgOffset = "")
        {
            return Call(string.Format("search/{0}", searchType), query: query);
        }

        public void HideAProspect(string organization)
        {
            Call("filters", method: "POST", contentType: "application/x-www-form-urlencoded", data: organization);
        }

        public JsonObject GetHiddenProspect()
        {
            return Call("filters");
        }

        public void UnHideAProspect(string organization)
        {
            Call("filters", method: "DELETE", contentType: "application/x-www-form-urlencoded", data: organization);
        }
    }
}