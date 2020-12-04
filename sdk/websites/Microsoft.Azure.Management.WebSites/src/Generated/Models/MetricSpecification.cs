// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Definition of a single resource metric.
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
        public MetricSpecification(string name = default(string), string displayName = default(string), string displayDescription = default(string), string unit = default(string), string aggregationType = default(string), bool? supportsInstanceLevelAggregation = default(bool?), bool? enableRegionalMdmAccount = default(bool?), string sourceMdmAccount = default(string), string sourceMdmNamespace = default(string), string metricFilterPattern = default(string), bool? fillGapWithZero = default(bool?), bool? isInternal = default(bool?), IList<Dimension> dimensions = default(IList<Dimension>), string category = default(string), IList<MetricAvailability> availabilities = default(IList<MetricAvailability>), IList<string> supportedTimeGrainTypes = default(IList<string>))
        {
            Name = name;
            DisplayName = displayName;
            DisplayDescription = displayDescription;
            Unit = unit;
            AggregationType = aggregationType;
            SupportsInstanceLevelAggregation = supportsInstanceLevelAggregation;
            EnableRegionalMdmAccount = enableRegionalMdmAccount;
            SourceMdmAccount = sourceMdmAccount;
            SourceMdmNamespace = sourceMdmNamespace;
            MetricFilterPattern = metricFilterPattern;
            FillGapWithZero = fillGapWithZero;
            IsInternal = isInternal;
            Dimensions = dimensions;
            Category = category;
            Availabilities = availabilities;
            SupportedTimeGrainTypes = supportedTimeGrainTypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayDescription")]
        public string DisplayDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "aggregationType")]
        public string AggregationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supportsInstanceLevelAggregation")]
        public bool? SupportsInstanceLevelAggregation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enableRegionalMdmAccount")]
        public bool? EnableRegionalMdmAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceMdmAccount")]
        public string SourceMdmAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceMdmNamespace")]
        public string SourceMdmNamespace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metricFilterPattern")]
        public string MetricFilterPattern { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fillGapWithZero")]
        public bool? FillGapWithZero { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isInternal")]
        public bool? IsInternal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<Dimension> Dimensions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "availabilities")]
        public IList<MetricAvailability> Availabilities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supportedTimeGrainTypes")]
        public IList<string> SupportedTimeGrainTypes { get; set; }

    }
}
