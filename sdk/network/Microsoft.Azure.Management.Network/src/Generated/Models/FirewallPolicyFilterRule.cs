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
    /// Firewall Policy Filter Rule.
    /// </summary>
    [Newtonsoft.Json.JsonObject("FirewallPolicyFilterRule")]
    public partial class FirewallPolicyFilterRule : FirewallPolicyRule
    {
        /// <summary>
        /// Initializes a new instance of the FirewallPolicyFilterRule class.
        /// </summary>
        public FirewallPolicyFilterRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FirewallPolicyFilterRule class.
        /// </summary>
        /// <param name="name">The name of the rule.</param>
        /// <param name="priority">Priority of the Firewall Policy Rule
        /// resource.</param>
        /// <param name="action">The action type of a Filter rule.</param>
        /// <param name="ruleConditions">Collection of rule conditions used by
        /// a rule.</param>
        public FirewallPolicyFilterRule(string name = default(string), int? priority = default(int?), FirewallPolicyFilterRuleAction action = default(FirewallPolicyFilterRuleAction), IList<FirewallPolicyRuleCondition> ruleConditions = default(IList<FirewallPolicyRuleCondition>))
            : base(name, priority)
        {
            Action = action;
            RuleConditions = ruleConditions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the action type of a Filter rule.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public FirewallPolicyFilterRuleAction Action { get; set; }

        /// <summary>
        /// Gets or sets collection of rule conditions used by a rule.
        /// </summary>
        [JsonProperty(PropertyName = "ruleConditions")]
        public IList<FirewallPolicyRuleCondition> RuleConditions { get; set; }

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
