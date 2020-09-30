// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WorkloadMonitor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// MonitorHistoricalStateChangeOperations operations.
    /// </summary>
    public partial interface IMonitorHistoricalStateChangeOperations
    {
        /// <summary>
        /// Get the status of a monitor at a specific timestamp in history.
        /// </summary>
        /// <param name='subscriptionId'>
        /// The subscriptionId of the resource
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resourceGroupName of the resource
        /// </param>
        /// <param name='resourceNamespace'>
        /// The resourceNamespace of the resource
        /// </param>
        /// <param name='resourceType'>
        /// The resourceType of the resource
        /// </param>
        /// <param name='resourceName'>
        /// The resourceType of the resource
        /// </param>
        /// <param name='monitorId'>
        /// The monitorId of the resource (url encoded)
        /// </param>
        /// <param name='timestampUnix'>
        /// The timestamp of the state change (Unix format)
        /// </param>
        /// <param name='expand'>
        /// ex: $expand=evidence,configuration
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<MonitorStateChange>> GetWithHttpMessagesAsync(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, string monitorId, string timestampUnix, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
