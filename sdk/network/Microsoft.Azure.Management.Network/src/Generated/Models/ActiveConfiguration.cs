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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Active Configuration.
    /// </summary>
    public partial class ActiveConfiguration : EffectiveConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the ActiveConfiguration class.
        /// </summary>
        public ActiveConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActiveConfiguration class.
        /// </summary>
        /// <param name="configType">Effective configuration. Possible values
        /// include: 'AdminPolicy', 'UserPolicy', 'Connectivity'</param>
        /// <param name="connectivityConfiguration">Connectivity configuration
        /// object.</param>
        /// <param name="securityAdminRule">Security admin rule object.</param>
        /// <param name="securityUserRule">Security user rule object.</param>
        /// <param name="configurationGroups">Effective configuration
        /// groups.</param>
        /// <param name="commitTime">Deployment time string.</param>
        /// <param name="region">Deployment region.</param>
        public ActiveConfiguration(string configType = default(string), ConnectivityConfiguration connectivityConfiguration = default(ConnectivityConfiguration), AdminRule securityAdminRule = default(AdminRule), UserRule securityUserRule = default(UserRule), IList<NetworkGroup> configurationGroups = default(IList<NetworkGroup>), System.DateTime? commitTime = default(System.DateTime?), string region = default(string))
            : base(configType, connectivityConfiguration, securityAdminRule, securityUserRule, configurationGroups)
        {
            CommitTime = commitTime;
            Region = region;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets deployment time string.
        /// </summary>
        [JsonProperty(PropertyName = "commitTime")]
        public System.DateTime? CommitTime { get; set; }

        /// <summary>
        /// Gets or sets deployment region.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
