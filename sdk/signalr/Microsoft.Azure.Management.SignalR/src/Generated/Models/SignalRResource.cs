// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SignalR.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A class represent a resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SignalRResource : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the SignalRResource class.
        /// </summary>
        public SignalRResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SignalRResource class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the
        /// resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource - e.g.
        /// "Microsoft.SignalRService/SignalR"</param>
        /// <param name="location">The GEO location of the resource. e.g. West
        /// US | East US | North Central US | South Central US.</param>
        /// <param name="tags">Tags of the service which is a list of key value
        /// pairs that describe the resource.</param>
        /// <param name="sku">The billing information of the resource.(e.g.
        /// Free, Standard)</param>
        /// <param name="features">List of SignalR featureFlags. e.g.
        /// ServiceMode.
        ///
        /// FeatureFlags that are not included in the parameters for the update
        /// operation will not be modified.
        /// And the response will only include featureFlags that are explicitly
        /// set.
        /// When a featureFlag is not explicitly set, SignalR service will use
        /// its globally default value.
        /// But keep in mind, the default value doesn't mean "false". It varies
        /// in terms of different FeatureFlags.</param>
        /// <param name="cors">Cross-Origin Resource Sharing (CORS)
        /// settings.</param>
        /// <param name="upstream">Upstream settings when the Azure SignalR is
        /// in server-less mode.</param>
        /// <param name="networkACLs">Network ACLs</param>
        /// <param name="provisioningState">Provisioning state of the resource.
        /// Possible values include: 'Unknown', 'Succeeded', 'Failed',
        /// 'Canceled', 'Running', 'Creating', 'Updating', 'Deleting',
        /// 'Moving'</param>
        /// <param name="externalIP">The publicly accessible IP of the
        /// resource.</param>
        /// <param name="hostName">FQDN of the service instance.</param>
        /// <param name="publicPort">The publicly accessible port of the
        /// resource which is designed for browser/client side usage.</param>
        /// <param name="serverPort">The publicly accessible port of the
        /// resource which is designed for customer server side usage.</param>
        /// <param name="version">Version of the resource. Probably you need
        /// the same or higher version of client SDKs.</param>
        /// <param name="privateEndpointConnections">Private endpoint
        /// connections to the resource.</param>
        /// <param name="tls">TLS settings.</param>
        /// <param name="kind">The kind of the service - e.g. "SignalR" for
        /// "Microsoft.SignalRService/SignalR". Possible values include:
        /// 'SignalR', 'RawWebSockets'</param>
        /// <param name="identity">The managed identity response</param>
        public SignalRResource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ResourceSku sku = default(ResourceSku), IList<SignalRFeature> features = default(IList<SignalRFeature>), SignalRCorsSettings cors = default(SignalRCorsSettings), ServerlessUpstreamSettings upstream = default(ServerlessUpstreamSettings), SignalRNetworkACLs networkACLs = default(SignalRNetworkACLs), string provisioningState = default(string), string externalIP = default(string), string hostName = default(string), int? publicPort = default(int?), int? serverPort = default(int?), string version = default(string), IList<PrivateEndpointConnection> privateEndpointConnections = default(IList<PrivateEndpointConnection>), SignalRTlsSettings tls = default(SignalRTlsSettings), string kind = default(string), ManagedIdentity identity = default(ManagedIdentity))
            : base(id, name, type, location, tags)
        {
            Sku = sku;
            Features = features;
            Cors = cors;
            Upstream = upstream;
            NetworkACLs = networkACLs;
            ProvisioningState = provisioningState;
            ExternalIP = externalIP;
            HostName = hostName;
            PublicPort = publicPort;
            ServerPort = serverPort;
            Version = version;
            PrivateEndpointConnections = privateEndpointConnections;
            Tls = tls;
            Kind = kind;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the billing information of the resource.(e.g. Free,
        /// Standard)
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public ResourceSku Sku { get; set; }

        /// <summary>
        /// Gets or sets list of SignalR featureFlags. e.g. ServiceMode.
        ///
        /// FeatureFlags that are not included in the parameters for the update
        /// operation will not be modified.
        /// And the response will only include featureFlags that are explicitly
        /// set.
        /// When a featureFlag is not explicitly set, SignalR service will use
        /// its globally default value.
        /// But keep in mind, the default value doesn't mean "false". It varies
        /// in terms of different FeatureFlags.
        /// </summary>
        [JsonProperty(PropertyName = "properties.features")]
        public IList<SignalRFeature> Features { get; set; }

        /// <summary>
        /// Gets or sets cross-Origin Resource Sharing (CORS) settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cors")]
        public SignalRCorsSettings Cors { get; set; }

        /// <summary>
        /// Gets or sets upstream settings when the Azure SignalR is in
        /// server-less mode.
        /// </summary>
        [JsonProperty(PropertyName = "properties.upstream")]
        public ServerlessUpstreamSettings Upstream { get; set; }

        /// <summary>
        /// Gets or sets network ACLs
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkACLs")]
        public SignalRNetworkACLs NetworkACLs { get; set; }

        /// <summary>
        /// Gets provisioning state of the resource. Possible values include:
        /// 'Unknown', 'Succeeded', 'Failed', 'Canceled', 'Running',
        /// 'Creating', 'Updating', 'Deleting', 'Moving'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the publicly accessible IP of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalIP")]
        public string ExternalIP { get; private set; }

        /// <summary>
        /// Gets FQDN of the service instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; private set; }

        /// <summary>
        /// Gets the publicly accessible port of the resource which is designed
        /// for browser/client side usage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicPort")]
        public int? PublicPort { get; private set; }

        /// <summary>
        /// Gets the publicly accessible port of the resource which is designed
        /// for customer server side usage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverPort")]
        public int? ServerPort { get; private set; }

        /// <summary>
        /// Gets version of the resource. Probably you need the same or higher
        /// version of client SDKs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets private endpoint connections to the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets or sets TLS settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tls")]
        public SignalRTlsSettings Tls { get; set; }

        /// <summary>
        /// Gets or sets the kind of the service - e.g. "SignalR" for
        /// "Microsoft.SignalRService/SignalR". Possible values include:
        /// 'SignalR', 'RawWebSockets'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets the managed identity response
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ManagedIdentity Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (Features != null)
            {
                foreach (var element in Features)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
