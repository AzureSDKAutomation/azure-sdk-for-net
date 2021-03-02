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
    /// The network manager effective configuration
    /// </summary>
    public partial class EffectiveConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the EffectiveConfiguration class.
        /// </summary>
        public EffectiveConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EffectiveConfiguration class.
        /// </summary>
        /// <param name="configType">Effective configuration. Possible values
        /// include: 'AdminPolicy', 'UserPolicy', 'Connectivity'</param>
        /// <param name="connectivityConfiguration">Connectivity configuration
        /// object.</param>
        /// <param name="securityAdminRule">Security admin rule object.</param>
        /// <param name="securityUserRule">Security user rule object.</param>
        /// <param name="configurationGroups">Effective configuration
        /// groups.</param>
        public EffectiveConfiguration(string configType = default(string), ConnectivityConfiguration connectivityConfiguration = default(ConnectivityConfiguration), AdminRule securityAdminRule = default(AdminRule), UserRule securityUserRule = default(UserRule), IList<NetworkGroup> configurationGroups = default(IList<NetworkGroup>))
        {
            ConfigType = configType;
            ConnectivityConfiguration = connectivityConfiguration;
            SecurityAdminRule = securityAdminRule;
            SecurityUserRule = securityUserRule;
            ConfigurationGroups = configurationGroups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets effective configuration. Possible values include:
        /// 'AdminPolicy', 'UserPolicy', 'Connectivity'
        /// </summary>
        [JsonProperty(PropertyName = "configType")]
        public string ConfigType { get; set; }

        /// <summary>
        /// Gets or sets connectivity configuration object.
        /// </summary>
        [JsonProperty(PropertyName = "connectivityConfiguration")]
        public ConnectivityConfiguration ConnectivityConfiguration { get; set; }

        /// <summary>
        /// Gets or sets security admin rule object.
        /// </summary>
        [JsonProperty(PropertyName = "securityAdminRule")]
        public AdminRule SecurityAdminRule { get; set; }

        /// <summary>
        /// Gets or sets security user rule object.
        /// </summary>
        [JsonProperty(PropertyName = "securityUserRule")]
        public UserRule SecurityUserRule { get; set; }

        /// <summary>
        /// Gets or sets effective configuration groups.
        /// </summary>
        [JsonProperty(PropertyName = "configurationGroups")]
        public IList<NetworkGroup> ConfigurationGroups { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ConnectivityConfiguration != null)
            {
                ConnectivityConfiguration.Validate();
            }
            if (SecurityAdminRule != null)
            {
                SecurityAdminRule.Validate();
            }
            if (SecurityUserRule != null)
            {
                SecurityUserRule.Validate();
            }
        }
    }
}
