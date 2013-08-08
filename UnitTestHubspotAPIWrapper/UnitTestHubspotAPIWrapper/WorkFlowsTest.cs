using HubspotAPIWrapper;
using NUnit.Framework;
using Rhino.Mocks;

namespace UnitTestHubspotAPIWrapper
{
    [TestFixture]
    public class WorkFlowsTest
    {
        [Test]
        public void WorkfLowsInitializes()
        {
            var target = new Workflows(apiKey: Constants.ApiKey);
            Assert.NotNull(target);
        }

        [Test]
        public void WorkflowsGetAllWorkflowsUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.GetAllWorkflowsUrl;

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
            var target = new Workflows(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetAllWorkFlows();

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void WorkflowsGetWorkflowByIdUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.GetWorkflowByIdUrl;

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
            var target = new Workflows(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.GetWorkflowById("8993");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void WorkflowsEnrollContactIntoWorkflowUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.EnrollContactIntoWorkflowUrl;

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
            var target = new Workflows(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.EnrollContactIntoWorkflow("8993", "sample@hubspot.com");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }

        [Test]
        public void WorkflowsRemoveContactFromWorkflowUrlFormedCorrectly()
        {
            var mockDataSource = MockRepository.GenerateMock<IWebClient>();
            var expectedUrl = Constants.RemoveContactFromWorkflowUrl;

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
            var target = new Workflows(apiKey: Constants.ApiKey)
            {
                UserWebClient = mockDataSource
            };
            target.RemoveContactFromWorkflow("8993", "sample@hubspot.com");

            // Assert
            mockDataSource.AssertWasCalled(c => c.UploadString(
                uri: Arg<string>.Matches(actualUrl => actualUrl == expectedUrl),
                method: Arg<string>.Is.Anything,
                contentType: Arg<string>.Is.Anything,
                data: Arg<string>.Is.Anything));
        }


    }
}