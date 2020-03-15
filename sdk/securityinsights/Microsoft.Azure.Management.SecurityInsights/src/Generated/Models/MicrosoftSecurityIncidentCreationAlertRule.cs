// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents MicrosoftSecurityIncidentCreation rule.
    /// </summary>
    [Newtonsoft.Json.JsonObject("MicrosoftSecurityIncidentCreation")]
    [Rest.Serialization.JsonTransformation]
    public partial class MicrosoftSecurityIncidentCreationAlertRule : AlertRule
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftSecurityIncidentCreationAlertRule class.
        /// </summary>
        public MicrosoftSecurityIncidentCreationAlertRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftSecurityIncidentCreationAlertRule class.
        /// </summary>
        /// <param name="productFilter">The alerts' productName on which the
        /// cases will be generated. Possible values include: 'Microsoft Cloud
        /// App Security', 'Azure Security Center', 'Azure Advanced Threat
        /// Protection', 'Azure Active Directory Identity Protection', 'Azure
        /// Security Center for IoT'</param>
        /// <param name="displayName">The display name for alerts created by
        /// this alert rule.</param>
        /// <param name="enabled">Determines whether this alert rule is enabled
        /// or disabled.</param>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="etag">Etag of the azure resource</param>
        /// <param name="displayNamesFilter">the alerts' displayNames on which
        /// the cases will be generated</param>
        /// <param name="severitiesFilter">the alerts' severities on which the
        /// cases will be generated</param>
        /// <param name="alertRuleTemplateName">The Name of the alert rule
        /// template used to create this rule.</param>
        /// <param name="description">The description of the alert
        /// rule.</param>
        /// <param name="lastModifiedUtc">The last time that this alert has
        /// been modified.</param>
        public MicrosoftSecurityIncidentCreationAlertRule(string productFilter, string displayName, bool enabled, string id = default(string), string name = default(string), string type = default(string), string etag = default(string), IList<string> displayNamesFilter = default(IList<string>), IList<string> severitiesFilter = default(IList<string>), string alertRuleTemplateName = default(string), string description = default(string), System.DateTime? lastModifiedUtc = default(System.DateTime?))
            : base(id, name, type, etag)
        {
            DisplayNamesFilter = displayNamesFilter;
            ProductFilter = productFilter;
            SeveritiesFilter = severitiesFilter;
            AlertRuleTemplateName = alertRuleTemplateName;
            Description = description;
            DisplayName = displayName;
            Enabled = enabled;
            LastModifiedUtc = lastModifiedUtc;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the alerts' displayNames on which the cases will be
        /// generated
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayNamesFilter")]
        public IList<string> DisplayNamesFilter { get; set; }

        /// <summary>
        /// Gets or sets the alerts' productName on which the cases will be
        /// generated. Possible values include: 'Microsoft Cloud App Security',
        /// 'Azure Security Center', 'Azure Advanced Threat Protection', 'Azure
        /// Active Directory Identity Protection', 'Azure Security Center for
        /// IoT'
        /// </summary>
        [JsonProperty(PropertyName = "properties.productFilter")]
        public string ProductFilter { get; set; }

        /// <summary>
        /// Gets or sets the alerts' severities on which the cases will be
        /// generated
        /// </summary>
        [JsonProperty(PropertyName = "properties.severitiesFilter")]
        public IList<string> SeveritiesFilter { get; set; }

        /// <summary>
        /// Gets or sets the Name of the alert rule template used to create
        /// this rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertRuleTemplateName")]
        public string AlertRuleTemplateName { get; set; }

        /// <summary>
        /// Gets or sets the description of the alert rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the display name for alerts created by this alert
        /// rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets determines whether this alert rule is enabled or
        /// disabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets the last time that this alert has been modified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedUtc")]
        public System.DateTime? LastModifiedUtc { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ProductFilter == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProductFilter");
            }
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
        }
    }
}
