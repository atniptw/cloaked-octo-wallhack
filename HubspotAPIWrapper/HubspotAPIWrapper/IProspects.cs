using System;
using System.Collections.Generic;
using System.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubspotAPIWrapper
{
    interface IProspects
    {
        JsonObject GetProspects(string timeOffset = "", string orgOffset = "");
        JsonObject GetProspectInfo(string organization);
        JsonObject SearchForProspects(string searchType, string query, string timeOffset = "", string orgOffset = "");
        void HideAProspect(string organization);
        JsonObject GetHiddenProspect();
        void UnHideAProspect(string organization);
    }
}
