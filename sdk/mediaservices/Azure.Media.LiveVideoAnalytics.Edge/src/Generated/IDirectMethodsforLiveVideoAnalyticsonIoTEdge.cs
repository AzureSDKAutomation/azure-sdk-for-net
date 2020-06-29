// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Media.LiveVideoAnalytics.Edge
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Direct Methods for Live Video Analytics on IoT Edge.
    /// </summary>
    public partial interface IDirectMethodsforLiveVideoAnalyticsonIoTEdge : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// Retrieves a list of graph topologies.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of graph topologies that have been added to the
        /// Live Video Analytics IoT Edge module.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<MediaGraphTopologyCollection>> GraphTopologyListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates or updates a graph topology.
        /// </summary>
        /// <remarks>
        /// Creates a new topology or updates an existing one, with the given
        /// name. A topology is a blueprint defining what nodes are in a graph,
        /// and how they are interconnected.
        /// </remarks>
        /// <param name='topology'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<MediaGraphTopology>> GraphTopologySetWithHttpMessagesAsync(MediaGraphTopology topology, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets a graph topology by name.
        /// </summary>
        /// <remarks>
        /// Retrieves a graph topology by name. If a topology with that name
        /// has been previously set, then the call will return the JSON
        /// representation of that topology.
        /// </remarks>
        /// <param name='name'>
        /// Name of the graph topology to be retrieved.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<MediaGraphTopology>> GraphTopologyGetWithHttpMessagesAsync(string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes a graph topology.
        /// </summary>
        /// <remarks>
        /// Deletes a graph topology with the given name. This method should be
        /// called after all instances of the topology have been stopped and
        /// deleted.
        /// </remarks>
        /// <param name='name'>
        /// Name of the graph topology to be deleted.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> GraphTopologyDeleteWithHttpMessagesAsync(string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieves a list of graph instances.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of graph instances, if any, that have been created
        /// in the Live Video Analytics IoT Edge module.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<MediaGraphInstanceCollection>> GraphInstanceListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates or updates a graph instance.
        /// </summary>
        /// <remarks>
        /// Creates or updates a graph instance.
        /// </remarks>
        /// <param name='instance'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<MediaGraphInstance>> GraphInstanceSetWithHttpMessagesAsync(MediaGraphInstance instance, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets a graph instance by name.
        /// </summary>
        /// <remarks>
        /// Retrieves a  graph instance by name. If a graph instance with that
        /// name has been previously created, then the direct method call will
        /// return the JSON representation of that instance.
        /// </remarks>
        /// <param name='name'>
        /// Name of the graph instance to be retrieved.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<MediaGraphInstance>> GraphInstanceGetWithHttpMessagesAsync(string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes a graph instance.
        /// </summary>
        /// <remarks>
        /// Deletes a graph instance.
        /// </remarks>
        /// <param name='name'>
        /// Name of the graph instance to be deleted.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> GraphInstanceDeleteWithHttpMessagesAsync(string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Activate a given graph instance.
        /// </summary>
        /// <remarks>
        /// Activates a graph instance with the name provided, if it exists.
        /// </remarks>
        /// <param name='name'>
        /// Name of the graph instance to be activated.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> GraphInstanceActivateWithHttpMessagesAsync(string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deactivate a graph instance.
        /// </summary>
        /// <remarks>
        /// Deactivates a graph instance with the name provided, if it is
        /// active.
        /// </remarks>
        /// <param name='name'>
        /// Name of the graph instance to be deactivated.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> GraphInstanceDeactivateWithHttpMessagesAsync(string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
