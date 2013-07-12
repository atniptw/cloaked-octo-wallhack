using System;
using System.Json;

namespace HubspotAPIWrapper
{
    public class Prospects : BaseClass
    {
        private const string ProspectsApiVersion = "v1";

        private string GetPath(string method)
        {
            return string.Format("prospects/{0}/{1}", ProspectsApiVersion, method);
        }

        public JsonObject GetProspects(int timeOffset = 0, string orgOffset = "", int limit = 0)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     For a given portal, return information about a specific prospect organization in JSON format.
        /// </summary>
        /// <param name="organization">
        ///     The organization you're requesting prospects from.
        ///     Please Note That if the company that you're looking for contains a space
        ///     in its name, then you need to replace that space with a dash ("-") character.
        ///     URL encoding the space (replacing with a "%20" will not work and return
        ///     404.
        /// </param>
        /// <returns></returns>
        public JsonObject GetProspectInfo(string organization)
        {
            throw new NotImplementedException();
        }

        public JsonObject SearchForProspects(string searchType, string query, int timeOffset = 0, string orgOffset = "")
        {
            throw new NotImplementedException();
        }

        public void HideAProspect(string organization)
        {
            throw new NotImplementedException();
        }

        public JsonObject GetHiddenProspect()
        {
            throw new NotImplementedException();
        }

        public void UnHideAProspect(string organization)
        {
            throw new NotImplementedException();
        }
    }
}