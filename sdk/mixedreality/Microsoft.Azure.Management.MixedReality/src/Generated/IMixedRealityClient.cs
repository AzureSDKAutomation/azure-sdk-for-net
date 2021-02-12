// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MixedReality
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Mixed Reality Client
    /// </summary>
    public partial interface IMixedRealityClient : System.IDisposable
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
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// The API version to be used with the HTTP request.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The Azure subscription ID. This is a GUID-formatted string (e.g.
        /// 00000000-0000-0000-0000-000000000000)
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IObjectAnchorsAccountsOperations.
        /// </summary>
        IObjectAnchorsAccountsOperations ObjectAnchorsAccounts { get; }

        /// <summary>
        /// Gets the ISpatialAnchorsAccountsOperations.
        /// </summary>
        ISpatialAnchorsAccountsOperations SpatialAnchorsAccounts { get; }

        /// <summary>
        /// Gets the IRemoteRenderingAccountsOperations.
        /// </summary>
        IRemoteRenderingAccountsOperations RemoteRenderingAccounts { get; }

        /// <summary>
        /// Check Name Availability for local uniqueness
        /// </summary>
        /// <param name='location'>
        /// The location in which uniqueness will be verified.
        /// </param>
        /// <param name='checkNameAvailability'>
        /// Check Name Availability Request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CheckNameAvailabilityResponse>> CheckNameAvailabilityLocalWithHttpMessagesAsync(string location, CheckNameAvailabilityRequest checkNameAvailability, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
