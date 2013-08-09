using System;
using NUnit.Framework;
using HubspotAPIWrapper;
using Rhino.Mocks;

namespace UnitTestHubspotAPIWrapper
{
    [TestFixture]
    public class EmailTest
    {
        [Test]
        public void EmailInitializes()
        {
            var target = new Email(apiKey: Constants.ApiKey);
            Assert.NotNull(target);
        }

        [Test]
        public void EmailGetEmailSubscriptionTypesUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.GetEmailSubscriptionTypesUrl;

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything  // data
                               ))
                .Return(string.Empty);

            // Act
            var target = new Email(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetEmailSubscriptionTypes();

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void EmailViewSubscriptionStatusUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.ViewSubscriptionStatusUrl;

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything  // data
                               ))
                .Return(string.Empty);

            // Act
            var target = new Email(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.ViewSubscriptionStatus();

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void EmailUpdateSubscriptionStatusUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.UpdateSubscriptionStatusUrl;

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything  // data
                               ))
                .Return(string.Empty);

            // Act
            var target = new Email(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.UpdateSubscriptionStatus();

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }
    }
}
