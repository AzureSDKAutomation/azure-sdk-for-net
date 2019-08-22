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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Severity metrics
    /// </summary>
    public partial class IoTSeverityMetrics
    {
        /// <summary>
        /// Initializes a new instance of the IoTSeverityMetrics class.
        /// </summary>
        public IoTSeverityMetrics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IoTSeverityMetrics class.
        /// </summary>
        /// <param name="high">count of high severity items</param>
        /// <param name="medium">count of medium severity items</param>
        /// <param name="low">count of low severity items</param>
        public IoTSeverityMetrics(int? high = default(int?), int? medium = default(int?), int? low = default(int?))
        {
            High = high;
            Medium = medium;
            Low = low;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets count of high severity items
        /// </summary>
        [JsonProperty(PropertyName = "high")]
        public int? High { get; set; }

        /// <summary>
        /// Gets or sets count of medium severity items
        /// </summary>
        [JsonProperty(PropertyName = "medium")]
        public int? Medium { get; set; }

        /// <summary>
        /// Gets or sets count of low severity items
        /// </summary>
        [JsonProperty(PropertyName = "low")]
        public int? Low { get; set; }

    }
}
