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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of the rule collection.
    /// </summary>
    [Newtonsoft.Json.JsonObject("FirewallPolicyRuleCollection")]
    public partial class FirewallPolicyRuleCollection
    {
        /// <summary>
        /// Initializes a new instance of the FirewallPolicyRuleCollection
        /// class.
        /// </summary>
        public FirewallPolicyRuleCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FirewallPolicyRuleCollection
        /// class.
        /// </summary>
        /// <param name="name">The name of the rule collection.</param>
        /// <param name="priority">Priority of the Firewall Policy Rule
        /// Collection resource.</param>
        public FirewallPolicyRuleCollection(string name = default(string), int? priority = default(int?))
        {
            Name = name;
            Priority = priority;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the rule collection.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets priority of the Firewall Policy Rule Collection
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Priority > 65000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Priority", 65000);
            }
            if (Priority < 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Priority", 100);
            }
        }
    }
}
