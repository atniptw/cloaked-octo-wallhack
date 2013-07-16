using System;
using System.Json;
using HubspotAPIWrapper;
using NUnit.Framework;
using Rhino.Mocks;

namespace UnitTestHubspotAPIWrapper
{
    [TestFixture]
    public class ProspectsTest
    {
        [Test]
        public void ProspectGetHiddenProspect()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data =
                @"[{""organization"": """",""createdAt"": 1320769730},{""organization"": ""someorg"",""createdAt"": 1322620588},{""organization"": ""amerisuites"",""createdAt"": 1323315431},{""organization"": ""marriott"",""createdAt"": 1323315517}]";
            var expected = new JsonObject(JsonValue.Parse(data));

            mockDataSource.Expect(
                x =>
                x.UploadString(
                    string.Format(
                        "https://api.hubapi.com/prospects/v1/filters?access_token=demooooo-oooo-oooo-oooo-oooooooooooo"),
                    method: "GET"))
                          .Return(data);

            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo")
                {
                    UserWebClient = mockDataSource
                };
            JsonObject result = target.GetHiddenProspect();

            mockDataSource.VerifyAllExpectations();
            Assert.AreEqual(expected.ToString(), result.ToString());
        }

        [Test]
        public
        void ProspectUnHideAProspect()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data = "";

            mockDataSource.Expect(
                x =>
                x.UploadString(
                    string.Format(
                        "https://api.hubapi.com/prospects/v1/filters?access_token=demooooo-oooo-oooo-oooo-oooooooooooo"),
                    method: "DELETE", contentType: "application/x-www-form-urlencoded", data: "marriott%20hotel"))
                          .Return(data);

            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo")
                {
                    UserWebClient = mockDataSource
                };

            target.UnHideAProspect("marriott hotel");
            mockDataSource.VerifyAllExpectations();
        }

        [Test]
        public void ProspectsClassInitializes()
        {
            var target = new BaseClass(apiKey: "demo");
            Assert.IsNotNull(target);
        }

        [Test]
        public void ProspectsGetProspectInfo()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data =
                @"{""summary"":{""slug"":""prnewswire"",""organization"":""PRNEWSWIRE"",""page-views"": 39,""visitors"": 4,""timestamp"": 1322509090,""city"": ""JERSEY CITY"",""region"": ""NEW JERSEY"",""country"": ""UNITED STATES"",""url"": ""PRNEWSWIRE.COM"",""leads"": 0,""longitude"": -74.077644,""latitude"": 40.728157,""ip-address"": ""205.217.162.54"",""touches"": [{""keyword"": ""hugs50 hubspot"",""keyword-engine"": ""google"",""child-id"": ""300291""}]},""activities"": []}";
            var expected = new JsonObject(JsonValue.Parse(data));

            mockDataSource.Expect(
                x =>
                x.UploadString(
                    string.Format(
                        "https://api.hubapi.com/prospects/v1/timeline/PRNEWSWIRE?access_token=demooooo-oooo-oooo-oooo-oooooooooooo"),
                    method: "GET"))
                          .Return(data);

            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo")
                {
                    UserWebClient = mockDataSource
                };
            JsonObject result = target.GetProspectInfo("PRNEWSWIRE");

            mockDataSource.VerifyAllExpectations();
            Assert.AreEqual(expected.ToString(), result.ToString());
        }

        [Test]
        public void ProspectsGetProspects()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data =
                @"{""prospects"": [{""slug"":""private-ip-address-lan"",""organization"":""PRIVATE IP ADDRESS LAN"",""page-views"":250,""visitors"":209,""timestamp"":1323307908,""city"":"""",""region"":"""",""country"":"""",""url"":"""",""leads"":209,""longitude"":0,""latitude"":0,""ip-address"":""10.101.61.104"",""touches"": []}]}";
            var expected = new JsonObject(JsonValue.Parse(data));

            mockDataSource.Expect(
                x =>
                x.UploadString(
                    string.Format(
                        "https://api.hubapi.com/prospects/v1/timeline?access_token=demooooo-oooo-oooo-oooo-oooooooooooo"),
                    method: "GET"))
                          .Return(data);

            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo")
                {
                    UserWebClient = mockDataSource
                };
            JsonObject result = target.GetProspects();

            mockDataSource.VerifyAllExpectations();
            Assert.AreEqual(expected.ToString(), result.ToString());
        }

        [Test]
        public
        void ProspectsHideAProspect()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data = "";

            mockDataSource.Expect(
                x =>
                x.UploadString(
                    string.Format(
                        "https://api.hubapi.com/prospects/v1/filters?access_token=demooooo-oooo-oooo-oooo-oooooooooooo"),
                    method: "POST", contentType: "application/x-www-form-urlencoded", data: "marriott%20hotel"))
                          .Return(data);


            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo")
                {
                    UserWebClient = mockDataSource
                };
            target.HideAProspect("marriott hotel");
            mockDataSource.VerifyAllExpectations();
        }

        [Test]
        public void ProspectsSearchForProspects()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data =
                @"{""prospects"": [{""slug"":""massachusetts-institute-of-technology"",""organization"":""MASSACHUSETTS INSTITUTE OF TECHNOLOGY"",""page-views"":1,""visitors"":1,""timestamp"":1323019070,""city"":""CAMBRIDGE"",""region"":""MASSACHUSETTS"",""country"":""UNITED STATES"",""url"":""MIT.EDU"",""leads"":0,""longitude"":-71.10965,""latitude"":42.37264,""ip-address"":""18.111.22.242"",""touches"": [{""domain"":""docs.hubapi.com"",""child-id"":""167755""}]}],""has-more"":false,""org-offset"":""microsoft"",""time-offset"":1311275888}";
            var expected = new JsonObject(JsonValue.Parse(data));

            mockDataSource.Expect(
                x =>
                x.UploadString(
                    string.Format(
                        "https://api.hubapi.com/prospects/v1/search/city?access_token=demooooo-oooo-oooo-oooo-oooooooooooo&q=Cambridge"),
                    method: "GET")).Return(data);

            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo")
                {
                    UserWebClient = mockDataSource
                };
            JsonObject result = target.SearchForProspects("city", "Cambridge");

            mockDataSource.VerifyAllExpectations();
            Assert.AreEqual(expected.ToString(), result.ToString());
        }

        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Need both Time Offset and Organization Offset")]
        public void ProspectGetProspectsWithTimeOffsetOnlyShouldFail()
        {
            var expect = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo");
            expect.GetProspects(timeOffset: "1371402323000");

        }

        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Need both Time Offset and Organization Offset")]
        public void ProspectGetProspectsWithOrgOffsetOnlyShouldFail()
        {
            var expect = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo");
            expect.GetProspects(orgOffset: "FDCSERVERS.NET");

        }

        [Test]
        public void ProspectGetProspectsWithOffset()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data =
                @"{""prospects"": [{""slug"":""private-ip-address-lan"",""organization"":""PRIVATE IP ADDRESS LAN"",""page-views"":250,""visitors"":209,""timestamp"":1323307908,""city"":"""",""region"":"""",""country"":"""",""url"":"""",""leads"":209,""longitude"":0,""latitude"":0,""ip-address"":""10.101.61.104"",""touches"": []}]}";
            var expected = new JsonObject(JsonValue.Parse(data));

            mockDataSource.Expect(
                x =>
                x.UploadString(
                    string.Format(
                        "https://api.hubapi.com/prospects/v1/timeline?access_token=demooooo-oooo-oooo-oooo-oooooooooooo&timeOffset=1371402323000&orgOffset=FDCSERVERS.NET"),
                    method: "GET"))
                          .Return(data);

            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo")
            {
                UserWebClient = mockDataSource
            };
            JsonObject result = target.GetProspects(timeOffset: "1371402323000", orgOffset: "FDCSERVERS.NET");

            mockDataSource.VerifyAllExpectations();
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
    }
}