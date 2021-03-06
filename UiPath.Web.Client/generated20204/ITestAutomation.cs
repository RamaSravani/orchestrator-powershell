// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// TestAutomation operations.
    /// </summary>
    public partial interface ITestAutomation
    {
        /// <summary>
        /// Start a test set execution.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: TestSetExecutions or
        /// TestSetExecutions.Write.
        ///
        /// Required permissions: TestSetExecutions.Create.
        ///
        /// 200 OK returns test set execution Id
        /// </remarks>
        /// <param name='testSetId'>
        /// The Id of the test set
        /// </param>
        /// <param name='triggerType'>
        /// Specifies how was the execution triggered. Possible values include:
        /// 'Manual', 'Scheduled', 'ExternalTool'
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<long?>> StartTestSetExecutionWithHttpMessagesAsync(long testSetId, string triggerType = default(string), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Start a test set execution with additional options.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: TestSetExecutions or
        /// TestSetExecutions.Write.
        ///
        /// Required permissions: TestSetExecutions.Create.
        ///
        /// 200 OK returns test set execution Id
        /// </remarks>
        /// <param name='testSetId'>
        /// The Id of the test set
        /// </param>
        /// <param name='testSetExecutionOptionsDto'>
        /// Provides options to set the BatchExecutionKey and TriggerType and
        /// override the input parameters for specific test cases
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<long?>> StartTestSetExecutionWithOptionsWithHttpMessagesAsync(long testSetId, TestSetExecutionOptionsDto testSetExecutionOptionsDto, long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Cancels the specified test set execution.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: TestSetExecutions or
        /// TestSetExecutions.Write.
        ///
        /// Required permissions: TestSetExecutions.Edit.
        ///
        /// 202 Accepted
        /// </remarks>
        /// <param name='testSetExecutionId'>
        /// Id for the test set execution to be canceled
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> CancelTestSetExecutionWithHttpMessagesAsync(long testSetExecutionId, long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Cancels the specified test case execution.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: TestSetExecutions or
        /// TestSetExecutions.Write.
        ///
        /// Required permissions: TestSetExecutions.Edit.
        ///
        /// 202 Accepted
        /// </remarks>
        /// <param name='testCaseExecutionId'>
        /// Id for the test case execution to be canceled
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> CancelTestCaseExecutionWithHttpMessagesAsync(long testCaseExecutionId, long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Client Credentials Flow required permissions: TestSetExecutions or
        /// TestSetExecutions.Read.
        ///
        /// Required permissions: TestSetExecutions.View.
        /// </summary>
        /// <param name='testCaseAssertionId'>
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Stream>> GetAssertionScreenshotWithHttpMessagesAsync(long testCaseAssertionId, long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// This will create a test set with source type API.This endpoint it
        /// is supposed to be used by API integration.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: TestSets or
        /// TestSets.Write.
        ///
        /// Required permissions: TestSets.Create.
        ///
        /// 201 Created returns test set Id
        /// </remarks>
        /// <param name='message'>
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<long?>> CreateTestSetForReleaseVersionWithHttpMessagesAsync(BuildTestSetRequestMessage message, long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Client Credentials Flow required permissions: Execution or
        /// Execution.Read.
        ///
        /// Requires authentication.
        /// </summary>
        /// <param name='testCaseUniqueId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<TestPackageInfoDto>> GetPackageInfoByTestCaseUniqueIdWithHttpMessagesAsync(System.Guid testCaseUniqueId, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Client Credentials Flow required permissions: Execution or
        /// Execution.Read.
        ///
        /// Requires authentication.
        /// </summary>
        /// <param name='packageIdentifier'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<TestReleaseVersionDto>>> GetReleasesForPackageVersionWithHttpMessagesAsync(string packageIdentifier, string version, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
