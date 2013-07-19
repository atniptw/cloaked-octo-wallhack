using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubspotAPIWrapper
{
    interface IBaseClass
    {
        IWebClient UserWebClient { get; set; }
    }
}
