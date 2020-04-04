// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A workspace
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Workspace : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Workspace class.
        /// </summary>
        public Workspace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Workspace class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="defaultDataLakeStorage">Workspace default data lake
        /// storage account details</param>
        /// <param name="sqlAdministratorLoginPassword">SQL administrator login
        /// password</param>
        /// <param name="managedResourceGroupName">Workspace managed resource
        /// group</param>
        /// <param name="provisioningState">Resource provisioning state</param>
        /// <param name="sqlAdministratorLogin">Login for workspace SQL active
        /// directory administrator</param>
        /// <param name="virtualNetworkProfile">Virtual Network profile</param>
        /// <param name="connectivityEndpoints">Connectivity endpoints</param>
        /// <param name="managedVirtualNetwork">Setting this to 'default' will
        /// ensure that all compute for this workspace is in a virtual network
        /// managed on behalf of the user.</param>
        /// <param name="privateEndpointConnections">Private endpoint
        /// connections to the workspace</param>
        /// <param name="identity">Identity of the workspace</param>
        public Workspace(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), DataLakeStorageAccountDetails defaultDataLakeStorage = default(DataLakeStorageAccountDetails), string sqlAdministratorLoginPassword = default(string), string managedResourceGroupName = default(string), string provisioningState = default(string), string sqlAdministratorLogin = default(string), VirtualNetworkProfile virtualNetworkProfile = default(VirtualNetworkProfile), IDictionary<string, string> connectivityEndpoints = default(IDictionary<string, string>), string managedVirtualNetwork = default(string), IList<PrivateEndpointConnection> privateEndpointConnections = default(IList<PrivateEndpointConnection>), ManagedIdentity identity = default(ManagedIdentity))
            : base(location, id, name, type, tags)
        {
            DefaultDataLakeStorage = defaultDataLakeStorage;
            SqlAdministratorLoginPassword = sqlAdministratorLoginPassword;
            ManagedResourceGroupName = managedResourceGroupName;
            ProvisioningState = provisioningState;
            SqlAdministratorLogin = sqlAdministratorLogin;
            VirtualNetworkProfile = virtualNetworkProfile;
            ConnectivityEndpoints = connectivityEndpoints;
            ManagedVirtualNetwork = managedVirtualNetwork;
            PrivateEndpointConnections = privateEndpointConnections;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets workspace default data lake storage account details
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultDataLakeStorage")]
        public DataLakeStorageAccountDetails DefaultDataLakeStorage { get; set; }

        /// <summary>
        /// Gets or sets SQL administrator login password
        /// </summary>
        [JsonProperty(PropertyName = "properties.sqlAdministratorLoginPassword")]
        public string SqlAdministratorLoginPassword { get; set; }

        /// <summary>
        /// Gets workspace managed resource group
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedResourceGroupName")]
        public string ManagedResourceGroupName { get; private set; }

        /// <summary>
        /// Gets resource provisioning state
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets login for workspace SQL active directory administrator
        /// </summary>
        [JsonProperty(PropertyName = "properties.sqlAdministratorLogin")]
        public string SqlAdministratorLogin { get; set; }

        /// <summary>
        /// Gets or sets virtual Network profile
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkProfile")]
        public VirtualNetworkProfile VirtualNetworkProfile { get; set; }

        /// <summary>
        /// Gets or sets connectivity endpoints
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectivityEndpoints")]
        public IDictionary<string, string> ConnectivityEndpoints { get; set; }

        /// <summary>
        /// Gets or sets setting this to 'default' will ensure that all compute
        /// for this workspace is in a virtual network managed on behalf of the
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedVirtualNetwork")]
        public string ManagedVirtualNetwork { get; set; }

        /// <summary>
        /// Gets or sets private endpoint connections to the workspace
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; set; }

        /// <summary>
        /// Gets or sets identity of the workspace
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ManagedIdentity Identity { get; set; }

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
