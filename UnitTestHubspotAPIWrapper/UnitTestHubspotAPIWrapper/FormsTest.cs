using NUnit.Framework;
using HubspotAPIWrapper;
using Rhino.Mocks;

namespace UnitTestHubspotAPIWrapper
{
    [TestFixture]
    public class FormsTest
    {
        [Test]
        public void FormsInitializes()
        {
            var target = new Forms(apiKey: Constants.ApiKey);
            Assert.NotNull(target);
        }

        [Test]
        public void FormsGetAllFormsUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.GetAllFormsUrl;

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
            var target = new Forms(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetAllForms();

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void FormsGetFormByIdUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.GetFormByIdUrl;

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
            var target = new Forms(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetFormById("561d9ce9-bb4c-45b4-8e32-21cdeaa3a7f0");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void FormsCreateFormUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.CreateFormUrl;

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
            var target = new Forms(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.CreateForm("");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void FormsUpdateExistingFormUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.UpdateExistingFormUrl;

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
            var target = new Forms(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.UpdateExistingForm("561d9ce9-bb4c-45b4-8e32-21cdeaa3a7f0", "");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void FormsDeleteExistingFormUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.DeleteExistingFormUrl;

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
            var target = new Forms(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.DeleteExistingForm("b409d881-7bc3-4d8b-ad7a-cebe188f27b0");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void FormsGetAllFieldsFromFormUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.GetAllFieldsFromFormUrl;

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
            var target = new Forms(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetAllFieldsFromForm("78c2891f-ebdd-44c0-bd94-15c012bbbfbf");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void FormsGetFieldFromFormUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.GetFieldFromFormUrl;

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
            var target = new Forms(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetFieldFromForm("561d9ce9-bb4c-45b4-8e32-21cdeaa3a7f0", "email");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }
    }
}