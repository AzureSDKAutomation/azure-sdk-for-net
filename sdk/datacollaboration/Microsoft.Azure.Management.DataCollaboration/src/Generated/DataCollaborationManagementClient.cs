// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataCollaboration
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// Creates a Microsoft.DataCollaboration management client.
    /// </summary>
    public partial class DataCollaborationManagementClient : ServiceClient<DataCollaborationManagementClient>, IDataCollaborationManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// The api version to use.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// The subscription identifier
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IConsumerInvitationsOperations.
        /// </summary>
        public virtual IConsumerInvitationsOperations ConsumerInvitations { get; private set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Gets the IWorkspacesOperations.
        /// </summary>
        public virtual IWorkspacesOperations Workspaces { get; private set; }

        /// <summary>
        /// Gets the IConstrainedResourcesOperations.
        /// </summary>
        public virtual IConstrainedResourcesOperations ConstrainedResources { get; private set; }

        /// <summary>
        /// Gets the IDataAssetsOperations.
        /// </summary>
        public virtual IDataAssetsOperations DataAssets { get; private set; }

        /// <summary>
        /// Gets the IDataSetsOperations.
        /// </summary>
        public virtual IDataSetsOperations DataSets { get; private set; }

        /// <summary>
        /// Gets the IPipelineRunsOperations.
        /// </summary>
        public virtual IPipelineRunsOperations PipelineRuns { get; private set; }

        /// <summary>
        /// Gets the IPipelineStepRunsOperations.
        /// </summary>
        public virtual IPipelineStepRunsOperations PipelineStepRuns { get; private set; }

        /// <summary>
        /// Gets the IPipelinesOperations.
        /// </summary>
        public virtual IPipelinesOperations Pipelines { get; private set; }

        /// <summary>
        /// Gets the IPipelineStepsOperations.
        /// </summary>
        public virtual IPipelineStepsOperations PipelineSteps { get; private set; }

        /// <summary>
        /// Gets the IProposalsOperations.
        /// </summary>
        public virtual IProposalsOperations Proposals { get; private set; }

        /// <summary>
        /// Gets the IDataAssetReferencesOperations.
        /// </summary>
        public virtual IDataAssetReferencesOperations DataAssetReferences { get; private set; }

        /// <summary>
        /// Gets the IEntitlementsOperations.
        /// </summary>
        public virtual IEntitlementsOperations Entitlements { get; private set; }

        /// <summary>
        /// Gets the IConstraintsOperations.
        /// </summary>
        public virtual IConstraintsOperations Constraints { get; private set; }

        /// <summary>
        /// Gets the IPoliciesOperations.
        /// </summary>
        public virtual IPoliciesOperations Policies { get; private set; }

        /// <summary>
        /// Gets the IInvitationsOperations.
        /// </summary>
        public virtual IInvitationsOperations Invitations { get; private set; }

        /// <summary>
        /// Gets the IParticipantsOperations.
        /// </summary>
        public virtual IParticipantsOperations Participants { get; private set; }

        /// <summary>
        /// Gets the IScriptReferencesOperations.
        /// </summary>
        public virtual IScriptReferencesOperations ScriptReferences { get; private set; }

        /// <summary>
        /// Gets the IResourceReferencesOperations.
        /// </summary>
        public virtual IResourceReferencesOperations ResourceReferences { get; private set; }

        /// <summary>
        /// Gets the IScriptsOperations.
        /// </summary>
        public virtual IScriptsOperations Scripts { get; private set; }

        /// <summary>
        /// Gets the IScriptRevisionsOperations.
        /// </summary>
        public virtual IScriptRevisionsOperations ScriptRevisions { get; private set; }

        /// <summary>
        /// Initializes a new instance of the DataCollaborationManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling DataCollaborationManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        protected DataCollaborationManagementClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DataCollaborationManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected DataCollaborationManagementClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DataCollaborationManagementClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected DataCollaborationManagementClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DataCollaborationManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected DataCollaborationManagementClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the DataCollaborationManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected DataCollaborationManagementClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the DataCollaborationManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DataCollaborationManagementClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DataCollaborationManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling DataCollaborationManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DataCollaborationManagementClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DataCollaborationManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DataCollaborationManagementClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DataCollaborationManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DataCollaborationManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DataCollaborationManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DataCollaborationManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            ConsumerInvitations = new ConsumerInvitationsOperations(this);
            Operations = new Operations(this);
            Workspaces = new WorkspacesOperations(this);
            ConstrainedResources = new ConstrainedResourcesOperations(this);
            DataAssets = new DataAssetsOperations(this);
            DataSets = new DataSetsOperations(this);
            PipelineRuns = new PipelineRunsOperations(this);
            PipelineStepRuns = new PipelineStepRunsOperations(this);
            Pipelines = new PipelinesOperations(this);
            PipelineSteps = new PipelineStepsOperations(this);
            Proposals = new ProposalsOperations(this);
            DataAssetReferences = new DataAssetReferencesOperations(this);
            Entitlements = new EntitlementsOperations(this);
            Constraints = new ConstraintsOperations(this);
            Policies = new PoliciesOperations(this);
            Invitations = new InvitationsOperations(this);
            Participants = new ParticipantsOperations(this);
            ScriptReferences = new ScriptReferencesOperations(this);
            ResourceReferences = new ResourceReferencesOperations(this);
            Scripts = new ScriptsOperations(this);
            ScriptRevisions = new ScriptRevisionsOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            ApiVersion = "2020-05-04-preview";
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ConstrainedResource>("kind"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ConstrainedResource>("kind"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<Constraint>("kind"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<Constraint>("kind"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<DataSet>("kind"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<DataSet>("kind"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<PipelineStep>("kind"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<PipelineStep>("kind"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<PipelineSubstep>("kind"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<PipelineSubstep>("kind"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<Policy>("kind"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<Policy>("kind"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ResourceReference>("kind"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ResourceReference>("kind"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<Script>("kind"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<Script>("kind"));
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
