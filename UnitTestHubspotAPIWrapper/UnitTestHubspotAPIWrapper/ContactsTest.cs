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
            string expectedUrl = Constants.ArchiveContactUrl;

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything // data
                               )).Return(string.Empty);

            // Act
            var target = new Contacts(apiKey: Constants.ApiKey)
                {
                    UserWebClient = mockDataSource
                };
            target.ArchiveContact(contactId: "61571");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actaulUrl => actaulUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ConstantsArchiveContactRequestFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            string expectedUrl = Constants.ArchiveContactUrl;

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything // data
                               )).Return(string.Empty);

            // Act
            var target = new Contacts(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.ArchiveContact(contactId: "61571");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actaulUrl => actaulUrl == expectedUrl),
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
            string expectedUrl = Constants.CreateNewContactUrl;

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything // data
                               ))
                .Return(string.Empty);

            // Act
            var target = new Contacts(apiKey: Constants.ApiKey)
                {
                    UserWebClient = mockDataSource
                };
            target.CreateNewContact(string.Empty);

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Matches(actaulMethod => actaulMethod == "POST"),
                contentType: Arg<string>.Matches(actualContentType => actualContentType == "application/json"),
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsCreateNewContactUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            string expectedUrl = Constants.CreateNewContactUrl;

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything // data
                               ))
                .Return(string.Empty);

            // Act
            var target = new Contacts(apiKey: Constants.ApiKey)
                {
                    UserWebClient = mockDataSource
                };
            target.CreateNewContact(string.Empty);

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
            string expectedUrl = Constants.UpdateExistingContactUrl;

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
            target.UpdateExistingContact("61571", string.Empty);

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Matches(actaulMethod => actaulMethod == "POST"),
                contentType: Arg<string>.Matches(actualContentType => actualContentType == "application/json"),
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsUpdateExistingContactUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            string expectedUrl = Constants.UpdateExistingContactUrl;

            // Arrange
            mockDataSource
                .Stub(x => x.UploadString(
                    Arg<string>.Is.Anything, // uri
                    Arg<string>.Is.Anything, // method
                    Arg<string>.Is.Anything, // content-type
                    Arg<string>.Is.Anything // data
                               ))
                .Return(string.Empty);

            // Act
            var target = new Contacts(apiKey: Constants.ApiKey)
                {
                    UserWebClient = mockDataSource
                };
            target.UpdateExistingContact("61571", string.Empty);

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsGetAllContactsUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            string expectedUrl = Constants.GetAllContactsUrl;

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
            var target = new Contacts(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetAllContacts();

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsGetRecentlyUpdatedContactsUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            string expectedUrl = Constants.GetRecentlyUpdatedContactsUrl;

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
            var target = new Contacts(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetRecentlyUpdatedContacts();

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsGetContactByIdUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            string expectedUrl = Constants.GetContactByIdUrl;

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
            var target = new Contacts(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetContactById("61571");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsGetContactByEmailAddressUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            string expectedUrl = Constants.GetContactByEmailAddressUrl;

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
            var target = new Contacts(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetContactByEmailAddress("testingapis@hubspot.com");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsGetContactByUterTokenUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            string expectedUrl = Constants.GetContactByUserTokenUrl;

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
            var target = new Contacts(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetContactByUserToken("f844d2217850188692f2610c717c2e9b");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }
    }
}