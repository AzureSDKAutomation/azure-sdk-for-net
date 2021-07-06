// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// SubscriptionsOperations operations.
    /// </summary>
    public partial interface ISubscriptionsOperations
    {
        /// <summary>
        /// Retrieves the subscription's current quota information in a
        /// particular region.
        /// </summary>
        /// <param name='location'>
        /// The region to which the request is sent. You can find out which
        /// regions Azure Stream Analytics is supported in here:
        /// https://azure.microsoft.com/en-us/regions/
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SubscriptionQuotasListResult>> ListQuotasWithHttpMessagesAsync(string location, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test the Stream Analytics query on a sample input.
        /// </summary>
        /// <param name='testQuery'>
        /// The query testing object that defines the input, output, and
        /// transformation for the query testing.
        /// </param>
        /// <param name='location'>
        /// The region to which the request is sent. You can find out which
        /// regions Azure Stream Analytics is supported in here:
        /// https://azure.microsoft.com/en-us/regions/
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<QueryTestingResult>> TestQueryMethodWithHttpMessagesAsync(TestQuery testQuery, string location, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Compile the Stream Analytics query.
        /// </summary>
        /// <param name='compileQuery'>
        /// The query compilation object which defines the input, output, and
        /// transformation for the query compilation.
        /// </param>
        /// <param name='location'>
        /// The region to which the request is sent. You can find out which
        /// regions Azure Stream Analytics is supported in here:
        /// https://azure.microsoft.com/en-us/regions/
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<QueryCompilationResult>> CompileQueryMethodWithHttpMessagesAsync(CompileQuery compileQuery, string location, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sample the Stream Analytics input data.
        /// </summary>
        /// <param name='sampleInput'>
        /// Defines the necessary parameters for sampling the Stream Analytics
        /// input data.
        /// </param>
        /// <param name='location'>
        /// The region to which the request is sent. You can find out which
        /// regions Azure Stream Analytics is supported in here:
        /// https://azure.microsoft.com/en-us/regions/
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SampleInputResult>> SampleInputMethodWithHttpMessagesAsync(SampleInput sampleInput, string location, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test the Stream Analytics input.
        /// </summary>
        /// <param name='testInput'>
        /// Defines the necessary parameters for testing the Stream Analytics
        /// input.
        /// </param>
        /// <param name='location'>
        /// The region to which the request is sent. You can find out which
        /// regions Azure Stream Analytics is supported in here:
        /// https://azure.microsoft.com/en-us/regions/
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<TestDatasourceResult>> TestInputMethodWithHttpMessagesAsync(TestInput testInput, string location, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test the Stream Analytics output.
        /// </summary>
        /// <param name='testOutput'>
        /// Defines the necessary parameters for testing the Stream Analytics
        /// output.
        /// </param>
        /// <param name='location'>
        /// The region to which the request is sent. You can find out which
        /// regions Azure Stream Analytics is supported in here:
        /// https://azure.microsoft.com/en-us/regions/
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<TestDatasourceResult>> TestOutputMethodWithHttpMessagesAsync(TestOutput testOutput, string location, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test the Stream Analytics query on a sample input.
        /// </summary>
        /// <param name='testQuery'>
        /// The query testing object that defines the input, output, and
        /// transformation for the query testing.
        /// </param>
        /// <param name='location'>
        /// The region to which the request is sent. You can find out which
        /// regions Azure Stream Analytics is supported in here:
        /// https://azure.microsoft.com/en-us/regions/
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<QueryTestingResult>> BeginTestQueryMethodWithHttpMessagesAsync(TestQuery testQuery, string location, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sample the Stream Analytics input data.
        /// </summary>
        /// <param name='sampleInput'>
        /// Defines the necessary parameters for sampling the Stream Analytics
        /// input data.
        /// </param>
        /// <param name='location'>
        /// The region to which the request is sent. You can find out which
        /// regions Azure Stream Analytics is supported in here:
        /// https://azure.microsoft.com/en-us/regions/
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SampleInputResult>> BeginSampleInputMethodWithHttpMessagesAsync(SampleInput sampleInput, string location, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test the Stream Analytics input.
        /// </summary>
        /// <param name='testInput'>
        /// Defines the necessary parameters for testing the Stream Analytics
        /// input.
        /// </param>
        /// <param name='location'>
        /// The region to which the request is sent. You can find out which
        /// regions Azure Stream Analytics is supported in here:
        /// https://azure.microsoft.com/en-us/regions/
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<TestDatasourceResult>> BeginTestInputMethodWithHttpMessagesAsync(TestInput testInput, string location, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test the Stream Analytics output.
        /// </summary>
        /// <param name='testOutput'>
        /// Defines the necessary parameters for testing the Stream Analytics
        /// output.
        /// </param>
        /// <param name='location'>
        /// The region to which the request is sent. You can find out which
        /// regions Azure Stream Analytics is supported in here:
        /// https://azure.microsoft.com/en-us/regions/
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<TestDatasourceResult>> BeginTestOutputMethodWithHttpMessagesAsync(TestOutput testOutput, string location, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
