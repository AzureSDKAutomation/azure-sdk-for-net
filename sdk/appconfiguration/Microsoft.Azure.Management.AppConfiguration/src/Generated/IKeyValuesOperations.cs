// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppConfiguration
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// KeyValuesOperations operations.
    /// </summary>
    public partial interface IKeyValuesOperations
    {
        /// <summary>
        /// Lists the key-values for a given configuration store.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='configStoreName'>
        /// The name of the configuration store.
        /// </param>
        /// <param name='skipToken'>
        /// A skip token is used to continue retrieving items after an
        /// operation returns a partial result. If a previous response contains
        /// a nextLink element, the value of the nextLink element will include
        /// a skipToken parameter that specifies a starting point to use for
        /// subsequent calls.
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
        Task<AzureOperationResponse<IPage<KeyValue>>> ListByConfigurationStoreWithHttpMessagesAsync(string resourceGroupName, string configStoreName, string skipToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the properties of the specified key-value.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='configStoreName'>
        /// The name of the configuration store.
        /// </param>
        /// <param name='keyValueName'>
        /// Identifier of key and label combination. Key and label are joined
        /// by $ character. Label is optional.
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
        Task<AzureOperationResponse<KeyValue>> GetWithHttpMessagesAsync(string resourceGroupName, string configStoreName, string keyValueName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a key-value.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='configStoreName'>
        /// The name of the configuration store.
        /// </param>
        /// <param name='keyValueName'>
        /// Identifier of key and label combination. Key and label are joined
        /// by $ character. Label is optional.
        /// </param>
        /// <param name='keyValueParameters'>
        /// The parameters for creating a key-value.
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
        Task<AzureOperationResponse<KeyValue>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string configStoreName, string keyValueName, KeyValue keyValueParameters = default(KeyValue), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a key-value.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='configStoreName'>
        /// The name of the configuration store.
        /// </param>
        /// <param name='keyValueName'>
        /// Identifier of key and label combination. Key and label are joined
        /// by $ character. Label is optional.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string configStoreName, string keyValueName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a key-value.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='configStoreName'>
        /// The name of the configuration store.
        /// </param>
        /// <param name='keyValueName'>
        /// Identifier of key and label combination. Key and label are joined
        /// by $ character. Label is optional.
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
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string configStoreName, string keyValueName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the key-values for a given configuration store.
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
        Task<AzureOperationResponse<IPage<KeyValue>>> ListByConfigurationStoreNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
