using HubspotAPIWrapper;
using NUnit.Framework;
using Rhino.Mocks;


namespace UnitTestHubspotAPIWrapper
{
    [TestFixture]
    public class ContactListsTest
    {
        [Test]
        public void ContactListsInitializes()
        {
            var target = new ContactLists(apiKey: Constants.ApiKey);
            Assert.NotNull(target);
        }

        [Test]
        public void ContactsListsCreateNewListUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.CreateNewContactListUrl;

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
            var target = new ContactLists(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.CreateContactList(string.Empty);

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsListsCreateNewListRequestFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.CreateNewContactListUrl;

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
            var target = new ContactLists(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.CreateContactList(string.Empty);

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Matches(actaulMethed => actaulMethed == "POST"),
                contentType: Arg<string>.Matches(actaulcontentType => actaulcontentType == "application/json"),
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsListsUpdateContactListUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.UpdateContactListUrl;

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
            var target = new ContactLists(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.UpdateContactList("2", string.Empty);

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsListsUpdateContactListREquestFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.UpdateContactListUrl;

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
            var target = new ContactLists(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.UpdateContactList("2", string.Empty);

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Matches(actaulMethed => actaulMethed == "POST"),
                contentType: Arg<string>.Matches(actaulcontentType => actaulcontentType == "application/json"),
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsListsDeleteContactListUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.DeleteContactListUrl;

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
            var target = new ContactLists(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.DeleteContactList("2");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsListsDeleteContactListREquestFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.DeleteContactListUrl;

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
            var target = new ContactLists(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.DeleteContactList("2");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                                method: Arg<string>.Matches(actaulMethed => actaulMethed == "DELETE"),
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsListsGetlContactListByIdUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.GetContactListByIdtUrl;

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
            var target = new ContactLists(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetContactListById("2");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsListsGetContactListsUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.GetContactListstUrl;

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
            var target = new ContactLists(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetContactLists();

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsListsGetBatchContactListsUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.GetBatchContactListstUrl;

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
            var target = new ContactLists(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetBatchContactLists("2", "3", "4", "5");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsListsGetStaticContactListsUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.GetStaticContactListstUrl;

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
            var target = new ContactLists(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetStaticContactLists();

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void ContactsListsGetDynamicContactListsUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.GetDynamicContactListstUrl;

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
            var target = new ContactLists(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetDynamicContactLists();

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }
    }
}
