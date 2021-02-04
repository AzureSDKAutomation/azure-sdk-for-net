// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Friendly RuleSet name mapping to the any RuleSet or secret related
    /// information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RuleSet : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the RuleSet class.
        /// </summary>
        public RuleSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RuleSet class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="provisioningState">Provisioning status. Possible
        /// values include: 'Succeeded', 'Failed', 'Updating', 'Deleting',
        /// 'Creating'</param>
        /// <param name="deploymentStatus">Possible values include:
        /// 'NotStarted', 'InProgress', 'Succeeded', 'Failed'</param>
        public RuleSet(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string provisioningState = default(string), string deploymentStatus = default(string))
            : base(id, name, type, systemData)
        {
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets provisioning status. Possible values include: 'Succeeded',
        /// 'Failed', 'Updating', 'Deleting', 'Creating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets possible values include: 'NotStarted', 'InProgress',
        /// 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.deploymentStatus")]
        public string DeploymentStatus { get; private set; }

    }
}
