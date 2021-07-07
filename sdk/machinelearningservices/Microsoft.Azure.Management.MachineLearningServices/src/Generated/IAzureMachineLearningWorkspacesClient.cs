// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// These APIs allow end users to operate on Azure Machine Learning
    /// Workspace resources.
    /// </summary>
    public partial interface IAzureMachineLearningWorkspacesClient : System.IDisposable
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
        /// The API version to use for this operation.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The ID of the target subscription.
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
        /// Gets the IWorkspacesOperations.
        /// </summary>
        IWorkspacesOperations Workspaces { get; }

        /// <summary>
        /// Gets the IUsagesOperations.
        /// </summary>
        IUsagesOperations Usages { get; }

        /// <summary>
        /// Gets the IVirtualMachineSizesOperations.
        /// </summary>
        IVirtualMachineSizesOperations VirtualMachineSizes { get; }

        /// <summary>
        /// Gets the IQuotasOperations.
        /// </summary>
        IQuotasOperations Quotas { get; }

        /// <summary>
        /// Gets the IComputeOperations.
        /// </summary>
        IComputeOperations Compute { get; }

        /// <summary>
        /// Gets the IPrivateEndpointConnectionsOperations.
        /// </summary>
        IPrivateEndpointConnectionsOperations PrivateEndpointConnections { get; }

        /// <summary>
        /// Gets the IPrivateLinkResourcesOperations.
        /// </summary>
        IPrivateLinkResourcesOperations PrivateLinkResources { get; }

        /// <summary>
        /// Gets the IWorkspaceConnectionsOperations.
        /// </summary>
        IWorkspaceConnectionsOperations WorkspaceConnections { get; }

        /// <summary>
        /// Gets the IMachineLearningServicesOperations.
        /// </summary>
        IMachineLearningServicesOperations MachineLearningServices { get; }

        /// <summary>
        /// Gets the IWorkspaceFeaturesOperations.
        /// </summary>
        IWorkspaceFeaturesOperations WorkspaceFeatures { get; }

        /// <summary>
        /// Gets the IWorkspaceSkusOperations.
        /// </summary>
        IWorkspaceSkusOperations WorkspaceSkus { get; }

    }
}
