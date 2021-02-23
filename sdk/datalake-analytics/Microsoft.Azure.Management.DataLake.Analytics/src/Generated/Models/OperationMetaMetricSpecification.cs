// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
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
        /// <param name="name">The name for
        /// OperationMetaMetricSpecification.</param>
        /// <param name="displayDescription">The displayName for
        /// OperationMetaMetricSpecification.</param>
        /// <param name="displayName">The displayName for
        /// OperationMetaMetricSpecification.</param>
        /// <param name="unit">The unit for
        /// OperationMetaMetricSpecification.</param>
        /// <param name="aggregationType">The aggregationType for
        /// OperationMetaMetricSpecification.</param>
        /// <param name="availabilities">The availabilities for
        /// OperationMetaMetricSpecification.</param>
        public OperationMetaMetricSpecification(string name = default(string), string displayDescription = default(string), string displayName = default(string), string unit = default(string), string aggregationType = default(string), IList<OperationMetaMetricAvailabilitiesSpecification> availabilities = default(IList<OperationMetaMetricAvailabilitiesSpecification>))
        {
            Name = name;
            DisplayDescription = displayDescription;
            DisplayName = displayName;
            Unit = unit;
            AggregationType = aggregationType;
            Availabilities = availabilities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name for OperationMetaMetricSpecification.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the displayName for OperationMetaMetricSpecification.
        /// </summary>
        [JsonProperty(PropertyName = "displayDescription")]
        public string DisplayDescription { get; set; }

        /// <summary>
        /// Gets or sets the displayName for OperationMetaMetricSpecification.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the unit for OperationMetaMetricSpecification.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets the aggregationType for
        /// OperationMetaMetricSpecification.
        /// </summary>
        [JsonProperty(PropertyName = "aggregationType")]
        public string AggregationType { get; set; }

        /// <summary>
        /// Gets or sets the availabilities for
        /// OperationMetaMetricSpecification.
        /// </summary>
        [JsonProperty(PropertyName = "availabilities")]
        public IList<OperationMetaMetricAvailabilitiesSpecification> Availabilities { get; set; }

    }
}
