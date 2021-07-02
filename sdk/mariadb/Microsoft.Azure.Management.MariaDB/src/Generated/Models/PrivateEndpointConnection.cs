// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MariaDB.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A private endpoint connection
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PrivateEndpointConnection : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the PrivateEndpointConnection class.
        /// </summary>
        public PrivateEndpointConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateEndpointConnection class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="privateEndpoint">Private endpoint which the connection
        /// belongs to.</param>
        /// <param name="privateLinkServiceConnectionState">Connection state of
        /// the private endpoint connection.</param>
        /// <param name="provisioningState">State of the private endpoint
        /// connection.</param>
        public PrivateEndpointConnection(string id = default(string), string name = default(string), string type = default(string), PrivateEndpointProperty privateEndpoint = default(PrivateEndpointProperty), PrivateLinkServiceConnectionStateProperty privateLinkServiceConnectionState = default(PrivateLinkServiceConnectionStateProperty), string provisioningState = default(string))
            : base(id, name, type)
        {
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets private endpoint which the connection belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpoint")]
        public PrivateEndpointProperty PrivateEndpoint { get; set; }

        /// <summary>
        /// Gets or sets connection state of the private endpoint connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkServiceConnectionState")]
        public PrivateLinkServiceConnectionStateProperty PrivateLinkServiceConnectionState { get; set; }

        /// <summary>
        /// Gets state of the private endpoint connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PrivateLinkServiceConnectionState != null)
            {
                PrivateLinkServiceConnectionState.Validate();
            }
        }
    }
}
