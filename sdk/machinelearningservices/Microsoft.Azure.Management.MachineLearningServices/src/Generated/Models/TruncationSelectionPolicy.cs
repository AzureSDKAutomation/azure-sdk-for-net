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
    /// Defines an early termination policy that cancels a given percentage of
    /// runs at each evaluation interval.
    /// </summary>
    [Newtonsoft.Json.JsonObject("TruncationSelection")]
    public partial class TruncationSelectionPolicy : EarlyTerminationPolicy
    {
        /// <summary>
        /// Initializes a new instance of the TruncationSelectionPolicy class.
        /// </summary>
        public TruncationSelectionPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TruncationSelectionPolicy class.
        /// </summary>
        public TruncationSelectionPolicy(int? delayEvaluation = default(int?), int? evaluationInterval = default(int?), int? truncationPercentage = default(int?))
            : base(delayEvaluation, evaluationInterval)
        {
            TruncationPercentage = truncationPercentage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "truncationPercentage")]
        public int? TruncationPercentage { get; set; }

    }
}
