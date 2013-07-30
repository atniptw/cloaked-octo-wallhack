namespace UnitTestHubspotAPIWrapper
{
    public class Constants
    {
        public static string ListHiddenProspects =
            @"[{""organization"": """",""createdAt"": 1320769730},{""organization"": ""someorg"",""createdAt"": 1322620588},{""organization"": ""amerisuites"",""createdAt"": 1323315431},{""organization"": ""marriott"",""createdAt"": 1323315517}]";

        public static string ListHiddenProspectsUrl =
            "https://api.hubapi.com/prospects/v1/filters?access_token=demooooo-oooo-oooo-oooo-oooooooooooo";

        public static string AccessToken = "demooooo-oooo-oooo-oooo-oooooooooooo";

        public static string GetProspectWithTimeOffsetUrl =
            "https://api.hubapi.com/prospects/v1/timeline?access_token=demooooo-oooo-oooo-oooo-oooooooooooo&timeOffset=1371402323000&orgOffset=FDCSERVERS.NET";

        public static string GetProspectsResponse =
            @"{""prospects"": [{""slug"":""private-ip-address-lan"",""organization"":""PRIVATE IP ADDRESS LAN"",""page-views"":250,""visitors"":209,""timestamp"":1323307908,""city"":"""",""region"":"""",""country"":"""",""url"":"""",""leads"":209,""longitude"":0,""latitude"":0,""ip-address"":""10.101.61.104"",""touches"": []}]}";

        public static string TimeOffset = "1371402323000";
        public static string OrgOffset = "FDCSERVERS.NET";

        public static string UnHideAProspectUrl =
            "https://api.hubapi.com/prospects/v1/filters?access_token=demooooo-oooo-oooo-oooo-oooooooooooo";

        public static string ProspectOrganization = "marriott hotel";
        public static string ApiKey = "demo";

        public static string GetProspectInfoResponse =
            @"{""summary"":{""slug"":""prnewswire"",""organization"":""PRNEWSWIRE"",""page-views"": 39,""visitors"": 4,""timestamp"": 1322509090,""city"": ""JERSEY CITY"",""region"": ""NEW JERSEY"",""country"": ""UNITED STATES"",""url"": ""PRNEWSWIRE.COM"",""leads"": 0,""longitude"": -74.077644,""latitude"": 40.728157,""ip-address"": ""205.217.162.54"",""touches"": [{""keyword"": ""hugs50 hubspot"",""keyword-engine"": ""google"",""child-id"": ""300291""}]},""activities"": []}";

        public static string GetProspectInfoUrl =
            "https://api.hubapi.com/prospects/v1/timeline/PRNEWSWIRE?access_token=demooooo-oooo-oooo-oooo-oooooooooooo";

        public static string ProspectInfoOrganization = "PRNEWSWIRE";

        public static string GetProspectUrl =
            "https://api.hubapi.com/prospects/v1/timeline?access_token=demooooo-oooo-oooo-oooo-oooooooooooo";

        public static string SearchForProspectsUrl =
            "https://api.hubapi.com/prospects/v1/search/city?access_token=demooooo-oooo-oooo-oooo-oooooooooooo&q=Cambridge";

        public static string SearchForProspectsResponse =
            @"{""prospects"": [{""slug"":""massachusetts-institute-of-technology"",""organization"":""MASSACHUSETTS INSTITUTE OF TECHNOLOGY"",""page-views"":1,""visitors"":1,""timestamp"":1323019070,""city"":""CAMBRIDGE"",""region"":""MASSACHUSETTS"",""country"":""UNITED STATES"",""url"":""MIT.EDU"",""leads"":0,""longitude"":-71.10965,""latitude"":42.37264,""ip-address"":""18.111.22.242"",""touches"": [{""domain"":""docs.hubapi.com"",""child-id"":""167755""}]}],""has-more"":false,""org-offset"":""microsoft"",""time-offset"":1311275888}";

        public static string CreateNewContactResponse =
            @"{""form-submissions"":[""ADD ME""],""identity-profiles"":[{""identities"": [{""timestamp"":1331075050646,""type"":""EMAIL"",""value"":""fumanchu@hubspot.com""},{""timestamp"":1331075050681,""type"": ""LEAD_GUID"",""value"": ""22a26060-c9d7-44b0-9f07-aa40488cfa3a""}],""vid"": 61574}],""properties"": {""website"":{""value"": ""http: //hubspot.com"",""versions"": [{""timestamp"": 1331075050646,""selected"": false,""source-label"": null,""value"": ""http: //hubspot.com"",""source-type"": ""API"",""source-id"": null}]},""city"": {""value"": ""Cambridge"",""versions"": [{""timestamp"": 1331075050646,""selected"": false,""source-label"": null,""value"": ""Cambridge"",""source-type"": ""API"",""source-id"": null}]},""firstname"":{""value"":""Adrian"",""versions"":[{""timestamp"":1331075050646,""selected"":false,""source-label"":null,""value"":""Adrian"",""source-type"":""API"",""source-id"":null}]},""zip"": {""value"": ""02139"",""versions"":[{""timestamp"":1331075050646,""selected"": false,""source-label"": null,""value"": ""02139"",""source-type"": ""API"",""source-id"": null}]},""lastname"": {""value"": ""Mott"",""versions"": [{""timestamp"":1331075050646,""selected"": false,""source-label"":null,""value"": ""Mott"",""source-type"": ""API"",""source-id"": null}]},""company"": {""value"":""HubSpot"",""versions"":[{""timestamp"":1331075050646,""selected"":false,""source-label"":null,""value"":""HubSpot"",""source-type"":""API"",""source-id"":null}]},""phone"":{""value"": ""555-122-2323"",""versions"":[{""timestamp"": 1331075050646,""selected"": false,""source-label"": null,""value"": ""555-122-2323"",""source-type"": ""API"",""source-id"": null}]},""state"": {""value"": ""MA"",""versions"": [{""timestamp"":1331075050646,""selected"":false,""source-label"": null,""value"":""MA"",""source-type"": ""API"",""source-id"": null}]},""address"":{""value"":""25FirstStreet"",""versions"": [{""timestamp"": 1331075050646,""selected"": false,""source-label"": null,""value"": ""25FirstStreet"",""source-type"":""API"",""source-id"":null}]},""email"":{""value"":""fumanchu@hubspot.com"",""versions"":[{""timestamp"":1331075050646,""selected"": false,""source-label"": null,""value"":""fumanchu @hubspot.com"",""source-type"": ""API"",""source-id"":null}]}},""vid"": 61574}";

        public static string CreateNewContactUrl = "https://api.hubapi.com/contacts/v1/contact?hapikey=demo";

        public static string CreateNewContactBody =
            @"{""properties"":[{""property"": ""email"",""value"": ""testingapis@hubspot.com""},{""property"": ""firstname"",""value"": ""Adrian""},{""property"": ""lastname"",""value"": ""Mott""},{""property"": ""website"",""value"": ""http://hubspot.com""},{""property"": ""company"",""value"": ""HubSpot""},{""property"": ""phone"",""value"": ""555-122-2323""},{""property"": ""address"",""value"": ""25 First Street""},{""property"": ""city"",""value"": ""Cambridge""},{""property"": ""state"",""value"": ""MA""},{""property"": ""zip"",""value"": ""02139""}]}";

        public static string UpdateExistingContact = "https://api.hubapi.com/contacts/v1/contact/vid/61571/profile?hapikey=demo";
        public static string ArchiveContactResponse = @"{""deleted"": true,""vid"":61571}";
        public static string ArchiveContactUrl = "https://api.hubapi.com/contacts/v1/contact/vid/61571?hapikey=demo";
    }
}