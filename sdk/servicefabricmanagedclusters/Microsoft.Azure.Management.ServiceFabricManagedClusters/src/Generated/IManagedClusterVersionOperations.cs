// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ManagedClusterVersionOperations operations.
    /// </summary>
    public partial interface IManagedClusterVersionOperations
    {
        /// <summary>
        /// Gets information about a Service Fabric managed cluster code
        /// version available in the specified location.
        /// </summary>
        /// <remarks>
        /// Gets information about an available Service Fabric managed cluster
        /// code version.
        /// </remarks>
        /// <param name='location'>
        /// The location for the cluster code versions. This is different from
        /// cluster location.
        /// </param>
        /// <param name='clusterVersion'>
        /// The cluster code version.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ManagedClusterCodeVersionResult>> GetWithHttpMessagesAsync(string location, string clusterVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets information about a Service Fabric cluster code version
        /// available for the specified environment.
        /// </summary>
        /// <remarks>
        /// Gets information about an available Service Fabric cluster code
        /// version by environment.
        /// </remarks>
        /// <param name='location'>
        /// The location for the cluster code versions. This is different from
        /// cluster location.
        /// </param>
        /// <param name='clusterVersion'>
        /// The cluster code version.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ManagedClusterCodeVersionResult>> GetByEnvironmentWithHttpMessagesAsync(string location, string clusterVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of Service Fabric cluster code versions available for
        /// the specified location.
        /// </summary>
        /// <remarks>
        /// Gets all available code versions for Service Fabric cluster
        /// resources by location.
        /// </remarks>
        /// <param name='location'>
        /// The location for the cluster code versions. This is different from
        /// cluster location.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ManagedClusterCodeVersionListResult>> ListWithHttpMessagesAsync(string location, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of Service Fabric cluster code versions available for
        /// the specified environment.
        /// </summary>
        /// <remarks>
        /// Gets all available code versions for Service Fabric cluster
        /// resources by environment.
        /// </remarks>
        /// <param name='location'>
        /// The location for the cluster code versions. This is different from
        /// cluster location.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ManagedClusterCodeVersionListResult>> ListByEnvironmentWithHttpMessagesAsync(string location, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
