// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The request to create an AKS service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AKS")]
    public partial class AKSServiceCreateRequest : CreateEndpointVariantRequest
    {
        /// <summary>
        /// Initializes a new instance of the AKSServiceCreateRequest class.
        /// </summary>
        public AKSServiceCreateRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AKSServiceCreateRequest class.
        /// </summary>
        /// <param name="description">The description of the service.</param>
        /// <param name="kvTags">The service tag dictionary. Tags are
        /// mutable.</param>
        /// <param name="properties">The service properties dictionary.
        /// Properties are immutable.</param>
        /// <param name="keys">The authentication keys.</param>
        /// <param name="environmentImageRequest">The Environment, models and
        /// assets needed for inferencing.</param>
        /// <param name="location">The name of the Azure
        /// location/region.</param>
        /// <param name="isDefault">Is this the default variant.</param>
        /// <param name="trafficPercentile">The amount of traffic variant
        /// receives.</param>
        /// <param name="type">The type of the variant. Possible values
        /// include: 'Control', 'Treatment'</param>
        /// <param name="numReplicas">The number of replicas on the
        /// cluster.</param>
        /// <param name="dataCollection">Details of the data collection options
        /// specified.</param>
        /// <param name="computeName">The name of the compute resource.</param>
        /// <param name="appInsightsEnabled">Whether or not Application
        /// Insights is enabled.</param>
        /// <param name="autoScaler">The auto scaler properties.</param>
        /// <param name="containerResourceRequirements">The container resource
        /// requirements.</param>
        /// <param name="maxConcurrentRequestsPerContainer">The maximum number
        /// of concurrent requests per container.</param>
        /// <param name="maxQueueWaitMs">Maximum time a request will wait in
        /// the queue (in milliseconds). After this time, the service will
        /// return 503 (Service Unavailable)</param>
        /// <param name="namespaceProperty">Kubernetes namespace for the
        /// service.</param>
        /// <param name="scoringTimeoutMs">The scoring timeout in
        /// milliseconds.</param>
        /// <param name="authEnabled">Whether or not authentication is
        /// enabled.</param>
        /// <param name="livenessProbeRequirements">The liveness probe
        /// requirements.</param>
        /// <param name="aadAuthEnabled">Whether or not AAD authentication is
        /// enabled.</param>
        public AKSServiceCreateRequest(string description = default(string), IDictionary<string, string> kvTags = default(IDictionary<string, string>), IDictionary<string, string> properties = default(IDictionary<string, string>), CreateServiceRequestKeys keys = default(CreateServiceRequestKeys), CreateServiceRequestEnvironmentImageRequest environmentImageRequest = default(CreateServiceRequestEnvironmentImageRequest), string location = default(string), bool? isDefault = default(bool?), double? trafficPercentile = default(double?), string type = default(string), int? numReplicas = default(int?), AKSServiceCreateRequestDataCollection dataCollection = default(AKSServiceCreateRequestDataCollection), string computeName = default(string), bool? appInsightsEnabled = default(bool?), AKSServiceCreateRequestAutoScaler autoScaler = default(AKSServiceCreateRequestAutoScaler), ContainerResourceRequirements containerResourceRequirements = default(ContainerResourceRequirements), int? maxConcurrentRequestsPerContainer = default(int?), int? maxQueueWaitMs = default(int?), string namespaceProperty = default(string), int? scoringTimeoutMs = default(int?), bool? authEnabled = default(bool?), AKSServiceCreateRequestLivenessProbeRequirements livenessProbeRequirements = default(AKSServiceCreateRequestLivenessProbeRequirements), bool? aadAuthEnabled = default(bool?))
            : base(description, kvTags, properties, keys, environmentImageRequest, location, isDefault, trafficPercentile, type)
        {
            NumReplicas = numReplicas;
            DataCollection = dataCollection;
            ComputeName = computeName;
            AppInsightsEnabled = appInsightsEnabled;
            AutoScaler = autoScaler;
            ContainerResourceRequirements = containerResourceRequirements;
            MaxConcurrentRequestsPerContainer = maxConcurrentRequestsPerContainer;
            MaxQueueWaitMs = maxQueueWaitMs;
            NamespaceProperty = namespaceProperty;
            ScoringTimeoutMs = scoringTimeoutMs;
            AuthEnabled = authEnabled;
            LivenessProbeRequirements = livenessProbeRequirements;
            AadAuthEnabled = aadAuthEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of replicas on the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "numReplicas")]
        public int? NumReplicas { get; set; }

        /// <summary>
        /// Gets or sets details of the data collection options specified.
        /// </summary>
        [JsonProperty(PropertyName = "dataCollection")]
        public AKSServiceCreateRequestDataCollection DataCollection { get; set; }

        /// <summary>
        /// Gets or sets the name of the compute resource.
        /// </summary>
        [JsonProperty(PropertyName = "computeName")]
        public string ComputeName { get; set; }

        /// <summary>
        /// Gets or sets whether or not Application Insights is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "appInsightsEnabled")]
        public bool? AppInsightsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the auto scaler properties.
        /// </summary>
        [JsonProperty(PropertyName = "autoScaler")]
        public AKSServiceCreateRequestAutoScaler AutoScaler { get; set; }

        /// <summary>
        /// Gets or sets the container resource requirements.
        /// </summary>
        [JsonProperty(PropertyName = "containerResourceRequirements")]
        public ContainerResourceRequirements ContainerResourceRequirements { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of concurrent requests per
        /// container.
        /// </summary>
        [JsonProperty(PropertyName = "maxConcurrentRequestsPerContainer")]
        public int? MaxConcurrentRequestsPerContainer { get; set; }

        /// <summary>
        /// Gets or sets maximum time a request will wait in the queue (in
        /// milliseconds). After this time, the service will return 503
        /// (Service Unavailable)
        /// </summary>
        [JsonProperty(PropertyName = "maxQueueWaitMs")]
        public int? MaxQueueWaitMs { get; set; }

        /// <summary>
        /// Gets or sets kubernetes namespace for the service.
        /// </summary>
        [JsonProperty(PropertyName = "namespace")]
        public string NamespaceProperty { get; set; }

        /// <summary>
        /// Gets or sets the scoring timeout in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "scoringTimeoutMs")]
        public int? ScoringTimeoutMs { get; set; }

        /// <summary>
        /// Gets or sets whether or not authentication is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "authEnabled")]
        public bool? AuthEnabled { get; set; }

        /// <summary>
        /// Gets or sets the liveness probe requirements.
        /// </summary>
        [JsonProperty(PropertyName = "livenessProbeRequirements")]
        public AKSServiceCreateRequestLivenessProbeRequirements LivenessProbeRequirements { get; set; }

        /// <summary>
        /// Gets or sets whether or not AAD authentication is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "aadAuthEnabled")]
        public bool? AadAuthEnabled { get; set; }

    }
}
