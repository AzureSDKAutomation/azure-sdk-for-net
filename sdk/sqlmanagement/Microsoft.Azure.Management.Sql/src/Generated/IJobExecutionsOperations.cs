// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// JobExecutionsOperations operations.
    /// </summary>
    public partial interface IJobExecutionsOperations
    {
        /// <summary>
        /// Lists all executions in a job agent.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='jobAgentName'>
        /// The name of the job agent.
        /// </param>
        /// <param name='createTimeMin'>
        /// If specified, only job executions created at or after the specified
        /// time are included.
        /// </param>
        /// <param name='createTimeMax'>
        /// If specified, only job executions created before the specified time
        /// are included.
        /// </param>
        /// <param name='endTimeMin'>
        /// If specified, only job executions completed at or after the
        /// specified time are included.
        /// </param>
        /// <param name='endTimeMax'>
        /// If specified, only job executions completed before the specified
        /// time are included.
        /// </param>
        /// <param name='isActive'>
        /// If specified, only active or only completed job executions are
        /// included.
        /// </param>
        /// <param name='skip'>
        /// The number of elements in the collection to skip.
        /// </param>
        /// <param name='top'>
        /// The number of elements to return from the collection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<JobExecution>>> ListByAgentWithHttpMessagesAsync(string resourceGroupName, string serverName, string jobAgentName, System.DateTime? createTimeMin = default(System.DateTime?), System.DateTime? createTimeMax = default(System.DateTime?), System.DateTime? endTimeMin = default(System.DateTime?), System.DateTime? endTimeMax = default(System.DateTime?), bool? isActive = default(bool?), long? skip = default(long?), long? top = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Requests cancellation of a job execution.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='jobAgentName'>
        /// The name of the job agent.
        /// </param>
        /// <param name='jobName'>
        /// The name of the job.
        /// </param>
        /// <param name='jobExecutionId'>
        /// The id of the job execution to cancel.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> CancelWithHttpMessagesAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, System.Guid jobExecutionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Starts an elastic job execution.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='jobAgentName'>
        /// The name of the job agent.
        /// </param>
        /// <param name='jobName'>
        /// The name of the job to get.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<JobExecution>> CreateWithHttpMessagesAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists a job's executions.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='jobAgentName'>
        /// The name of the job agent.
        /// </param>
        /// <param name='jobName'>
        /// The name of the job to get.
        /// </param>
        /// <param name='createTimeMin'>
        /// If specified, only job executions created at or after the specified
        /// time are included.
        /// </param>
        /// <param name='createTimeMax'>
        /// If specified, only job executions created before the specified time
        /// are included.
        /// </param>
        /// <param name='endTimeMin'>
        /// If specified, only job executions completed at or after the
        /// specified time are included.
        /// </param>
        /// <param name='endTimeMax'>
        /// If specified, only job executions completed before the specified
        /// time are included.
        /// </param>
        /// <param name='isActive'>
        /// If specified, only active or only completed job executions are
        /// included.
        /// </param>
        /// <param name='skip'>
        /// The number of elements in the collection to skip.
        /// </param>
        /// <param name='top'>
        /// The number of elements to return from the collection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<JobExecution>>> ListByJobWithHttpMessagesAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, System.DateTime? createTimeMin = default(System.DateTime?), System.DateTime? createTimeMax = default(System.DateTime?), System.DateTime? endTimeMin = default(System.DateTime?), System.DateTime? endTimeMax = default(System.DateTime?), bool? isActive = default(bool?), long? skip = default(long?), long? top = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a job execution.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='jobAgentName'>
        /// The name of the job agent.
        /// </param>
        /// <param name='jobName'>
        /// The name of the job.
        /// </param>
        /// <param name='jobExecutionId'>
        /// The id of the job execution
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<JobExecution>> GetWithHttpMessagesAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, System.Guid jobExecutionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a job execution.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='jobAgentName'>
        /// The name of the job agent.
        /// </param>
        /// <param name='jobName'>
        /// The name of the job to get.
        /// </param>
        /// <param name='jobExecutionId'>
        /// The job execution id to create the job execution under.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<JobExecution>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, System.Guid jobExecutionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Starts an elastic job execution.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='jobAgentName'>
        /// The name of the job agent.
        /// </param>
        /// <param name='jobName'>
        /// The name of the job to get.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<JobExecution>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a job execution.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='jobAgentName'>
        /// The name of the job agent.
        /// </param>
        /// <param name='jobName'>
        /// The name of the job to get.
        /// </param>
        /// <param name='jobExecutionId'>
        /// The job execution id to create the job execution under.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<JobExecution>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, System.Guid jobExecutionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all executions in a job agent.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<JobExecution>>> ListByAgentNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists a job's executions.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<JobExecution>>> ListByJobNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
