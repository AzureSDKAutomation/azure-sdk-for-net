// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PrivateEndpointConnectionsOperations operations.
    /// </summary>
    public partial interface IPrivateEndpointConnectionsOperations
    {
        /// <summary>
        /// Gets the specified private endpoint connection associated with the
        /// storage sync service.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// The name of the storage sync service name within the specified
        /// resource group.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection associated with the
        /// Storage Account
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> GetWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update the state of specified private endpoint connection
        /// associated with the storage sync service.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// The name of the storage sync service name within the specified
        /// resource group.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection associated with the
        /// Storage Account
        /// </param>
        /// <param name='properties'>
        /// The private endpoint connection properties.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> CreateWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string privateEndpointConnectionName, PrivateEndpointConnection properties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified private endpoint connection associated with
        /// the storage sync service.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// The name of the storage sync service name within the specified
        /// resource group.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection associated with the
        /// Storage Account
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a PrivateEndpointConnection List.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<PrivateEndpointConnection>,PrivateEndpointConnectionsListByStorageSyncServiceHeaders>> ListByStorageSyncServiceWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
