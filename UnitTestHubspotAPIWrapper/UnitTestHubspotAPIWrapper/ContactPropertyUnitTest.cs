using HubspotAPIWrapper;
using NUnit.Framework;
using Rhino.Mocks;

namespace UnitTestHubspotAPIWrapper
{
    [TestFixture]
    public class ContactPropertyUnitTest
    {
        [Test]
        public void ContactPropertyInitializes()
        {
            var target = new ContactProperty(apiKey: Constants.ApiKey);
            Assert.NotNull(target);
        }

        [Test]
        public void ContactPropertyGetAllPropertiesUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.GetAllPropertiesUrl;

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
            var target = new ContactProperty(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetAllProperties();

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactPropertyCreateNewCustomPropertydUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.CreateNewCustomPropertyUrl;

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
            var target = new ContactProperty(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.CreateNewCustomProperty("newcustomproperty", "");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactPropertyUpdateExistingPropertydUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.UpdateExistingPropertyUrl;

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
            var target = new ContactProperty(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.UpdateExistingProperty("originalprop", "");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactPropertyDeletePropertydUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.DeletePropertydUrl;

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
            var target = new ContactProperty(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.DeleteProperty("originalprop");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactPropertyGetContactPropertyGroupUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.GetContactPropertyGroupUrl;

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
            var target = new ContactProperty(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetContactPropertyGroup("contactinformation");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactPropertyCreateContactPropertyGroupUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.CreateContactPropertyGroupUrl;

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
            var target = new ContactProperty(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.CreateContactPropertyGroup("anothercustom");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactPropertyUpdateContactPropertyGroupUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.UpdateContactPropertyGroupUrl;

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
            var target = new ContactProperty(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.UpdateContactPropertyGroup("anothercustom");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactPropertyDeleteContactPropertyGroupUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.DeleteContactPropertyGroupUrl;

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
            var target = new ContactProperty(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.DeleteContactPropertyGroup("anothercustom");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }
    }
}