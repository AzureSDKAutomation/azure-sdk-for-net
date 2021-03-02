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
    /// The Managed Network resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NetworkManager : Resource
    {
        /// <summary>
        /// Initializes a new instance of the NetworkManager class.
        /// </summary>
        public NetworkManager()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkManager class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="displayName">A friendly name for the network
        /// manager.</param>
        /// <param name="description">A description of the network
        /// manager.</param>
        /// <param name="networkManagerScopes">Scope of Network
        /// Manager.</param>
        /// <param name="networkManagerScopeAccesses">Scope Access.</param>
        /// <param name="provisioningState">The provisioning state of the scope
        /// assignment resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="systemData">The system metadata related to this
        /// resource.</param>
        public NetworkManager(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string displayName = default(string), string description = default(string), NetworkManagerPropertiesNetworkManagerScopes networkManagerScopes = default(NetworkManagerPropertiesNetworkManagerScopes), IList<string> networkManagerScopeAccesses = default(IList<string>), string provisioningState = default(string), string etag = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type, location, tags)
        {
            DisplayName = displayName;
            Description = description;
            NetworkManagerScopes = networkManagerScopes;
            NetworkManagerScopeAccesses = networkManagerScopeAccesses;
            ProvisioningState = provisioningState;
            Etag = etag;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a friendly name for the network manager.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets a description of the network manager.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets scope of Network Manager.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkManagerScopes")]
        public NetworkManagerPropertiesNetworkManagerScopes NetworkManagerScopes { get; set; }

        /// <summary>
        /// Gets or sets scope Access.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkManagerScopeAccesses")]
        public IList<string> NetworkManagerScopeAccesses { get; set; }

        /// <summary>
        /// Gets the provisioning state of the scope assignment resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets the system metadata related to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
