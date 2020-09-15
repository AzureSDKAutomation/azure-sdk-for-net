// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataCollaboration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The operation meta service specification
    /// </summary>
    public partial class OperationMetaServiceSpecification
    {
        /// <summary>
        /// Initializes a new instance of the OperationMetaServiceSpecification
        /// class.
        /// </summary>
        public OperationMetaServiceSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationMetaServiceSpecification
        /// class.
        /// </summary>
        /// <param name="logSpecifications">log specifications for the
        /// operation</param>
        /// <param name="metricSpecifications">metric specifications for the
        /// operation</param>
        public OperationMetaServiceSpecification(IList<OperationMetaLogSpecification> logSpecifications = default(IList<OperationMetaLogSpecification>), IList<OperationMetaMetricSpecification> metricSpecifications = default(IList<OperationMetaMetricSpecification>))
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
        /// Gets or sets log specifications for the operation
        /// </summary>
        [JsonProperty(PropertyName = "logSpecifications")]
        public IList<OperationMetaLogSpecification> LogSpecifications { get; set; }

        /// <summary>
        /// Gets or sets metric specifications for the operation
        /// </summary>
        [JsonProperty(PropertyName = "metricSpecifications")]
        public IList<OperationMetaMetricSpecification> MetricSpecifications { get; set; }

    }
}
