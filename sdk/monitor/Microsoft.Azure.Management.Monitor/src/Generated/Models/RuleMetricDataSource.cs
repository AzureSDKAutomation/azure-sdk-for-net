// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A rule metric data source. The discriminator value is always
    /// RuleMetricDataSource in this case.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Azure.Management.Insights.Models.RuleMetricDataSource")]
    public partial class RuleMetricDataSource : RuleDataSource
    {
        /// <summary>
        /// Initializes a new instance of the RuleMetricDataSource class.
        /// </summary>
        public RuleMetricDataSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RuleMetricDataSource class.
        /// </summary>
        /// <param name="resourceUri">the resource identifier of the resource
        /// the rule monitors. **NOTE**: this property cannot be updated for an
        /// existing rule.</param>
        /// <param name="legacyResourceId">the legacy resource identifier of
        /// the resource the rule monitors. **NOTE**: this property cannot be
        /// updated for an existing rule.</param>
        /// <param name="resourceLocation">the location of the
        /// resource.</param>
        /// <param name="metricNamespace">the namespace of the metric.</param>
        /// <param name="metricName">the name of the metric that defines what
        /// the rule monitors.</param>
        public RuleMetricDataSource(string resourceUri = default(string), string legacyResourceId = default(string), string resourceLocation = default(string), string metricNamespace = default(string), string metricName = default(string))
            : base(resourceUri, legacyResourceId, resourceLocation, metricNamespace)
        {
            MetricName = metricName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the metric that defines what the rule
        /// monitors.
        /// </summary>
        [JsonProperty(PropertyName = "metricName")]
        public string MetricName { get; set; }

    }
}
