// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Analysis.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Available operation metric specification for exposing performance
    /// metrics to shoebox.
    /// </summary>
    public partial class MetricSpecifications
    {
        /// <summary>
        /// Initializes a new instance of the MetricSpecifications class.
        /// </summary>
        public MetricSpecifications()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricSpecifications class.
        /// </summary>
        /// <param name="name">The name of metric.</param>
        /// <param name="displayName">The displayed name of metric.</param>
        /// <param name="displayDescription">The displayed description of
        /// metric.</param>
        /// <param name="unit">The unit of the metric.</param>
        /// <param name="aggregationType">The aggregation type of
        /// metric.</param>
        /// <param name="dimensions">The dimensions of metric.</param>
        public MetricSpecifications(string name = default(string), string displayName = default(string), string displayDescription = default(string), string unit = default(string), string aggregationType = default(string), IList<MetricDimensions> dimensions = default(IList<MetricDimensions>))
        {
            Name = name;
            DisplayName = displayName;
            DisplayDescription = displayDescription;
            Unit = unit;
            AggregationType = aggregationType;
            Dimensions = dimensions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of metric.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the displayed name of metric.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the displayed description of metric.
        /// </summary>
        [JsonProperty(PropertyName = "displayDescription")]
        public string DisplayDescription { get; private set; }

        /// <summary>
        /// Gets the unit of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; private set; }

        /// <summary>
        /// Gets the aggregation type of metric.
        /// </summary>
        [JsonProperty(PropertyName = "aggregationType")]
        public string AggregationType { get; private set; }

        /// <summary>
        /// Gets the dimensions of metric.
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<MetricDimensions> Dimensions { get; private set; }

    }
}
