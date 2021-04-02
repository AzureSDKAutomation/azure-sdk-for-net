// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Quota
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// QuotaResourceProvidersOperations operations.
    /// </summary>
    public partial interface IQuotaResourceProvidersOperations
    {
        /// <summary>
        /// Gets the list of current resource providers supported by Quota
        /// resource provider.
        /// For each resource provider, resource templates supported by the
        /// resource provider will be provided.
        /// For each resource template, the resource dimensions will be listed.
        /// The resource dimensions are the name value pairs in the resource
        /// uri.
        /// Example:
        /// For Microsoft.Compute Resource Provider: The url template will be
        /// '/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{locationId}/quotaBucket'
        /// The actual dimensions will vary by resource provider. This an
        /// example for illustration.
        /// The resource dimensions will be:
        /// {subscriptions},{locations},{quotaBucket}.
        /// The specific details for each resource dimension can be retrieved
        /// using the quotaLimitTypes API call.
        /// </summary>
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
        Task<AzureOperationResponse<ResourceProvidersList>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
