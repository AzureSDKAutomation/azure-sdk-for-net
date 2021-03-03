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
    /// HybridLinksOperations operations.
    /// </summary>
    public partial interface IHybridLinksOperations
    {
        /// <summary>
        /// Gets a list of hybrid links in instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
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
        Task<AzureOperationResponse<IPage<HybridLink>>> ListByInstanceWithHttpMessagesAsync(string resourceGroupName, string managedInstanceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a hybrid link for the given distributed availability group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='distributedAvailabilityGroupName'>
        /// The distributed availability group name.
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
        Task<AzureOperationResponse<HybridLink>> GetWithHttpMessagesAsync(string resourceGroupName, string managedInstanceName, string distributedAvailabilityGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a hybrid link between box and Sql Managed Instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='distributedAvailabilityGroupName'>
        /// The distributed availability group name.
        /// </param>
        /// <param name='parameters'>
        /// The hybrid link info.
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
        Task<AzureOperationResponse<HybridLink>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string managedInstanceName, string distributedAvailabilityGroupName, HybridLink parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Drops a hybrid link between box and Sql Managed Instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='distributedAvailabilityGroupName'>
        /// The distributed availability group name.
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
        Task<AzureOperationResponse<HybridLink>> DeleteWithHttpMessagesAsync(string resourceGroupName, string managedInstanceName, string distributedAvailabilityGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a hybrid link between box and Sql Managed Instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='distributedAvailabilityGroupName'>
        /// The distributed availability group name.
        /// </param>
        /// <param name='parameters'>
        /// The hybrid link info.
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
        Task<AzureOperationResponse<HybridLink>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string managedInstanceName, string distributedAvailabilityGroupName, HybridLink parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Drops a hybrid link between box and Sql Managed Instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='distributedAvailabilityGroupName'>
        /// The distributed availability group name.
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
        Task<AzureOperationResponse<HybridLink>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string managedInstanceName, string distributedAvailabilityGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of hybrid links in instance.
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
        Task<AzureOperationResponse<IPage<HybridLink>>> ListByInstanceNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
