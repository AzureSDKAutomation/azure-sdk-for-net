// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Full view of networking configuration for an ASE.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AseV3NetworkingConfiguration : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the AseV3NetworkingConfiguration
        /// class.
        /// </summary>
        public AseV3NetworkingConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AseV3NetworkingConfiguration
        /// class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="allowNewPrivateEndpointConnections">Property to enable
        /// and disable new private endpoint connection creation on ASE</param>
        public AseV3NetworkingConfiguration(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), IList<string> windowsOutboundIpAddresses = default(IList<string>), IList<string> linuxOutboundIpAddresses = default(IList<string>), IList<string> externalInboundIpAddresses = default(IList<string>), IList<string> internalInboundIpAddresses = default(IList<string>), bool? allowNewPrivateEndpointConnections = default(bool?))
            : base(id, name, kind, type, systemData)
        {
            WindowsOutboundIpAddresses = windowsOutboundIpAddresses;
            LinuxOutboundIpAddresses = linuxOutboundIpAddresses;
            ExternalInboundIpAddresses = externalInboundIpAddresses;
            InternalInboundIpAddresses = internalInboundIpAddresses;
            AllowNewPrivateEndpointConnections = allowNewPrivateEndpointConnections;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.windowsOutboundIpAddresses")]
        public IList<string> WindowsOutboundIpAddresses { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.linuxOutboundIpAddresses")]
        public IList<string> LinuxOutboundIpAddresses { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalInboundIpAddresses")]
        public IList<string> ExternalInboundIpAddresses { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.internalInboundIpAddresses")]
        public IList<string> InternalInboundIpAddresses { get; private set; }

        /// <summary>
        /// Gets or sets property to enable and disable new private endpoint
        /// connection creation on ASE
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowNewPrivateEndpointConnections")]
        public bool? AllowNewPrivateEndpointConnections { get; set; }

    }
}
