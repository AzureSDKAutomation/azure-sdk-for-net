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
    /// The operation for configuring intrusion system.
    /// </summary>
    public partial class FirewallPolicyIntrusionSystemConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FirewallPolicyIntrusionSystemConfiguration class.
        /// </summary>
        public FirewallPolicyIntrusionSystemConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// FirewallPolicyIntrusionSystemConfiguration class.
        /// </summary>
        /// <param name="rules">List of specific rules states.</param>
        /// <param name="ignoredTraffic">List of rules for traffic to
        /// ignore.</param>
        /// <param name="allowChildPolicyToIgnoreTraffic">Boolean indicating
        /// whether child policies are allowed to have ignoredTraffic.</param>
        public FirewallPolicyIntrusionSystemConfiguration(IList<FirewallPolicyIntrusionSystemRuleSpecifications> rules = default(IList<FirewallPolicyIntrusionSystemRuleSpecifications>), IList<FirewallPolicyIntrusionSystemIgnoredTrafficSpecifications> ignoredTraffic = default(IList<FirewallPolicyIntrusionSystemIgnoredTrafficSpecifications>), bool? allowChildPolicyToIgnoreTraffic = default(bool?))
        {
            Rules = rules;
            IgnoredTraffic = ignoredTraffic;
            AllowChildPolicyToIgnoreTraffic = allowChildPolicyToIgnoreTraffic;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of specific rules states.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<FirewallPolicyIntrusionSystemRuleSpecifications> Rules { get; set; }

        /// <summary>
        /// Gets or sets list of rules for traffic to ignore.
        /// </summary>
        [JsonProperty(PropertyName = "ignoredTraffic")]
        public IList<FirewallPolicyIntrusionSystemIgnoredTrafficSpecifications> IgnoredTraffic { get; set; }

        /// <summary>
        /// Gets or sets boolean indicating whether child policies are allowed
        /// to have ignoredTraffic.
        /// </summary>
        [JsonProperty(PropertyName = "allowChildPolicyToIgnoreTraffic")]
        public bool? AllowChildPolicyToIgnoreTraffic { get; set; }

    }
}
