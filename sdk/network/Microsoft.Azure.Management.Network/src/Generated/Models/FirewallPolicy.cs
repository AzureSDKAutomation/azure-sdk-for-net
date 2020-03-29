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
    /// FirewallPolicy Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FirewallPolicy : Resource
    {
        /// <summary>
        /// Initializes a new instance of the FirewallPolicy class.
        /// </summary>
        public FirewallPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FirewallPolicy class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="ruleGroups">List of references to
        /// FirewallPolicyRuleGroups.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// firewall policy resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="basePolicy">The parent firewall policy from which
        /// rules are inherited.</param>
        /// <param name="firewalls">List of references to Azure Firewalls that
        /// this Firewall Policy is associated with.</param>
        /// <param name="childPolicies">List of references to Child Firewall
        /// Policies.</param>
        /// <param name="threatIntelMode">The operation mode for Threat
        /// Intelligence. Possible values include: 'Alert', 'Deny',
        /// 'Off'</param>
        /// <param name="intrusionSystemMode">The operation mode for Intrusion
        /// system. Possible values include: 'Alert', 'Deny', 'Off'</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public FirewallPolicy(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<SubResource> ruleGroups = default(IList<SubResource>), string provisioningState = default(string), SubResource basePolicy = default(SubResource), IList<SubResource> firewalls = default(IList<SubResource>), IList<SubResource> childPolicies = default(IList<SubResource>), string threatIntelMode = default(string), string intrusionSystemMode = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            RuleGroups = ruleGroups;
            ProvisioningState = provisioningState;
            BasePolicy = basePolicy;
            Firewalls = firewalls;
            ChildPolicies = childPolicies;
            ThreatIntelMode = threatIntelMode;
            IntrusionSystemMode = intrusionSystemMode;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of references to FirewallPolicyRuleGroups.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ruleGroups")]
        public IList<SubResource> RuleGroups { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the firewall policy resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the parent firewall policy from which rules are
        /// inherited.
        /// </summary>
        [JsonProperty(PropertyName = "properties.basePolicy")]
        public SubResource BasePolicy { get; set; }

        /// <summary>
        /// Gets list of references to Azure Firewalls that this Firewall
        /// Policy is associated with.
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewalls")]
        public IList<SubResource> Firewalls { get; private set; }

        /// <summary>
        /// Gets list of references to Child Firewall Policies.
        /// </summary>
        [JsonProperty(PropertyName = "properties.childPolicies")]
        public IList<SubResource> ChildPolicies { get; private set; }

        /// <summary>
        /// Gets or sets the operation mode for Threat Intelligence. Possible
        /// values include: 'Alert', 'Deny', 'Off'
        /// </summary>
        [JsonProperty(PropertyName = "properties.threatIntelMode")]
        public string ThreatIntelMode { get; set; }

        /// <summary>
        /// Gets or sets the operation mode for Intrusion system. Possible
        /// values include: 'Alert', 'Deny', 'Off'
        /// </summary>
        [JsonProperty(PropertyName = "properties.intrusionSystemMode")]
        public string IntrusionSystemMode { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
