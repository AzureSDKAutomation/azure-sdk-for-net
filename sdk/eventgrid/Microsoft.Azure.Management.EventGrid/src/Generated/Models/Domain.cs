// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// EventGrid Domain.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Domain : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Domain class.
        /// </summary>
        public Domain()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Domain class.
        /// </summary>
        /// <param name="location">Location of the resource.</param>
        /// <param name="id">Fully qualified identifier of the
        /// resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of the resource.</param>
        /// <param name="tags">Tags of the resource.</param>
        /// <param name="privateEndpointConnections">List of private endpoint
        /// connections.</param>
        /// <param name="provisioningState">Provisioning state of the domain.
        /// Possible values include: 'Creating', 'Updating', 'Deleting',
        /// 'Succeeded', 'Canceled', 'Failed'</param>
        /// <param name="endpoint">Endpoint for the domain.</param>
        /// <param name="inputSchema">This determines the format that Event
        /// Grid should expect for incoming events published to the domain.
        /// Possible values include: 'EventGridSchema', 'CustomEventSchema',
        /// 'CloudEventSchemaV1_0'</param>
        /// <param name="inputSchemaMapping">Information about the
        /// InputSchemaMapping which specified the info about mapping event
        /// payload.</param>
        /// <param name="metricResourceId">Metric resource id for the
        /// domain.</param>
        /// <param name="publicNetworkAccess">This determines if traffic is
        /// allowed over public network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring &lt;seealso
        /// cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.DomainProperties.InboundIpRules"
        /// /&gt;. Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="inboundIpRules">This can be used to restrict traffic
        /// from specific IPs instead of all IPs. Note: These are considered
        /// only if PublicNetworkAccess is enabled.</param>
        /// <param name="sku">The Sku pricing tier for the domain.</param>
        /// <param name="identity">Identity information for the
        /// resource.</param>
        /// <param name="systemData">The system metadata relating to Domain
        /// resource.</param>
        public Domain(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<PrivateEndpointConnection> privateEndpointConnections = default(IList<PrivateEndpointConnection>), string provisioningState = default(string), string endpoint = default(string), string inputSchema = default(string), InputSchemaMapping inputSchemaMapping = default(InputSchemaMapping), string metricResourceId = default(string), string publicNetworkAccess = default(string), IList<InboundIpRule> inboundIpRules = default(IList<InboundIpRule>), ResourceSku sku = default(ResourceSku), IdentityInfo identity = default(IdentityInfo), SystemData systemData = default(SystemData))
            : base(location, id, name, type, tags)
        {
            PrivateEndpointConnections = privateEndpointConnections;
            ProvisioningState = provisioningState;
            Endpoint = endpoint;
            InputSchema = inputSchema;
            InputSchemaMapping = inputSchemaMapping;
            MetricResourceId = metricResourceId;
            PublicNetworkAccess = publicNetworkAccess;
            InboundIpRules = inboundIpRules;
            Sku = sku;
            Identity = identity;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of private endpoint connections.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets provisioning state of the domain. Possible values include:
        /// 'Creating', 'Updating', 'Deleting', 'Succeeded', 'Canceled',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets endpoint for the domain.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoint")]
        public string Endpoint { get; private set; }

        /// <summary>
        /// Gets or sets this determines the format that Event Grid should
        /// expect for incoming events published to the domain. Possible values
        /// include: 'EventGridSchema', 'CustomEventSchema',
        /// 'CloudEventSchemaV1_0'
        /// </summary>
        [JsonProperty(PropertyName = "properties.inputSchema")]
        public string InputSchema { get; set; }

        /// <summary>
        /// Gets or sets information about the InputSchemaMapping which
        /// specified the info about mapping event payload.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inputSchemaMapping")]
        public InputSchemaMapping InputSchemaMapping { get; set; }

        /// <summary>
        /// Gets metric resource id for the domain.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metricResourceId")]
        public string MetricResourceId { get; private set; }

        /// <summary>
        /// Gets or sets this determines if traffic is allowed over public
        /// network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring
        /// &amp;lt;seealso
        /// cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.DomainProperties.InboundIpRules"
        /// /&amp;gt;. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets this can be used to restrict traffic from specific IPs
        /// instead of all IPs. Note: These are considered only if
        /// PublicNetworkAccess is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inboundIpRules")]
        public IList<InboundIpRule> InboundIpRules { get; set; }

        /// <summary>
        /// Gets or sets the Sku pricing tier for the domain.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public ResourceSku Sku { get; set; }

        /// <summary>
        /// Gets or sets identity information for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public IdentityInfo Identity { get; set; }

        /// <summary>
        /// Gets the system metadata relating to Domain resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
