using HubspotAPIWrapper;
using NUnit.Framework;
using Rhino.Mocks;

namespace UnitTestHubspotAPIWrapper
{
    [TestFixture]
    public class ContactsTest
    {
        [Test]
        public void ConstantsArchiveContactUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            string data = Constants.ArchiveContactResponse;
            string expectedUrl = Constants.ArchiveContactUrl;

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything // data
                               )).Return(data);

            // Act
            var target = new Contacts(apiKey: Constants.ApiKey)
                {
                    UserWebClient = mockDataSource
                };
            target.ArchiveContact(contactId: "61571");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actaulUrl => actaulUrl == Constants.ArchiveContactUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ConstantsArchiveContactRequestFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            string data = Constants.ArchiveContactResponse;
            string expectedUrl = Constants.ArchiveContactUrl;

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything // data
                               )).Return(data);

            // Act
            var target = new Contacts(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.ArchiveContact(contactId: "61571");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actaulUrl => actaulUrl == Constants.ArchiveContactUrl),
                method: Arg<string>.Matches(actaulMethod => actaulMethod == "DELETE"),
                contentType: Arg<string>.Matches(actualContentType => actualContentType == "application/text"),
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsClassInitializes()
        {
            var target = new Contacts(apiKey: Constants.ApiKey);
            Assert.NotNull(target);
        }

        [Test]
        public void ContactsCreateNewContactRequestFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            string data = Constants.CreateNewContactResponse;
            string expectedUrl = Constants.CreateNewContactUrl;

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
            var target = new Contacts(apiKey: Constants.ApiKey)
                {
                    UserWebClient = mockDataSource
                };
            target.CreateNewContact(Constants.CreateNewContactBody);

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Matches(actaulMethod => actaulMethod == "POST"),
                contentType: Arg<string>.Matches(actualContentType => actualContentType == "application/json"),
                data: Arg<string>.Matches(actualData => actualData == Constants.CreateNewContactBody)));
        }

        [Test]
        public void ContactsCreateNewContactUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            string data = Constants.CreateNewContactResponse;
            string expectedUrl = Constants.CreateNewContactUrl;

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
            var target = new Contacts(apiKey: Constants.ApiKey)
                {
                    UserWebClient = mockDataSource
                };
            target.CreateNewContact(Constants.CreateNewContactBody);

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsUpdateExistingContactRequestFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            string expectedUrl = Constants.UpdateExistingContact;

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything // data
                               ))
                .Return("");

            // Act
            var target = new Contacts(apiKey: Constants.ApiKey)
                {
                    UserWebClient = mockDataSource
                };
            target.UpdateExistingContact("61571", Constants.CreateNewContactBody);

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Matches(actaulMethod => actaulMethod == "POST"),
                contentType: Arg<string>.Matches(actualContentType => actualContentType == "application/json"),
                data: Arg<string>.Matches(actualData => actualData == Constants.CreateNewContactBody)));
        }

        [Test]
        public void ContactsUpdateExistingContactUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            string data = Constants.CreateNewContactResponse;
            string expectedUrl = Constants.UpdateExistingContact;

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
            var target = new Contacts(apiKey: Constants.ApiKey)
                {
                    UserWebClient = mockDataSource
                };
            target.UpdateExistingContact("61571", Constants.CreateNewContactBody);

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }
    }
}