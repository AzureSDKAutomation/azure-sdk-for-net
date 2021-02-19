// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An object that represents a container registry.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Registry : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Registry class.
        /// </summary>
        public Registry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Registry class.
        /// </summary>
        /// <param name="location">The location of the resource. This cannot be
        /// changed after the resource is created.</param>
        /// <param name="sku">The SKU of the container registry.</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the resource.</param>
        /// <param name="identity">The identity of the container
        /// registry.</param>
        /// <param name="loginServer">The URL that can be used to log into the
        /// container registry.</param>
        /// <param name="creationDate">The creation date of the container
        /// registry in ISO8601 format.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// container registry at the time the operation was called. Possible
        /// values include: 'Creating', 'Updating', 'Deleting', 'Succeeded',
        /// 'Failed', 'Canceled'</param>
        /// <param name="status">The status of the container registry at the
        /// time the operation was called.</param>
        /// <param name="adminUserEnabled">The value that indicates whether the
        /// admin user is enabled.</param>
        /// <param name="networkRuleSet">The network rule set for a container
        /// registry.</param>
        /// <param name="policies">The policies for a container
        /// registry.</param>
        /// <param name="encryption">The encryption settings of container
        /// registry.</param>
        /// <param name="dataEndpointEnabled">Enable a single data endpoint per
        /// region for serving data.</param>
        /// <param name="dataEndpointHostNames">List of host names that will
        /// serve data when dataEndpointEnabled is true.</param>
        /// <param name="privateEndpointConnections">List of private endpoint
        /// connections for a container registry.</param>
        /// <param name="publicNetworkAccess">Whether or not public network
        /// access is allowed for the container registry. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="networkRuleBypassOptions">Whether to allow trusted
        /// Azure services to access a network restricted registry. Possible
        /// values include: 'AzureServices', 'None'</param>
        /// <param name="zoneRedundancy">Whether or not zone redundancy is
        /// enabled for this container registry. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="anonymousPullEnabled">Enable registry-wide pull from
        /// unauthenticated clients.</param>
        public Registry(string location, Sku sku, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SystemData systemData = default(SystemData), IdentityProperties identity = default(IdentityProperties), string loginServer = default(string), System.DateTime? creationDate = default(System.DateTime?), string provisioningState = default(string), Status status = default(Status), bool? adminUserEnabled = default(bool?), NetworkRuleSet networkRuleSet = default(NetworkRuleSet), Policies policies = default(Policies), EncryptionProperty encryption = default(EncryptionProperty), bool? dataEndpointEnabled = default(bool?), IList<string> dataEndpointHostNames = default(IList<string>), IList<PrivateEndpointConnection> privateEndpointConnections = default(IList<PrivateEndpointConnection>), string publicNetworkAccess = default(string), string networkRuleBypassOptions = default(string), string zoneRedundancy = default(string), bool? anonymousPullEnabled = default(bool?))
            : base(location, id, name, type, tags, systemData)
        {
            Sku = sku;
            Identity = identity;
            LoginServer = loginServer;
            CreationDate = creationDate;
            ProvisioningState = provisioningState;
            Status = status;
            AdminUserEnabled = adminUserEnabled;
            NetworkRuleSet = networkRuleSet;
            Policies = policies;
            Encryption = encryption;
            DataEndpointEnabled = dataEndpointEnabled;
            DataEndpointHostNames = dataEndpointHostNames;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            NetworkRuleBypassOptions = networkRuleBypassOptions;
            ZoneRedundancy = zoneRedundancy;
            AnonymousPullEnabled = anonymousPullEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SKU of the container registry.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the identity of the container registry.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public IdentityProperties Identity { get; set; }

        /// <summary>
        /// Gets the URL that can be used to log into the container registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loginServer")]
        public string LoginServer { get; private set; }

        /// <summary>
        /// Gets the creation date of the container registry in ISO8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the container registry at the time
        /// the operation was called. Possible values include: 'Creating',
        /// 'Updating', 'Deleting', 'Succeeded', 'Failed', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the status of the container registry at the time the operation
        /// was called.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public Status Status { get; private set; }

        /// <summary>
        /// Gets or sets the value that indicates whether the admin user is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.adminUserEnabled")]
        public bool? AdminUserEnabled { get; set; }

        /// <summary>
        /// Gets or sets the network rule set for a container registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkRuleSet")]
        public NetworkRuleSet NetworkRuleSet { get; set; }

        /// <summary>
        /// Gets or sets the policies for a container registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.policies")]
        public Policies Policies { get; set; }

        /// <summary>
        /// Gets or sets the encryption settings of container registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public EncryptionProperty Encryption { get; set; }

        /// <summary>
        /// Gets or sets enable a single data endpoint per region for serving
        /// data.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataEndpointEnabled")]
        public bool? DataEndpointEnabled { get; set; }

        /// <summary>
        /// Gets list of host names that will serve data when
        /// dataEndpointEnabled is true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataEndpointHostNames")]
        public IList<string> DataEndpointHostNames { get; private set; }

        /// <summary>
        /// Gets list of private endpoint connections for a container registry.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets or sets whether or not public network access is allowed for
        /// the container registry. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets whether to allow trusted Azure services to access a
        /// network restricted registry. Possible values include:
        /// 'AzureServices', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkRuleBypassOptions")]
        public string NetworkRuleBypassOptions { get; set; }

        /// <summary>
        /// Gets or sets whether or not zone redundancy is enabled for this
        /// container registry. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.zoneRedundancy")]
        public string ZoneRedundancy { get; set; }

        /// <summary>
        /// Gets or sets enable registry-wide pull from unauthenticated
        /// clients.
        /// </summary>
        [JsonProperty(PropertyName = "properties.anonymousPullEnabled")]
        public bool? AnonymousPullEnabled { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (NetworkRuleSet != null)
            {
                NetworkRuleSet.Validate();
            }
        }
    }
}
