// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityAndCompliance
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PrivateEndpointConnectionsForEDMOperations operations.
    /// </summary>
    public partial interface IPrivateEndpointConnectionsForEDMOperations
    {
        /// <summary>
        /// Lists all private endpoint connections for a service.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the service instance.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the service instance.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PrivateEndpointConnection>>> ListByServiceWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the specified private endpoint connection associated with the
        /// service.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the service instance.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the service instance.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection associated with the
        /// Azure resource
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> GetWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update the state of the specified private endpoint connection
        /// associated with the service.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the service instance.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the service instance.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection associated with the
        /// Azure resource
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
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, PrivateEndpointConnection properties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a private endpoint connection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the service instance.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the service instance.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection associated with the
        /// Azure resource
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update the state of the specified private endpoint connection
        /// associated with the service.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the service instance.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the service instance.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection associated with the
        /// Azure resource
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
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, PrivateEndpointConnection properties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a private endpoint connection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the service instance.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the service instance.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection associated with the
        /// Azure resource
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all private endpoint connections for a service.
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
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PrivateEndpointConnection>>> ListByServiceNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
