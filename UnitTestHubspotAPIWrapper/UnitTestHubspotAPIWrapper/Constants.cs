namespace UnitTestHubspotAPIWrapper
{
    public class Constants
    {
        public static string ListHiddenProspectsUrl =
            "https://api.hubapi.com/prospects/v1/filters?access_token=demooooo-oooo-oooo-oooo-oooooooooooo";

        public static string AccessToken = "demooooo-oooo-oooo-oooo-oooooooooooo";

        public static string GetProspectWithTimeOffsetUrl =
            "https://api.hubapi.com/prospects/v1/timeline?access_token=demooooo-oooo-oooo-oooo-oooooooooooo&timeOffset=1371402323000&orgOffset=FDCSERVERS.NET";

        public static string TimeOffset = "1371402323000";
        public static string OrgOffset = "FDCSERVERS.NET";

        public static string UnHideAProspectUrl =
            "https://api.hubapi.com/prospects/v1/filters?access_token=demooooo-oooo-oooo-oooo-oooooooooooo";

        public static string ProspectOrganization = "marriott hotel";
        public static string ApiKey = "demo";

        public static string GetProspectInfoUrl =
            "https://api.hubapi.com/prospects/v1/timeline/PRNEWSWIRE?access_token=demooooo-oooo-oooo-oooo-oooooooooooo";

        public static string ProspectInfoOrganization = "PRNEWSWIRE";

        public static string GetProspectUrl =
            "https://api.hubapi.com/prospects/v1/timeline?access_token=demooooo-oooo-oooo-oooo-oooooooooooo";

        public static string SearchForProspectsUrl =
            "https://api.hubapi.com/prospects/v1/search/city?access_token=demooooo-oooo-oooo-oooo-oooooooooooo&q=Cambridge";

        public static string CreateNewContactUrl = "https://api.hubapi.com/contacts/v1/contact?hapikey=demo";

        public static string UpdateExistingContactUrl =
            "https://api.hubapi.com/contacts/v1/contact/vid/61571/profile?hapikey=demo";

        public static string ArchiveContactUrl = "https://api.hubapi.com/contacts/v1/contact/vid/61571?hapikey=demo";

        public static string GetAllContactsUrl =
            "https://api.hubapi.com/contacts/v1/lists/all/contacts/all?hapikey=demo";

        public static string GetRecentlyUpdatedContactsUrl =
            "https://api.hubapi.com/contacts/v1/lists/recently_updated/contacts/recent?hapikey=demo";

        public static string GetContactByIdUrl =
            "https://api.hubapi.com/contacts/v1/contact/vid/61571/profile?hapikey=demo";

        public static string GetContactByEmailAddressUrl =
            "https://api.hubapi.com/contacts/v1/contact/email/testingapis@hubspot.com/profile?hapikey=demo";

        public static string GetContactByUserTokenUrl =
            "https://api.hubapi.com/contacts/v1/contact/utk/f844d2217850188692f2610c717c2e9b/profile?hapikey=demo";

        public static string SearchContactsUrl =
            "https://api.hubapi.com/contacts/v1/search/query?hapikey=demo&q=example";

        public static string GetContactStatisticsUrl =
            "https://api.hubapi.com/contacts/v1/contacts/statistics?hapikey=demo";

        public static string CreateNewContactListUrl = "https://api.hubapi.com/contacts/v1/lists?hapikey=demo";
        public static string UpdateContactListUrl = "https://api.hubapi.com/contacts/v1/lists/2?hapikey=demo";
        public static string DeleteContactListUrl = "https://api.hubapi.com/contacts/v1/lists/2?hapikey=demo";
        public static string GetContactListByIdtUrl = "https://api.hubapi.com/contacts/v1/lists/2?hapikey=demo";
        public static string GetContactListstUrl = "https://api.hubapi.com/contacts/v1/lists?hapikey=demo";

        public static string GetBatchContactListstUrl =
            "https://api.hubapi.com/contacts/v1/lists/batch?hapikey=demo&listId=2&listId=3&listId=4&listId=5&";

        public static string GetStaticContactListstUrl = "https://api.hubapi.com/contacts/v1/lists/static?hapikey=demo";

        public static string GetDynamicContactListstUrl =
            "https://api.hubapi.com/contacts/v1/lists/dynamic?hapikey=demo";

        public static string GetContactsInListstUrl =
            "https://api.hubapi.com/contacts/v1/lists/1/contacts/all?hapikey=demo";

        public static string GetRecentlyAddedContactsInListstUrl =
            "https://api.hubapi.com/contacts/v1/lists/1/contacts/recent?hapikey=demo";

        public static string RefreshExistingContactListtUrl =
            "https://api.hubapi.com/contacts/v1/lists/2/refresh?hapikey=demo";

        public static string AddExistingContactToListUrl = "https://api.hubapi.com/contacts/v1/lists/2/add?hapikey=demo";
        public static string RemoveExistingContactFromListUrl = "https://api.hubapi.com/contacts/v1/lists/2/remove?hapikey=demo";
    }
}