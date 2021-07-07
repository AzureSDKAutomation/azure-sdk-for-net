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
    /// The liveness probe requirements.
    /// </summary>
    public partial class LivenessProbeRequirements
    {
        /// <summary>
        /// Initializes a new instance of the LivenessProbeRequirements class.
        /// </summary>
        public LivenessProbeRequirements()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LivenessProbeRequirements class.
        /// </summary>
        /// <param name="failureThreshold">The number of failures to allow
        /// before returning an unhealthy status.</param>
        /// <param name="successThreshold">The number of successful probes
        /// before returning a healthy status.</param>
        /// <param name="timeoutSeconds">The probe timeout in seconds.</param>
        /// <param name="periodSeconds">The length of time between probes in
        /// seconds.</param>
        /// <param name="initialDelaySeconds">The delay before the first probe
        /// in seconds.</param>
        public LivenessProbeRequirements(int? failureThreshold = default(int?), int? successThreshold = default(int?), int? timeoutSeconds = default(int?), int? periodSeconds = default(int?), int? initialDelaySeconds = default(int?))
        {
            FailureThreshold = failureThreshold;
            SuccessThreshold = successThreshold;
            TimeoutSeconds = timeoutSeconds;
            PeriodSeconds = periodSeconds;
            InitialDelaySeconds = initialDelaySeconds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of failures to allow before returning an
        /// unhealthy status.
        /// </summary>
        [JsonProperty(PropertyName = "failureThreshold")]
        public int? FailureThreshold { get; set; }

        /// <summary>
        /// Gets or sets the number of successful probes before returning a
        /// healthy status.
        /// </summary>
        [JsonProperty(PropertyName = "successThreshold")]
        public int? SuccessThreshold { get; set; }

        /// <summary>
        /// Gets or sets the probe timeout in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "timeoutSeconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Gets or sets the length of time between probes in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "periodSeconds")]
        public int? PeriodSeconds { get; set; }

        /// <summary>
        /// Gets or sets the delay before the first probe in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "initialDelaySeconds")]
        public int? InitialDelaySeconds { get; set; }

    }
}
