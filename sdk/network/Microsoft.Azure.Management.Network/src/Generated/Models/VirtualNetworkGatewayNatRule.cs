// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// VirtualNetworkGatewayNatRule Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualNetworkGatewayNatRule : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayNatRule
        /// class.
        /// </summary>
        public VirtualNetworkGatewayNatRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayNatRule
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="provisioningState">The provisioning state of the NAT
        /// Rule resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="virtualNetworkGatewayNatRulePropertiesType">The type
        /// of NAT rule for VPN NAT. Possible values include: 'Static',
        /// 'Dynamic'</param>
        /// <param name="mode">The Source NAT direction of a VPN NAT. Possible
        /// values include: 'EgressSnat', 'IngressSnat'</param>
        /// <param name="internalMappings">The private IP address internal
        /// mapping for NAT.</param>
        /// <param name="externalMappings">The private IP address external
        /// mapping for NAT.</param>
        /// <param name="ipConfigurationId">The IP Configuration ID this NAT
        /// rule applies to.</param>
        /// <param name="virtualNetworkGatewayConnections">List of
        /// VirtualNetworkGatewayConnections</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Resource type.</param>
        public VirtualNetworkGatewayNatRule(string id = default(string), string provisioningState = default(string), string virtualNetworkGatewayNatRulePropertiesType = default(string), string mode = default(string), IList<VpnNatRuleMapping> internalMappings = default(IList<VpnNatRuleMapping>), IList<VpnNatRuleMapping> externalMappings = default(IList<VpnNatRuleMapping>), string ipConfigurationId = default(string), IList<SubResource> virtualNetworkGatewayConnections = default(IList<SubResource>), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            ProvisioningState = provisioningState;
            VirtualNetworkGatewayNatRulePropertiesType = virtualNetworkGatewayNatRulePropertiesType;
            Mode = mode;
            InternalMappings = internalMappings;
            ExternalMappings = externalMappings;
            IpConfigurationId = ipConfigurationId;
            VirtualNetworkGatewayConnections = virtualNetworkGatewayConnections;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state of the NAT Rule resource. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the type of NAT rule for VPN NAT. Possible values
        /// include: 'Static', 'Dynamic'
        /// </summary>
        [JsonProperty(PropertyName = "properties.type")]
        public string VirtualNetworkGatewayNatRulePropertiesType { get; set; }

        /// <summary>
        /// Gets or sets the Source NAT direction of a VPN NAT. Possible values
        /// include: 'EgressSnat', 'IngressSnat'
        /// </summary>
        [JsonProperty(PropertyName = "properties.mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or sets the private IP address internal mapping for NAT.
        /// </summary>
        [JsonProperty(PropertyName = "properties.internalMappings")]
        public IList<VpnNatRuleMapping> InternalMappings { get; set; }

        /// <summary>
        /// Gets or sets the private IP address external mapping for NAT.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalMappings")]
        public IList<VpnNatRuleMapping> ExternalMappings { get; set; }

        /// <summary>
        /// Gets or sets the IP Configuration ID this NAT rule applies to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfigurationId")]
        public string IpConfigurationId { get; set; }

        /// <summary>
        /// Gets list of VirtualNetworkGatewayConnections
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkGatewayConnections")]
        public IList<SubResource> VirtualNetworkGatewayConnections { get; private set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
