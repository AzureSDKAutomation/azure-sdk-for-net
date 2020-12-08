// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// VirtualMachineImagesEdgeZoneOperations operations.
    /// </summary>
    public partial interface IVirtualMachineImagesEdgeZoneOperations
    {
        /// <summary>
        /// Gets a virtual machine image in an edge zone.
        /// </summary>
        /// <param name='location'>
        /// The name of a supported Azure region.
        /// </param>
        /// <param name='edgeZone'>
        /// The name of the edge zone.
        /// </param>
        /// <param name='publisherName'>
        /// A valid image publisher.
        /// </param>
        /// <param name='offer'>
        /// A valid image publisher offer.
        /// </param>
        /// <param name='skus'>
        /// A valid image SKU.
        /// </param>
        /// <param name='version'>
        /// A valid image SKU version.
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
        Task<AzureOperationResponse<VirtualMachineImage>> GetWithHttpMessagesAsync(string location, string edgeZone, string publisherName, string offer, string skus, string version, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of all virtual machine image versions for the specified
        /// location, edge zone, publisher, offer, and SKU.
        /// </summary>
        /// <param name='location'>
        /// The name of a supported Azure region.
        /// </param>
        /// <param name='edgeZone'>
        /// The name of the edge zone.
        /// </param>
        /// <param name='publisherName'>
        /// A valid image publisher.
        /// </param>
        /// <param name='offer'>
        /// A valid image publisher offer.
        /// </param>
        /// <param name='skus'>
        /// A valid image SKU.
        /// </param>
        /// <param name='expand'>
        /// The expand expression to apply on the operation.
        /// </param>
        /// <param name='top'>
        /// An integer value specifying the number of images to return that
        /// matches supplied values.
        /// </param>
        /// <param name='orderby'>
        /// Specifies the order of the results returned. Formatted as an OData
        /// query.
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
        Task<AzureOperationResponse<IList<VirtualMachineImageResource>>> ListWithHttpMessagesAsync(string location, string edgeZone, string publisherName, string offer, string skus, string expand = default(string), int? top = default(int?), string orderby = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of virtual machine image offers for the specified
        /// location, edge zone and publisher.
        /// </summary>
        /// <param name='location'>
        /// The name of a supported Azure region.
        /// </param>
        /// <param name='edgeZone'>
        /// The name of the edge zone.
        /// </param>
        /// <param name='publisherName'>
        /// A valid image publisher.
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
        Task<AzureOperationResponse<IList<VirtualMachineImageResource>>> ListOffersWithHttpMessagesAsync(string location, string edgeZone, string publisherName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of virtual machine image publishers for the specified
        /// Azure location and edge zone.
        /// </summary>
        /// <param name='location'>
        /// The name of a supported Azure region.
        /// </param>
        /// <param name='edgeZone'>
        /// The name of the edge zone.
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
        Task<AzureOperationResponse<IList<VirtualMachineImageResource>>> ListPublishersWithHttpMessagesAsync(string location, string edgeZone, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of virtual machine image SKUs for the specified
        /// location, edge zone, publisher, and offer.
        /// </summary>
        /// <param name='location'>
        /// The name of a supported Azure region.
        /// </param>
        /// <param name='edgeZone'>
        /// The name of the edge zone.
        /// </param>
        /// <param name='publisherName'>
        /// A valid image publisher.
        /// </param>
        /// <param name='offer'>
        /// A valid image publisher offer.
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
        Task<AzureOperationResponse<IList<VirtualMachineImageResource>>> ListSkusWithHttpMessagesAsync(string location, string edgeZone, string publisherName, string offer, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
