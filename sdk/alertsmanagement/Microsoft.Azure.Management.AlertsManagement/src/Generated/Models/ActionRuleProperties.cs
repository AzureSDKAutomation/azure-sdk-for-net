// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Action rule properties defining scope, conditions, suppression logic
    /// for action rule
    /// </summary>
    [Newtonsoft.Json.JsonObject("ActionRuleProperties")]
    public partial class ActionRuleProperties
    {
        /// <summary>
        /// Initializes a new instance of the ActionRuleProperties class.
        /// </summary>
        public ActionRuleProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActionRuleProperties class.
        /// </summary>
        /// <param name="scope">scope on which action rule will apply</param>
        /// <param name="conditions">conditions on which alerts will be
        /// filtered</param>
        /// <param name="description">Description of action rule</param>
        /// <param name="createdAt">Creation time of action rule. Date-Time in
        /// ISO-8601 format.</param>
        /// <param name="lastModifiedAt">Last updated time of action rule.
        /// Date-Time in ISO-8601 format.</param>
        /// <param name="createdBy">Created by user name.</param>
        /// <param name="lastModifiedBy">Last modified by user name.</param>
        /// <param name="status">Indicates if the given action rule is enabled
        /// or disabled. Possible values include: 'Enabled', 'Disabled'</param>
        public ActionRuleProperties(Scope scope = default(Scope), Conditions conditions = default(Conditions), string description = default(string), System.DateTime? createdAt = default(System.DateTime?), System.DateTime? lastModifiedAt = default(System.DateTime?), string createdBy = default(string), string lastModifiedBy = default(string), string status = default(string))
        {
            Scope = scope;
            Conditions = conditions;
            Description = description;
            CreatedAt = createdAt;
            LastModifiedAt = lastModifiedAt;
            CreatedBy = createdBy;
            LastModifiedBy = lastModifiedBy;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets scope on which action rule will apply
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public Scope Scope { get; set; }

        /// <summary>
        /// Gets or sets conditions on which alerts will be filtered
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public Conditions Conditions { get; set; }

        /// <summary>
        /// Gets or sets description of action rule
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets creation time of action rule. Date-Time in ISO-8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets last updated time of action rule. Date-Time in ISO-8601
        /// format.
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedAt")]
        public System.DateTime? LastModifiedAt { get; private set; }

        /// <summary>
        /// Gets created by user name.
        /// </summary>
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; private set; }

        /// <summary>
        /// Gets last modified by user name.
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedBy")]
        public string LastModifiedBy { get; private set; }

        /// <summary>
        /// Gets or sets indicates if the given action rule is enabled or
        /// disabled. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}
