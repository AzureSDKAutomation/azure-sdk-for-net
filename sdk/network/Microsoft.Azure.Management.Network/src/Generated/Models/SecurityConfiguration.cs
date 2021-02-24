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
    /// Defines the security Configuration
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SecurityConfiguration : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the SecurityConfiguration class.
        /// </summary>
        public SecurityConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityConfiguration class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="displayName">A display name of the security
        /// Configuration.</param>
        /// <param name="description">A description of the security
        /// Configuration.</param>
        /// <param name="securityType">Security Type. Possible values include:
        /// 'AdminPolicy', 'UserPolicy'</param>
        /// <param name="deleteExistingNSGs">Flag if need to delete existing
        /// network security groups.</param>
        /// <param name="appliesToGroups">Groups for configuration</param>
        /// <param name="provisioningState">The provisioning state of the scope
        /// assignment resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="systemData">The system metadata related to this
        /// resource.</param>
        public SecurityConfiguration(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), string displayName = default(string), string description = default(string), string securityType = default(string), bool? deleteExistingNSGs = default(bool?), IList<NetworkManagerSecurityGroupItem> appliesToGroups = default(IList<NetworkManagerSecurityGroupItem>), string provisioningState = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type, etag)
        {
            DisplayName = displayName;
            Description = description;
            SecurityType = securityType;
            DeleteExistingNSGs = deleteExistingNSGs;
            AppliesToGroups = appliesToGroups;
            ProvisioningState = provisioningState;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a display name of the security Configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets a description of the security Configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets security Type. Possible values include: 'AdminPolicy',
        /// 'UserPolicy'
        /// </summary>
        [JsonProperty(PropertyName = "properties.securityType")]
        public string SecurityType { get; set; }

        /// <summary>
        /// Gets or sets flag if need to delete existing network security
        /// groups.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deleteExistingNSGs")]
        public bool? DeleteExistingNSGs { get; set; }

        /// <summary>
        /// Gets or sets groups for configuration
        /// </summary>
        [JsonProperty(PropertyName = "properties.appliesToGroups")]
        public IList<NetworkManagerSecurityGroupItem> AppliesToGroups { get; set; }

        /// <summary>
        /// Gets the provisioning state of the scope assignment resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the system metadata related to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
