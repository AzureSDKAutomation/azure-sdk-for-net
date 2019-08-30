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
    /// Subnet in a virtual network resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Subnet : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the Subnet class.
        /// </summary>
        public Subnet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Subnet class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="addressPrefix">The address prefix for the
        /// subnet.</param>
        /// <param name="addressPrefixes">List of address prefixes for the
        /// subnet.</param>
        /// <param name="networkSecurityGroup">The reference of the
        /// NetworkSecurityGroup resource.</param>
        /// <param name="routeTable">The reference of the RouteTable
        /// resource.</param>
        /// <param name="natGateway">Nat gateway associated with this
        /// subnet.</param>
        /// <param name="serviceEndpoints">An array of service
        /// endpoints.</param>
        /// <param name="serviceEndpointPolicies">An array of service endpoint
        /// policies.</param>
        /// <param name="privateEndpoints">An array of references to private
        /// endpoints.</param>
        /// <param name="ipConfigurations">An array of references to the
        /// network interface IP configurations using subnet.</param>
        /// <param name="ipConfigurationProfiles">Array of IP configuration
        /// profiles which reference this subnet.</param>
        /// <param name="resourceNavigationLinks">An array of references to the
        /// external resources using subnet.</param>
        /// <param name="serviceAssociationLinks">An array of references to
        /// services injecting into this subnet.</param>
        /// <param name="delegations">An array of references to the delegations
        /// on the subnet.</param>
        /// <param name="purpose">A read-only string identifying the intention
        /// of use for this subnet based on delegations and other user-defined
        /// properties.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// subnet resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="privateEndpointNetworkPolicies">Enable or Disable
        /// apply network policies on private end point in the subnet.</param>
        /// <param name="privateLinkServiceNetworkPolicies">Enable or Disable
        /// apply network policies on private link service in the
        /// subnet.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public Subnet(string id = default(string), string addressPrefix = default(string), IList<string> addressPrefixes = default(IList<string>), NetworkSecurityGroup networkSecurityGroup = default(NetworkSecurityGroup), RouteTable routeTable = default(RouteTable), SubResource natGateway = default(SubResource), IList<ServiceEndpointPropertiesFormat> serviceEndpoints = default(IList<ServiceEndpointPropertiesFormat>), IList<ServiceEndpointPolicy> serviceEndpointPolicies = default(IList<ServiceEndpointPolicy>), IList<PrivateEndpoint> privateEndpoints = default(IList<PrivateEndpoint>), IList<IPConfiguration> ipConfigurations = default(IList<IPConfiguration>), IList<IPConfigurationProfile> ipConfigurationProfiles = default(IList<IPConfigurationProfile>), IList<ResourceNavigationLink> resourceNavigationLinks = default(IList<ResourceNavigationLink>), IList<ServiceAssociationLink> serviceAssociationLinks = default(IList<ServiceAssociationLink>), IList<Delegation> delegations = default(IList<Delegation>), string purpose = default(string), string provisioningState = default(string), string privateEndpointNetworkPolicies = default(string), string privateLinkServiceNetworkPolicies = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            AddressPrefix = addressPrefix;
            AddressPrefixes = addressPrefixes;
            NetworkSecurityGroup = networkSecurityGroup;
            RouteTable = routeTable;
            NatGateway = natGateway;
            ServiceEndpoints = serviceEndpoints;
            ServiceEndpointPolicies = serviceEndpointPolicies;
            PrivateEndpoints = privateEndpoints;
            IpConfigurations = ipConfigurations;
            IpConfigurationProfiles = ipConfigurationProfiles;
            ResourceNavigationLinks = resourceNavigationLinks;
            ServiceAssociationLinks = serviceAssociationLinks;
            Delegations = delegations;
            Purpose = purpose;
            ProvisioningState = provisioningState;
            PrivateEndpointNetworkPolicies = privateEndpointNetworkPolicies;
            PrivateLinkServiceNetworkPolicies = privateLinkServiceNetworkPolicies;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the address prefix for the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.addressPrefix")]
        public string AddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets list of address prefixes for the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.addressPrefixes")]
        public IList<string> AddressPrefixes { get; set; }

        /// <summary>
        /// Gets or sets the reference of the NetworkSecurityGroup resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkSecurityGroup")]
        public NetworkSecurityGroup NetworkSecurityGroup { get; set; }

        /// <summary>
        /// Gets or sets the reference of the RouteTable resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routeTable")]
        public RouteTable RouteTable { get; set; }

        /// <summary>
        /// Gets or sets nat gateway associated with this subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.natGateway")]
        public SubResource NatGateway { get; set; }

        /// <summary>
        /// Gets or sets an array of service endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceEndpoints")]
        public IList<ServiceEndpointPropertiesFormat> ServiceEndpoints { get; set; }

        /// <summary>
        /// Gets or sets an array of service endpoint policies.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceEndpointPolicies")]
        public IList<ServiceEndpointPolicy> ServiceEndpointPolicies { get; set; }

        /// <summary>
        /// Gets an array of references to private endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpoints")]
        public IList<PrivateEndpoint> PrivateEndpoints { get; private set; }

        /// <summary>
        /// Gets an array of references to the network interface IP
        /// configurations using subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfigurations")]
        public IList<IPConfiguration> IpConfigurations { get; private set; }

        /// <summary>
        /// Gets array of IP configuration profiles which reference this
        /// subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfigurationProfiles")]
        public IList<IPConfigurationProfile> IpConfigurationProfiles { get; private set; }

        /// <summary>
        /// Gets or sets an array of references to the external resources using
        /// subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceNavigationLinks")]
        public IList<ResourceNavigationLink> ResourceNavigationLinks { get; set; }

        /// <summary>
        /// Gets or sets an array of references to services injecting into this
        /// subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceAssociationLinks")]
        public IList<ServiceAssociationLink> ServiceAssociationLinks { get; set; }

        /// <summary>
        /// Gets or sets an array of references to the delegations on the
        /// subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.delegations")]
        public IList<Delegation> Delegations { get; set; }

        /// <summary>
        /// Gets a read-only string identifying the intention of use for this
        /// subnet based on delegations and other user-defined properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.purpose")]
        public string Purpose { get; private set; }

        /// <summary>
        /// Gets or sets the provisioning state of the subnet resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets enable or Disable apply network policies on private
        /// end point in the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointNetworkPolicies")]
        public string PrivateEndpointNetworkPolicies { get; set; }

        /// <summary>
        /// Gets or sets enable or Disable apply network policies on private
        /// link service in the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkServiceNetworkPolicies")]
        public string PrivateLinkServiceNetworkPolicies { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
