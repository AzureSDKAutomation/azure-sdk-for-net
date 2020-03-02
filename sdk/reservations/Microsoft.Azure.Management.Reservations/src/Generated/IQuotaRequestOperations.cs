// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// QuotaRequestOperations operations.
    /// </summary>
    public partial interface IQuotaRequestOperations
    {
        /// <summary>
        /// Submits a Quota Request for a resource provider at the specified
        /// location for the specific resource in the parameter.
        /// </summary>
        /// <remarks>
        /// Submits Quota change request for a resource provider for the
        /// specified location for the specific resource in the parameter. To
        /// use, first make a Get request to get quota information for the
        /// specific resource. This information consists of information
        /// regarding that specific resources. For the specific resource, if it
        /// requires an update to the quota, update the limit field in the
        /// response from the Get request to the new value of quota. Then,
        /// submit this updated JSON object to this quota request API. This
        /// will update the quota to the value specified. The location header
        /// in the response will be used to track the status of the quota
        /// request. Please check the provisioningState field in the response.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// Azure subscription id.
        /// </param>
        /// <param name='providerId'>
        /// Azure resource Provider id.
        /// </param>
        /// <param name='location'>
        /// Azure region.
        /// </param>
        /// <param name='resourceName'>
        /// The Resource name for the specific resource provider, such as SKU
        /// name for Microsoft.Compute, pool for Microsoft.Batch.
        /// </param>
        /// <param name='createQuotaRequest'>
        /// Quota requests payload.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Entity. ETag should match the current entity state from
        /// the header response of the GET request or it should be * for
        /// unconditional update.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ExceptionResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<object>> CreateWithHttpMessagesAsync(string subscriptionId, string providerId, string location, string resourceName, CurrentQuotaLimitBase createQuotaRequest, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Submits a Quota Request for a resource provider at the specified
        /// location for the specific resource in the parameter.
        /// </summary>
        /// <remarks>
        /// Submits Quota change request for a resource provider for the
        /// specified location for the specific resource in the parameter. To
        /// use, first make a Get request to get quota information for the
        /// specific resource. This information consists of information
        /// regarding that specific resources. For the specific resource, if it
        /// requires an update to the quota, update the limit field in the
        /// response from the Get request to the new value of quota. Then,
        /// submit this updated JSON object to this quota request API. This
        /// will update the quota to the value specified. The location header
        /// in the response will be used to track the status of the quota
        /// request. Please check the provisioningState field in the response.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// Azure subscription id.
        /// </param>
        /// <param name='providerId'>
        /// Azure resource Provider id.
        /// </param>
        /// <param name='location'>
        /// Azure region.
        /// </param>
        /// <param name='resourceName'>
        /// The Resource name for the specific resource provider, such as SKU
        /// name for Microsoft.Compute, pool for Microsoft.Batch.
        /// </param>
        /// <param name='createQuotaRequest'>
        /// Quota requests payload.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Entity. ETag should match the current entity state from
        /// the header response of the GET request or it should be * for
        /// unconditional update.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ExceptionResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<object>> UpdateWithHttpMessagesAsync(string subscriptionId, string providerId, string location, string resourceName, CurrentQuotaLimitBase createQuotaRequest, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Submits a Quota Request for a resource provider at the specified
        /// location for the specific resource in the parameter.
        /// </summary>
        /// <remarks>
        /// Submits Quota change request for a resource provider for the
        /// specified location for the specific resource in the parameter. To
        /// use, first make a Get request to get quota information for the
        /// specific resource. This information consists of information
        /// regarding that specific resources. For the specific resource, if it
        /// requires an update to the quota, update the limit field in the
        /// response from the Get request to the new value of quota. Then,
        /// submit this updated JSON object to this quota request API. This
        /// will update the quota to the value specified. The location header
        /// in the response will be used to track the status of the quota
        /// request. Please check the provisioningState field in the response.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// Azure subscription id.
        /// </param>
        /// <param name='providerId'>
        /// Azure resource Provider id.
        /// </param>
        /// <param name='location'>
        /// Azure region.
        /// </param>
        /// <param name='resourceName'>
        /// The Resource name for the specific resource provider, such as SKU
        /// name for Microsoft.Compute, pool for Microsoft.Batch.
        /// </param>
        /// <param name='createQuotaRequest'>
        /// Quota requests payload.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Entity. ETag should match the current entity state from
        /// the header response of the GET request or it should be * for
        /// unconditional update.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ExceptionResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<object>> BeginCreateWithHttpMessagesAsync(string subscriptionId, string providerId, string location, string resourceName, CurrentQuotaLimitBase createQuotaRequest, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Submits a Quota Request for a resource provider at the specified
        /// location for the specific resource in the parameter.
        /// </summary>
        /// <remarks>
        /// Submits Quota change request for a resource provider for the
        /// specified location for the specific resource in the parameter. To
        /// use, first make a Get request to get quota information for the
        /// specific resource. This information consists of information
        /// regarding that specific resources. For the specific resource, if it
        /// requires an update to the quota, update the limit field in the
        /// response from the Get request to the new value of quota. Then,
        /// submit this updated JSON object to this quota request API. This
        /// will update the quota to the value specified. The location header
        /// in the response will be used to track the status of the quota
        /// request. Please check the provisioningState field in the response.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// Azure subscription id.
        /// </param>
        /// <param name='providerId'>
        /// Azure resource Provider id.
        /// </param>
        /// <param name='location'>
        /// Azure region.
        /// </param>
        /// <param name='resourceName'>
        /// The Resource name for the specific resource provider, such as SKU
        /// name for Microsoft.Compute, pool for Microsoft.Batch.
        /// </param>
        /// <param name='createQuotaRequest'>
        /// Quota requests payload.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Entity. ETag should match the current entity state from
        /// the header response of the GET request or it should be * for
        /// unconditional update.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ExceptionResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<object>> BeginUpdateWithHttpMessagesAsync(string subscriptionId, string providerId, string location, string resourceName, CurrentQuotaLimitBase createQuotaRequest, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
