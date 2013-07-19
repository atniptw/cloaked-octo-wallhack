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
        public void ProspectGetHiddenProspectUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data =
                @"[{""organization"": """",""createdAt"": 1320769730},{""organization"": ""someorg"",""createdAt"": 1322620588},{""organization"": ""amerisuites"",""createdAt"": 1323315431},{""organization"": ""marriott"",""createdAt"": 1323315517}]";
            var expected = new JsonObject(JsonValue.Parse(data));
            const string expectedUrl =
                "https://api.hubapi.com/prospects/v1/filters?access_token=demooooo-oooo-oooo-oooo-oooooooooooo";

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything // data
                               ))
                .Return(data);

            // Act
            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo")
                {
                    UserWebClient = mockDataSource
                };
            JsonObject result = target.GetHiddenProspect();


            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                Arg<string>.Is.Anything,
                Arg<string>.Is.Anything,
                Arg<string>.Is.Anything));
        }


        [Test]
        public void ProspectGetProspectsWithOffsetUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data =
                @"{""prospects"": [{""slug"":""private-ip-address-lan"",""organization"":""PRIVATE IP ADDRESS LAN"",""page-views"":250,""visitors"":209,""timestamp"":1323307908,""city"":"""",""region"":"""",""country"":"""",""url"":"""",""leads"":209,""longitude"":0,""latitude"":0,""ip-address"":""10.101.61.104"",""touches"": []}]}";
            var expected = new JsonObject(JsonValue.Parse(data));
            const string expectedUrl =
                "https://api.hubapi.com/prospects/v1/timeline?access_token=demooooo-oooo-oooo-oooo-oooooooooooo&timeOffset=1371402323000&orgOffset=FDCSERVERS.NET";

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything // data
                               ))
                .Return(data);

            // Act
            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo")
                {
                    UserWebClient = mockDataSource
                };
            target.GetProspects(timeOffset: "1371402323000", orgOffset: "FDCSERVERS.NET");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                Arg<string>.Is.Anything,
                Arg<string>.Is.Anything,
                Arg<string>.Is.Anything));
        }

        [Test]
        [ExpectedException(typeof (ArgumentException), ExpectedMessage = "Need both Time Offset and Organization Offset"
            )]
        public void ProspectGetProspectsWithOrgOffsetOnlyShouldFail()
        {
            var expect = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo");
            expect.GetProspects(orgOffset: "FDCSERVERS.NET");
        }

        [Test]
        [ExpectedException(typeof (ArgumentException), ExpectedMessage = "Need both Time Offset and Organization Offset"
            )]
        public void ProspectGetProspectsWithTimeOffsetOnlyShouldFail()
        {
            var expect = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo");
            expect.GetProspects(timeOffset: "1371402323000");
        }

        [Test]
        public
        void ProspectUnHideAProspectUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data = "";
            const string expectedUrl =
                "https://api.hubapi.com/prospects/v1/filters?access_token=demooooo-oooo-oooo-oooo-oooooooooooo";

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything // data
                               ))
                .Return(data);

            // Act
            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo")
                {
                    UserWebClient = mockDataSource
                };

            target.UnHideAProspect("marriott hotel");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                Arg<string>.Is.Anything,
                Arg<string>.Is.Anything,
                Arg<string>.Is.Anything));
        }

        [Test]
        public void ProspectsClassInitializes()
        {
            var target = new BaseClass(apiKey: "demo");
            Assert.IsNotNull(target);
        }

        [Test]
        public void ProspectsGetProspectInfoRequestIsFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data =
                @"{""summary"":{""slug"":""prnewswire"",""organization"":""PRNEWSWIRE"",""page-views"": 39,""visitors"": 4,""timestamp"": 1322509090,""city"": ""JERSEY CITY"",""region"": ""NEW JERSEY"",""country"": ""UNITED STATES"",""url"": ""PRNEWSWIRE.COM"",""leads"": 0,""longitude"": -74.077644,""latitude"": 40.728157,""ip-address"": ""205.217.162.54"",""touches"": [{""keyword"": ""hugs50 hubspot"",""keyword-engine"": ""google"",""child-id"": ""300291""}]},""activities"": []}";
            const string expectedUrl =
                "https://api.hubapi.com/prospects/v1/timeline/PRNEWSWIRE?access_token=demooooo-oooo-oooo-oooo-oooooooooooo";

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything // data
                               ))
                .Return(data);


            // Act
            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo")
                {
                    UserWebClient = mockDataSource
                };
            target.GetProspectInfo("PRNEWSWIRE");


            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                Arg<string>.Is.Anything,
                Arg<string>.Is.Anything,
                Arg<string>.Is.Anything));
        }

        [Test]
        public void ProspectsGetProspectsRequestIsFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data =
                @"{""prospects"": [{""slug"":""private-ip-address-lan"",""organization"":""PRIVATE IP ADDRESS LAN"",""page-views"":250,""visitors"":209,""timestamp"":1323307908,""city"":"""",""region"":"""",""country"":"""",""url"":"""",""leads"":209,""longitude"":0,""latitude"":0,""ip-address"":""10.101.61.104"",""touches"": []}]}";
            var expected = new JsonObject(JsonValue.Parse(data));
            const string expectedUrl =
                "https://api.hubapi.com/prospects/v1/timeline?access_token=demooooo-oooo-oooo-oooo-oooooooooooo";

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything // data
                               ))
                .Return(data);


            // Act
            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo")
                {
                    UserWebClient = mockDataSource
                };
            target.GetProspects();


            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                Arg<string>.Is.Anything,
                Arg<string>.Is.Anything,
                Arg<string>.Is.Anything));
        }

        [Test]
        public void ProspectsGetProspectsUrlPassesDataBackCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data =
                @"{""prospects"": [{""slug"":""private-ip-address-lan"",""organization"":""PRIVATE IP ADDRESS LAN"",""page-views"":250,""visitors"":209,""timestamp"":1323307908,""city"":"""",""region"":"""",""country"":"""",""url"":"""",""leads"":209,""longitude"":0,""latitude"":0,""ip-address"":""10.101.61.104"",""touches"": []}]}";


            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything // data
                               ))
                .Return(data);


            // Act
            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo")
                {
                    UserWebClient = mockDataSource
                };
            JsonObject result = target.GetProspects();


            // Assert
            Assert.AreEqual(250, (int) result["prospects"][0]["page-views"]);
            Assert.AreEqual("PRIVATE IP ADDRESS LAN", (string) result["prospects"][0]["organization"]);
        }

        [Test]
        public
        void ProspectsHideAProspectRequestIsFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data = "";
            const string expectedUrl =
                "https://api.hubapi.com/prospects/v1/filters?access_token=demooooo-oooo-oooo-oooo-oooooooooooo";


            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything // data
                               ))
                .Return(data);

            // Act
            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo")
                {
                    UserWebClient = mockDataSource
                };

            target.HideAProspect("marriott hotel");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                Arg<string>.Matches(actualMethod => actualMethod == "POST"),
                Arg<string>.Matches(actualContentType => actualContentType == "application/x-www-form-urlencoded"),
                Arg<string>.Matches(actaulData => actaulData == "marriott%20hotel")));
        }

        [Test]
        public void ProspectsSearchForProspectsRequestIsFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data =
                @"{""prospects"": [{""slug"":""massachusetts-institute-of-technology"",""organization"":""MASSACHUSETTS INSTITUTE OF TECHNOLOGY"",""page-views"":1,""visitors"":1,""timestamp"":1323019070,""city"":""CAMBRIDGE"",""region"":""MASSACHUSETTS"",""country"":""UNITED STATES"",""url"":""MIT.EDU"",""leads"":0,""longitude"":-71.10965,""latitude"":42.37264,""ip-address"":""18.111.22.242"",""touches"": [{""domain"":""docs.hubapi.com"",""child-id"":""167755""}]}],""has-more"":false,""org-offset"":""microsoft"",""time-offset"":1311275888}";
            const string expectedUrl =
                "https://api.hubapi.com/prospects/v1/search/city?access_token=demooooo-oooo-oooo-oooo-oooooooooooo&q=Cambridge";

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything // data
                               ))
                .Return(data);


            // Act
            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo")
                {
                    UserWebClient = mockDataSource
                };
            target.SearchForProspects("city", "Cambridge");


            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                Arg<string>.Is.Anything,
                Arg<string>.Is.Anything,
                Arg<string>.Is.Anything));
        }
    }
}