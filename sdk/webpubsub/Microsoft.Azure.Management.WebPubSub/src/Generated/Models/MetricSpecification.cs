// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebPubSub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifications of the Metrics for Azure Monitoring.
    /// </summary>
    public partial class MetricSpecification
    {
        /// <summary>
        /// Initializes a new instance of the MetricSpecification class.
        /// </summary>
        public MetricSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricSpecification class.
        /// </summary>
        /// <param name="name">Name of the metric.</param>
        /// <param name="displayName">Localized friendly display name of the
        /// metric.</param>
        /// <param name="displayDescription">Localized friendly description of
        /// the metric.</param>
        /// <param name="unit">The unit that makes sense for the
        /// metric.</param>
        /// <param name="aggregationType">Only provide one value for this
        /// field. Valid values: Average, Minimum, Maximum, Total,
        /// Count.</param>
        /// <param name="fillGapWithZero">Optional. If set to true, then zero
        /// will be returned for time duration where no metric is
        /// emitted/published.
        /// Ex. a metric that returns the number of times a particular error
        /// code was emitted. The error code may not appear
        /// often, instead of the RP publishing 0, Shoebox can auto fill in 0s
        /// for time periods where nothing was emitted.</param>
        /// <param name="category">The name of the metric category that the
        /// metric belongs to. A metric can only belong to a single
        /// category.</param>
        /// <param name="dimensions">The dimensions of the metrics.</param>
        public MetricSpecification(string name = default(string), string displayName = default(string), string displayDescription = default(string), string unit = default(string), string aggregationType = default(string), string fillGapWithZero = default(string), string category = default(string), IList<Dimension> dimensions = default(IList<Dimension>))
        {
            Name = name;
            DisplayName = displayName;
            DisplayDescription = displayDescription;
            Unit = unit;
            AggregationType = aggregationType;
            FillGapWithZero = fillGapWithZero;
            Category = category;
            Dimensions = dimensions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets localized friendly display name of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets localized friendly description of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "displayDescription")]
        public string DisplayDescription { get; set; }

        /// <summary>
        /// Gets or sets the unit that makes sense for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets only provide one value for this field. Valid values:
        /// Average, Minimum, Maximum, Total, Count.
        /// </summary>
        [JsonProperty(PropertyName = "aggregationType")]
        public string AggregationType { get; set; }

        /// <summary>
        /// Gets or sets optional. If set to true, then zero will be returned
        /// for time duration where no metric is emitted/published.
        /// Ex. a metric that returns the number of times a particular error
        /// code was emitted. The error code may not appear
        /// often, instead of the RP publishing 0, Shoebox can auto fill in 0s
        /// for time periods where nothing was emitted.
        /// </summary>
        [JsonProperty(PropertyName = "fillGapWithZero")]
        public string FillGapWithZero { get; set; }

        /// <summary>
        /// Gets or sets the name of the metric category that the metric
        /// belongs to. A metric can only belong to a single category.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the dimensions of the metrics.
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<Dimension> Dimensions { get; set; }

    }
}
