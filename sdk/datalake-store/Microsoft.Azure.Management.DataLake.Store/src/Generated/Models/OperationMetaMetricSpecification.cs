// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class OperationMetaMetricSpecification
    {
        /// <summary>
        /// Initializes a new instance of the OperationMetaMetricSpecification
        /// class.
        /// </summary>
        public OperationMetaMetricSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationMetaMetricSpecification
        /// class.
        /// </summary>
        /// <param name="name">name of specification</param>
        /// <param name="displayName">display Name</param>
        /// <param name="displayDescription">display Description</param>
        /// <param name="unit">unit of specification</param>
        /// <param name="aggregationType">aggregation Type</param>
        /// <param name="supportsInstanceLevelAggregation">Whether supports
        /// InstanceLevel Aggregation</param>
        /// <param name="enableRegionalMdmAccount">enable Regional
        /// MdmAccount</param>
        /// <param name="sourceMdmAccount">source MdmAccount</param>
        /// <param name="sourceMdmNamespace">source MdmNamespace</param>
        /// <param name="availabilities">Operation Metric Availabilities
        /// Specification</param>
        /// <param name="metricFilterPattern">metric Filter Pattern</param>
        public OperationMetaMetricSpecification(string name = default(string), string displayName = default(string), string displayDescription = default(string), string unit = default(string), string aggregationType = default(string), bool? supportsInstanceLevelAggregation = default(bool?), bool? enableRegionalMdmAccount = default(bool?), string sourceMdmAccount = default(string), string sourceMdmNamespace = default(string), IList<OperationMetaMetricAvailabilitiesSpecification> availabilities = default(IList<OperationMetaMetricAvailabilitiesSpecification>), string metricFilterPattern = default(string))
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
            Availabilities = availabilities;
            MetricFilterPattern = metricFilterPattern;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of specification
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets display Name
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets display Description
        /// </summary>
        [JsonProperty(PropertyName = "displayDescription")]
        public string DisplayDescription { get; private set; }

        /// <summary>
        /// Gets unit of specification
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; private set; }

        /// <summary>
        /// Gets aggregation Type
        /// </summary>
        [JsonProperty(PropertyName = "aggregationType")]
        public string AggregationType { get; private set; }

        /// <summary>
        /// Gets whether supports InstanceLevel Aggregation
        /// </summary>
        [JsonProperty(PropertyName = "supportsInstanceLevelAggregation")]
        public bool? SupportsInstanceLevelAggregation { get; private set; }

        /// <summary>
        /// Gets enable Regional MdmAccount
        /// </summary>
        [JsonProperty(PropertyName = "enableRegionalMdmAccount")]
        public bool? EnableRegionalMdmAccount { get; private set; }

        /// <summary>
        /// Gets source MdmAccount
        /// </summary>
        [JsonProperty(PropertyName = "sourceMdmAccount")]
        public string SourceMdmAccount { get; private set; }

        /// <summary>
        /// Gets source MdmNamespace
        /// </summary>
        [JsonProperty(PropertyName = "sourceMdmNamespace")]
        public string SourceMdmNamespace { get; private set; }

        /// <summary>
        /// Gets operation Metric Availabilities Specification
        /// </summary>
        [JsonProperty(PropertyName = "availabilities")]
        public IList<OperationMetaMetricAvailabilitiesSpecification> Availabilities { get; private set; }

        /// <summary>
        /// Gets metric Filter Pattern
        /// </summary>
        [JsonProperty(PropertyName = "metricFilterPattern")]
        public string MetricFilterPattern { get; private set; }

    }
}
