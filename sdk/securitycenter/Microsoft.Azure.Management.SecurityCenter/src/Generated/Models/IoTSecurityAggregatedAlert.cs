// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Security Solution Aggregated Alert information
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IoTSecurityAggregatedAlert
    {
        /// <summary>
        /// Initializes a new instance of the IoTSecurityAggregatedAlert class.
        /// </summary>
        public IoTSecurityAggregatedAlert()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IoTSecurityAggregatedAlert class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="alertType">Name of the alert type</param>
        /// <param name="alertDisplayName">Display name of the alert
        /// type</param>
        /// <param name="aggregatedDateUtc">The date the incidents were
        /// detected by the vendor</param>
        /// <param name="vendorName">Name of the vendor that discovered the
        /// incident</param>
        /// <param name="reportedSeverity">Estimated severity of this alert.
        /// Possible values include: 'Informational', 'Low', 'Medium',
        /// 'High'</param>
        /// <param name="remediationSteps">Recommended steps for
        /// remediation</param>
        /// <param name="description">Description of the incident and what it
        /// means</param>
        /// <param name="count">Occurrence number of the alert within the
        /// aggregated date</param>
        /// <param name="effectedResourceType">Azure resource ID of the
        /// resource that got the alerts</param>
        /// <param name="systemSource">The type of the alerted resource (Azure,
        /// Non-Azure)</param>
        /// <param name="actionTaken">The action that was taken as a response
        /// to the alert (Active, Blocked etc.)</param>
        /// <param name="logAnalyticsQuery">query in log analytics to get the
        /// list of affected devices/alerts</param>
        public IoTSecurityAggregatedAlert(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string alertType = default(string), string alertDisplayName = default(string), System.DateTime? aggregatedDateUtc = default(System.DateTime?), string vendorName = default(string), string reportedSeverity = default(string), string remediationSteps = default(string), string description = default(string), int? count = default(int?), string effectedResourceType = default(string), string systemSource = default(string), string actionTaken = default(string), string logAnalyticsQuery = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            Tags = tags;
            AlertType = alertType;
            AlertDisplayName = alertDisplayName;
            AggregatedDateUtc = aggregatedDateUtc;
            VendorName = vendorName;
            ReportedSeverity = reportedSeverity;
            RemediationSteps = remediationSteps;
            Description = description;
            Count = count;
            EffectedResourceType = effectedResourceType;
            SystemSource = systemSource;
            ActionTaken = actionTaken;
            LogAnalyticsQuery = logAnalyticsQuery;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets name of the alert type
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertType")]
        public string AlertType { get; private set; }

        /// <summary>
        /// Gets display name of the alert type
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertDisplayName")]
        public string AlertDisplayName { get; private set; }

        /// <summary>
        /// Gets the date the incidents were detected by the vendor
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "properties.aggregatedDateUtc")]
        public System.DateTime? AggregatedDateUtc { get; private set; }

        /// <summary>
        /// Gets name of the vendor that discovered the incident
        /// </summary>
        [JsonProperty(PropertyName = "properties.vendorName")]
        public string VendorName { get; private set; }

        /// <summary>
        /// Gets estimated severity of this alert. Possible values include:
        /// 'Informational', 'Low', 'Medium', 'High'
        /// </summary>
        [JsonProperty(PropertyName = "properties.reportedSeverity")]
        public string ReportedSeverity { get; private set; }

        /// <summary>
        /// Gets recommended steps for remediation
        /// </summary>
        [JsonProperty(PropertyName = "properties.remediationSteps")]
        public string RemediationSteps { get; private set; }

        /// <summary>
        /// Gets description of the incident and what it means
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets occurrence number of the alert within the aggregated date
        /// </summary>
        [JsonProperty(PropertyName = "properties.count")]
        public int? Count { get; private set; }

        /// <summary>
        /// Gets azure resource ID of the resource that got the alerts
        /// </summary>
        [JsonProperty(PropertyName = "properties.effectedResourceType")]
        public string EffectedResourceType { get; private set; }

        /// <summary>
        /// Gets the type of the alerted resource (Azure, Non-Azure)
        /// </summary>
        [JsonProperty(PropertyName = "properties.systemSource")]
        public string SystemSource { get; private set; }

        /// <summary>
        /// Gets the action that was taken as a response to the alert (Active,
        /// Blocked etc.)
        /// </summary>
        [JsonProperty(PropertyName = "properties.actionTaken")]
        public string ActionTaken { get; private set; }

        /// <summary>
        /// Gets query in log analytics to get the list of affected
        /// devices/alerts
        /// </summary>
        [JsonProperty(PropertyName = "properties.logAnalyticsQuery")]
        public string LogAnalyticsQuery { get; private set; }

    }
}
