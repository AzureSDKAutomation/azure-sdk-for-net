// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.MachineLearningServices;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> MachineLearningServices service management client. </summary>
    public class MachineLearningServicesManagementClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _subscriptionId;

        /// <summary> Initializes a new instance of MachineLearningServicesManagementClient for mocking. </summary>
        protected MachineLearningServicesManagementClient()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningServicesManagementClient. </summary>
        /// <param name="subscriptionId"> Azure subscription identifier. </param>
        /// <param name="tokenCredential"> The OAuth token for making client requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public MachineLearningServicesManagementClient(string subscriptionId, TokenCredential tokenCredential, MachineLearningServicesManagementClientOptions options = null) : this(null, subscriptionId, tokenCredential, options)
        {
        }
        /// <summary> Initializes a new instance of MachineLearningServicesManagementClient. </summary>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="subscriptionId"> Azure subscription identifier. </param>
        /// <param name="tokenCredential"> The OAuth token for making client requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public MachineLearningServicesManagementClient(Uri endpoint, string subscriptionId, TokenCredential tokenCredential, MachineLearningServicesManagementClientOptions options = null)
        {
            endpoint ??= new Uri("https://management.azure.com");
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            options ??= new MachineLearningServicesManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, endpoint, options);
            _endpoint = endpoint;
            _subscriptionId = subscriptionId;
        }

        /// <summary> Returns an instance of Operations. </summary>
        public virtual Operations Operations => new Operations(_clientDiagnostics, _pipeline, _endpoint);

        /// <summary> Returns an instance of WorkspacesOperations. </summary>
        public virtual WorkspacesOperations Workspaces => new WorkspacesOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of WorkspaceFeaturesOperations. </summary>
        public virtual WorkspaceFeaturesOperations WorkspaceFeatures => new WorkspaceFeaturesOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of UsagesOperations. </summary>
        public virtual UsagesOperations Usages => new UsagesOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of VirtualMachineSizesOperations. </summary>
        public virtual VirtualMachineSizesOperations VirtualMachineSizes => new VirtualMachineSizesOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of QuotasOperations. </summary>
        public virtual QuotasOperations Quotas => new QuotasOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of MachineLearningComputeOperations. </summary>
        public virtual MachineLearningComputeOperations MachineLearningCompute => new MachineLearningComputeOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of AzureMachineLearningWorkspacesOperations. </summary>
        public virtual AzureMachineLearningWorkspacesOperations AzureMachineLearningWorkspaces => new AzureMachineLearningWorkspacesOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of PrivateEndpointConnectionsOperations. </summary>
        public virtual PrivateEndpointConnectionsOperations PrivateEndpointConnections => new PrivateEndpointConnectionsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of PrivateLinkResourcesOperations. </summary>
        public virtual PrivateLinkResourcesOperations PrivateLinkResources => new PrivateLinkResourcesOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of LinkedServicesOperations. </summary>
        public virtual LinkedServicesOperations LinkedServices => new LinkedServicesOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of MachineLearningServiceOperations. </summary>
        public virtual MachineLearningServiceOperations MachineLearningService => new MachineLearningServiceOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of NotebooksOperations. </summary>
        public virtual NotebooksOperations Notebooks => new NotebooksOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of WorkspaceConnectionsOperations. </summary>
        public virtual WorkspaceConnectionsOperations WorkspaceConnections => new WorkspaceConnectionsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of CodeContainersOperations. </summary>
        public virtual CodeContainersOperations CodeContainers => new CodeContainersOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of CodeVersionsOperations. </summary>
        public virtual CodeVersionsOperations CodeVersions => new CodeVersionsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of DataContainersOperations. </summary>
        public virtual DataContainersOperations DataContainers => new DataContainersOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of DatastoresOperations. </summary>
        public virtual DatastoresOperations Datastores => new DatastoresOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of DataVersionsOperations. </summary>
        public virtual DataVersionsOperations DataVersions => new DataVersionsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of EnvironmentContainersOperations. </summary>
        public virtual EnvironmentContainersOperations EnvironmentContainers => new EnvironmentContainersOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of EnvironmentSpecificationVersionsOperations. </summary>
        public virtual EnvironmentSpecificationVersionsOperations EnvironmentSpecificationVersions => new EnvironmentSpecificationVersionsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of JobsOperations. </summary>
        public virtual JobsOperations Jobs => new JobsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of LabelingJobsOperations. </summary>
        public virtual LabelingJobsOperations LabelingJobs => new LabelingJobsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of ModelContainersOperations. </summary>
        public virtual ModelContainersOperations ModelContainers => new ModelContainersOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of ModelVersionsOperations. </summary>
        public virtual ModelVersionsOperations ModelVersions => new ModelVersionsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
    }
}
