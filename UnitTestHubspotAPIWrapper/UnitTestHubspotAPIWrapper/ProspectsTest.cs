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
        public void GetProspects()
        {
            
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var target = new Prospects();
            target.WebClient = mockDataSource;
            const string data = @"{""prospects"": [{""slug"":""private-ip-address-lan"",""organization"":""PRIVATE IP ADDRESS LAN"",""page-views"":250,""visitors"":209,""timestamp"":1323307908,""city"":"""",""region"":"""",""country"":"""",""url"":"""",""leads"":209,""longitude"":0,""latitude"":0,""ip-address"":""10.101.61.104"",""touches"": []}]}";
            
            
            mockDataSource.Expect(x => x.GetWebResponse()).Return(data);



            

        }
    }
}

}