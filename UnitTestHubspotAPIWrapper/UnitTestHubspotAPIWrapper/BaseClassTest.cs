using System;
using NUnit.Framework;
using HubspotAPIWrapper;

namespace UnitTestHubspotAPIWrapper
{
    [TestFixture]
    public class BaseClassTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Missing required credentials")]
        public void BaseClassErrorsWithNoArguments()
        {
            var expected = new BaseClass();
        }

        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Cannot use both api_key and access_token")]
        public void BaseClassErrorsWhenKeyAndTokenSpecified()
        {
            var expected = new BaseClass(apiKey: "demo", accessToken: "demooooo-oooo-oooo-oooo-oooooooooooo");
        }
    }
}
