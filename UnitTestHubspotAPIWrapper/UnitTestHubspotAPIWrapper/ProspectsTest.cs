using System.Json;
using System.Web.Script.Serialization;
using HubspotAPIWrapper;
using NUnit.Framework;
using Rhino.Mocks;

namespace UnitTestHubspotAPIWrapper
{
    [TestFixture]
    public class ProspectsTest
    {
        
        [Test]
        public void ProspectsClassInitializes()
        {
            var target = new BaseClass(apiKey: "demo");
            Assert.IsNotNull(target);
        }

        [Test]
        public void ProspectsGetProspectsSinleProspect()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data = @"{""prospects"": [{""slug"":""private-ip-address-lan"",""organization"":""PRIVATE IP ADDRESS LAN"",""page-views"":250,""visitors"":209,""timestamp"":1323307908,""city"":"""",""region"":"""",""country"":"""",""url"":"""",""leads"":209,""longitude"":0,""latitude"":0,""ip-address"":""10.101.61.104"",""touches"": []}]}";
            var expected = new JsonObject(JsonValue.Parse(data));

            mockDataSource.Expect(x => x.GetWebResponse(string.Format("https://api.hubapi.com/prospects/v1/timeline?access_token=demooooo-oooo-oooo-oooo-oooooooooooo"))).Return(data);

            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo") { UserWebClient = mockDataSource };
            var result = target.GetProspects();

            mockDataSource.VerifyAllExpectations();
            Assert.AreEqual(expected.ToString(), result.ToString());
        }

        [Test]
        public void ProspectsGetProspectInfo()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            const string data = @"{""summary"":{""slug"":""prnewswire"",""organization"":""PRNEWSWIRE"",""page-views"": 39,""visitors"": 4,""timestamp"": 1322509090,""city"": ""JERSEY CITY"",""region"": ""NEW JERSEY"",""country"": ""UNITED STATES"",""url"": ""PRNEWSWIRE.COM"",""leads"": 0,""longitude"": -74.077644,""latitude"": 40.728157,""ip-address"": ""205.217.162.54"",""touches"": [{""keyword"": ""hugs50 hubspot"",""keyword-engine"": ""google"",""child-id"": ""300291""}]},""activities"": []}";
            var expected = new JsonObject(JsonValue.Parse(data));

            mockDataSource.Expect(x => x.GetWebResponse(string.Format("https://api.hubapi.com/prospects/v1/timeline/PRNEWSWIRE?access_token=demooooo-oooo-oooo-oooo-oooooooooooo"))).Return(data);

            var target = new Prospects(accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo") { UserWebClient = mockDataSource };
            var result = target.GetProspectInfo("PRNEWSWIRE");

            mockDataSource.VerifyAllExpectations();
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
    }
}