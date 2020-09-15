// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Bing.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Service specification payload
    /// </summary>
    public partial class ServiceSpecification
    {
        /// <summary>
        /// Initializes a new instance of the ServiceSpecification class.
        /// </summary>
        public ServiceSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceSpecification class.
        /// </summary>
        /// <param name="logSpecifications">Specifications of the Log for Azure
        /// Monitoring</param>
        /// <param name="metricSpecifications">Specifications of the Metrics
        /// for Azure Monitoring</param>
        public ServiceSpecification(IList<LogSpecification> logSpecifications = default(IList<LogSpecification>), IList<MetricSpecification> metricSpecifications = default(IList<MetricSpecification>))
        {
            LogSpecifications = logSpecifications;
            MetricSpecifications = metricSpecifications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifications of the Log for Azure Monitoring
        /// </summary>
        [JsonProperty(PropertyName = "logSpecifications")]
        public IList<LogSpecification> LogSpecifications { get; set; }

        /// <summary>
        /// Gets or sets specifications of the Metrics for Azure Monitoring
        /// </summary>
        [JsonProperty(PropertyName = "metricSpecifications")]
        public IList<MetricSpecification> MetricSpecifications { get; set; }

    }
}
