// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Kubelet configurations of agent nodes.
    /// </summary>
    public partial class KubeletConfig
    {
        /// <summary>
        /// Initializes a new instance of the KubeletConfig class.
        /// </summary>
        public KubeletConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KubeletConfig class.
        /// </summary>
        /// <param name="cpuManagerPolicy">CPU Manager policy to use.</param>
        /// <param name="cpuCfsQuota">Enable CPU CFS quota enforcement for
        /// containers that specify CPU limits.</param>
        /// <param name="cpuCfsQuotaPeriod">Sets CPU CFS quota period
        /// value.</param>
        /// <param name="imageGcHighThreshold">The percent of disk usage after
        /// which image garbage collection is always run.</param>
        /// <param name="imageGcLowThreshold">The percent of disk usage before
        /// which image garbage collection is never run.</param>
        /// <param name="topologyManagerPolicy">Topology Manager policy to
        /// use.</param>
        /// <param name="allowedUnsafeSysctls">Allowlist of unsafe sysctls or
        /// unsafe sysctl patterns (ending in `*`).</param>
        /// <param name="failSwapOn">If set to true it will make the Kubelet
        /// fail to start if swap is enabled on the node.</param>
        /// <param name="containerLogMaxSizeMB">The maximum size (e.g. 10Mi) of
        /// container log file before it is rotated.</param>
        /// <param name="containerLogMaxFiles">The maximum number of container
        /// log files that can be present for a container. The number must be ≥
        /// 2.</param>
        /// <param name="podMaxPids">The maximum number of processes per
        /// pod.</param>
        public KubeletConfig(string cpuManagerPolicy = default(string), bool? cpuCfsQuota = default(bool?), string cpuCfsQuotaPeriod = default(string), int? imageGcHighThreshold = default(int?), int? imageGcLowThreshold = default(int?), string topologyManagerPolicy = default(string), IList<string> allowedUnsafeSysctls = default(IList<string>), bool? failSwapOn = default(bool?), int? containerLogMaxSizeMB = default(int?), int? containerLogMaxFiles = default(int?), int? podMaxPids = default(int?))
        {
            CpuManagerPolicy = cpuManagerPolicy;
            CpuCfsQuota = cpuCfsQuota;
            CpuCfsQuotaPeriod = cpuCfsQuotaPeriod;
            ImageGcHighThreshold = imageGcHighThreshold;
            ImageGcLowThreshold = imageGcLowThreshold;
            TopologyManagerPolicy = topologyManagerPolicy;
            AllowedUnsafeSysctls = allowedUnsafeSysctls;
            FailSwapOn = failSwapOn;
            ContainerLogMaxSizeMB = containerLogMaxSizeMB;
            ContainerLogMaxFiles = containerLogMaxFiles;
            PodMaxPids = podMaxPids;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets CPU Manager policy to use.
        /// </summary>
        [JsonProperty(PropertyName = "cpuManagerPolicy")]
        public string CpuManagerPolicy { get; set; }

        /// <summary>
        /// Gets or sets enable CPU CFS quota enforcement for containers that
        /// specify CPU limits.
        /// </summary>
        [JsonProperty(PropertyName = "cpuCfsQuota")]
        public bool? CpuCfsQuota { get; set; }

        /// <summary>
        /// Gets or sets sets CPU CFS quota period value.
        /// </summary>
        [JsonProperty(PropertyName = "cpuCfsQuotaPeriod")]
        public string CpuCfsQuotaPeriod { get; set; }

        /// <summary>
        /// Gets or sets the percent of disk usage after which image garbage
        /// collection is always run.
        /// </summary>
        [JsonProperty(PropertyName = "imageGcHighThreshold")]
        public int? ImageGcHighThreshold { get; set; }

        /// <summary>
        /// Gets or sets the percent of disk usage before which image garbage
        /// collection is never run.
        /// </summary>
        [JsonProperty(PropertyName = "imageGcLowThreshold")]
        public int? ImageGcLowThreshold { get; set; }

        /// <summary>
        /// Gets or sets topology Manager policy to use.
        /// </summary>
        [JsonProperty(PropertyName = "topologyManagerPolicy")]
        public string TopologyManagerPolicy { get; set; }

        /// <summary>
        /// Gets or sets allowlist of unsafe sysctls or unsafe sysctl patterns
        /// (ending in `*`).
        /// </summary>
        [JsonProperty(PropertyName = "allowedUnsafeSysctls")]
        public IList<string> AllowedUnsafeSysctls { get; set; }

        /// <summary>
        /// Gets or sets if set to true it will make the Kubelet fail to start
        /// if swap is enabled on the node.
        /// </summary>
        [JsonProperty(PropertyName = "failSwapOn")]
        public bool? FailSwapOn { get; set; }

        /// <summary>
        /// Gets or sets the maximum size (e.g. 10Mi) of container log file
        /// before it is rotated.
        /// </summary>
        [JsonProperty(PropertyName = "containerLogMaxSizeMB")]
        public int? ContainerLogMaxSizeMB { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of container log files that can be
        /// present for a container. The number must be ≥ 2.
        /// </summary>
        [JsonProperty(PropertyName = "containerLogMaxFiles")]
        public int? ContainerLogMaxFiles { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of processes per pod.
        /// </summary>
        [JsonProperty(PropertyName = "podMaxPids")]
        public int? PodMaxPids { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ContainerLogMaxFiles < 2)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "ContainerLogMaxFiles", 2);
            }
        }
    }
}
