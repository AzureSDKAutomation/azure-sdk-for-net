// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// SkusOperations operations.
    /// </summary>
    public partial interface ISkusOperations
    {
        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// </summary>
        /// <param name='providerNamespace'>
        /// The name of the resource provider hosted within ProviderHub.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='sku'>
        /// The SKU.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SkuResource>> GetWithHttpMessagesAsync(string providerNamespace, string resourceType, string sku, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates the resource type skus in the given resource
        /// type.
        /// </summary>
        /// <param name='providerNamespace'>
        /// The name of the resource provider hosted within ProviderHub.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='sku'>
        /// The SKU.
        /// </param>
        /// <param name='properties'>
        /// The required body parameters supplied to the resource sku
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SkuResource>> CreateOrUpdateWithHttpMessagesAsync(string providerNamespace, string resourceType, string sku, ResourceTypeSku properties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a resource type sku.
        /// </summary>
        /// <param name='providerNamespace'>
        /// The name of the resource provider hosted within ProviderHub.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='sku'>
        /// The SKU.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string providerNamespace, string resourceType, string sku, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// </summary>
        /// <param name='providerNamespace'>
        /// The name of the resource provider hosted within ProviderHub.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='nestedResourceTypeFirst'>
        /// The first child resource type.
        /// </param>
        /// <param name='sku'>
        /// The SKU.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SkuResource>> GetNestedResourceTypeFirstWithHttpMessagesAsync(string providerNamespace, string resourceType, string nestedResourceTypeFirst, string sku, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates the resource type skus in the given resource
        /// type.
        /// </summary>
        /// <param name='providerNamespace'>
        /// The name of the resource provider hosted within ProviderHub.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='nestedResourceTypeFirst'>
        /// The first child resource type.
        /// </param>
        /// <param name='sku'>
        /// The SKU.
        /// </param>
        /// <param name='properties'>
        /// The required body parameters supplied to the resource sku
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SkuResource>> CreateOrUpdateNestedResourceTypeFirstWithHttpMessagesAsync(string providerNamespace, string resourceType, string nestedResourceTypeFirst, string sku, ResourceTypeSku properties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a resource type sku.
        /// </summary>
        /// <param name='providerNamespace'>
        /// The name of the resource provider hosted within ProviderHub.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='nestedResourceTypeFirst'>
        /// The first child resource type.
        /// </param>
        /// <param name='sku'>
        /// The SKU.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteNestedResourceTypeFirstWithHttpMessagesAsync(string providerNamespace, string resourceType, string nestedResourceTypeFirst, string sku, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// </summary>
        /// <param name='providerNamespace'>
        /// The name of the resource provider hosted within ProviderHub.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='nestedResourceTypeFirst'>
        /// The first child resource type.
        /// </param>
        /// <param name='nestedResourceTypeSecond'>
        /// The second child resource type.
        /// </param>
        /// <param name='sku'>
        /// The SKU.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SkuResource>> GetNestedResourceTypeSecondWithHttpMessagesAsync(string providerNamespace, string resourceType, string nestedResourceTypeFirst, string nestedResourceTypeSecond, string sku, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates the resource type skus in the given resource
        /// type.
        /// </summary>
        /// <param name='providerNamespace'>
        /// The name of the resource provider hosted within ProviderHub.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='nestedResourceTypeFirst'>
        /// The first child resource type.
        /// </param>
        /// <param name='nestedResourceTypeSecond'>
        /// The second child resource type.
        /// </param>
        /// <param name='sku'>
        /// The SKU.
        /// </param>
        /// <param name='properties'>
        /// The required body parameters supplied to the resource sku
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SkuResource>> CreateOrUpdateNestedResourceTypeSecondWithHttpMessagesAsync(string providerNamespace, string resourceType, string nestedResourceTypeFirst, string nestedResourceTypeSecond, string sku, ResourceTypeSku properties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a resource type sku.
        /// </summary>
        /// <param name='providerNamespace'>
        /// The name of the resource provider hosted within ProviderHub.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='nestedResourceTypeFirst'>
        /// The first child resource type.
        /// </param>
        /// <param name='nestedResourceTypeSecond'>
        /// The second child resource type.
        /// </param>
        /// <param name='sku'>
        /// The SKU.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteNestedResourceTypeSecondWithHttpMessagesAsync(string providerNamespace, string resourceType, string nestedResourceTypeFirst, string nestedResourceTypeSecond, string sku, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the sku details for the given resource type and sku name.
        /// </summary>
        /// <param name='providerNamespace'>
        /// The name of the resource provider hosted within ProviderHub.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='nestedResourceTypeFirst'>
        /// The first child resource type.
        /// </param>
        /// <param name='nestedResourceTypeSecond'>
        /// The second child resource type.
        /// </param>
        /// <param name='nestedResourceTypeThird'>
        /// The third child resource type.
        /// </param>
        /// <param name='sku'>
        /// The SKU.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SkuResource>> GetNestedResourceTypeThirdWithHttpMessagesAsync(string providerNamespace, string resourceType, string nestedResourceTypeFirst, string nestedResourceTypeSecond, string nestedResourceTypeThird, string sku, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates the resource type skus in the given resource
        /// type.
        /// </summary>
        /// <param name='providerNamespace'>
        /// The name of the resource provider hosted within ProviderHub.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='nestedResourceTypeFirst'>
        /// The first child resource type.
        /// </param>
        /// <param name='nestedResourceTypeSecond'>
        /// The second child resource type.
        /// </param>
        /// <param name='nestedResourceTypeThird'>
        /// The third child resource type.
        /// </param>
        /// <param name='sku'>
        /// The SKU.
        /// </param>
        /// <param name='properties'>
        /// The required body parameters supplied to the resource sku
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SkuResource>> CreateOrUpdateNestedResourceTypeThirdWithHttpMessagesAsync(string providerNamespace, string resourceType, string nestedResourceTypeFirst, string nestedResourceTypeSecond, string nestedResourceTypeThird, string sku, ResourceTypeSku properties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a resource type sku.
        /// </summary>
        /// <param name='providerNamespace'>
        /// The name of the resource provider hosted within ProviderHub.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='nestedResourceTypeFirst'>
        /// The first child resource type.
        /// </param>
        /// <param name='nestedResourceTypeSecond'>
        /// The second child resource type.
        /// </param>
        /// <param name='nestedResourceTypeThird'>
        /// The third child resource type.
        /// </param>
        /// <param name='sku'>
        /// The SKU.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteNestedResourceTypeThirdWithHttpMessagesAsync(string providerNamespace, string resourceType, string nestedResourceTypeFirst, string nestedResourceTypeSecond, string nestedResourceTypeThird, string sku, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of skus for the given resource type.
        /// </summary>
        /// <param name='providerNamespace'>
        /// The name of the resource provider hosted within ProviderHub.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SkuResource>>> ListByResourceTypeRegistrationsWithHttpMessagesAsync(string providerNamespace, string resourceType, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of skus for the given resource type.
        /// </summary>
        /// <param name='providerNamespace'>
        /// The name of the resource provider hosted within ProviderHub.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='nestedResourceTypeFirst'>
        /// The first child resource type.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SkuResource>>> ListByResourceTypeRegistrationsNestedResourceTypeFirstWithHttpMessagesAsync(string providerNamespace, string resourceType, string nestedResourceTypeFirst, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of skus for the given resource type.
        /// </summary>
        /// <param name='providerNamespace'>
        /// The name of the resource provider hosted within ProviderHub.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='nestedResourceTypeFirst'>
        /// The first child resource type.
        /// </param>
        /// <param name='nestedResourceTypeSecond'>
        /// The second child resource type.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SkuResource>>> ListByResourceTypeRegistrationsNestedResourceTypeSecondWithHttpMessagesAsync(string providerNamespace, string resourceType, string nestedResourceTypeFirst, string nestedResourceTypeSecond, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of skus for the given resource type.
        /// </summary>
        /// <param name='providerNamespace'>
        /// The name of the resource provider hosted within ProviderHub.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='nestedResourceTypeFirst'>
        /// The first child resource type.
        /// </param>
        /// <param name='nestedResourceTypeSecond'>
        /// The second child resource type.
        /// </param>
        /// <param name='nestedResourceTypeThird'>
        /// The third child resource type.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SkuResource>>> ListByResourceTypeRegistrationsNestedResourceTypeThirdWithHttpMessagesAsync(string providerNamespace, string resourceType, string nestedResourceTypeFirst, string nestedResourceTypeSecond, string nestedResourceTypeThird, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of skus for the given resource type.
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
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SkuResource>>> ListByResourceTypeRegistrationsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of skus for the given resource type.
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
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SkuResource>>> ListByResourceTypeRegistrationsNestedResourceTypeFirstNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of skus for the given resource type.
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
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SkuResource>>> ListByResourceTypeRegistrationsNestedResourceTypeSecondNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of skus for the given resource type.
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
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SkuResource>>> ListByResourceTypeRegistrationsNestedResourceTypeThirdNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
