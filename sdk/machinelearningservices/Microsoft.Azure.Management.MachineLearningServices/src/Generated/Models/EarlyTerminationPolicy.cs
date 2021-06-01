// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Early termination policies enable canceling poor-performing runs before
    /// they complete
    /// </summary>
    public partial class EarlyTerminationPolicy
    {
        /// <summary>
        /// Initializes a new instance of the EarlyTerminationPolicy class.
        /// </summary>
        public EarlyTerminationPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EarlyTerminationPolicy class.
        /// </summary>
        public EarlyTerminationPolicy(int? delayEvaluation = default(int?), int? evaluationInterval = default(int?))
        {
            DelayEvaluation = delayEvaluation;
            EvaluationInterval = evaluationInterval;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "delayEvaluation")]
        public int? DelayEvaluation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "evaluationInterval")]
        public int? EvaluationInterval { get; set; }

    }
}
