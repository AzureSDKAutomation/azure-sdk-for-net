// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The managed instance virtual cores capability.
    /// </summary>
    public partial class ManagedInstanceVcoresCapability
    {
        /// <summary>
        /// Initializes a new instance of the ManagedInstanceVcoresCapability
        /// class.
        /// </summary>
        public ManagedInstanceVcoresCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedInstanceVcoresCapability
        /// class.
        /// </summary>
        /// <param name="name">The virtual cores identifier.</param>
        /// <param name="value">The virtual cores value.</param>
        /// <param name="includedMaxSize">Included size.</param>
        /// <param name="supportedStorageSizes">Storage size ranges.</param>
        /// <param name="instancePoolSupported">True if this service objective
        /// is supported for managed instances in an instance pool.</param>
        /// <param name="standaloneSupported">True if this service objective is
        /// supported for standalone managed instances.</param>
        /// <param name="status">The status of the capability. Possible values
        /// include: 'Visible', 'Available', 'Default', 'Disabled'</param>
        /// <param name="reason">The reason for the capability not being
        /// available.</param>
        public ManagedInstanceVcoresCapability(string name = default(string), int? value = default(int?), MaxSizeCapability includedMaxSize = default(MaxSizeCapability), IList<MaxSizeRangeCapability> supportedStorageSizes = default(IList<MaxSizeRangeCapability>), bool? instancePoolSupported = default(bool?), bool? standaloneSupported = default(bool?), CapabilityStatus? status = default(CapabilityStatus?), string reason = default(string))
        {
            Name = name;
            Value = value;
            IncludedMaxSize = includedMaxSize;
            SupportedStorageSizes = supportedStorageSizes;
            InstancePoolSupported = instancePoolSupported;
            StandaloneSupported = standaloneSupported;
            Status = status;
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the virtual cores identifier.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the virtual cores value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public int? Value { get; private set; }

        /// <summary>
        /// Gets included size.
        /// </summary>
        [JsonProperty(PropertyName = "includedMaxSize")]
        public MaxSizeCapability IncludedMaxSize { get; private set; }

        /// <summary>
        /// Gets storage size ranges.
        /// </summary>
        [JsonProperty(PropertyName = "supportedStorageSizes")]
        public IList<MaxSizeRangeCapability> SupportedStorageSizes { get; private set; }

        /// <summary>
        /// Gets true if this service objective is supported for managed
        /// instances in an instance pool.
        /// </summary>
        [JsonProperty(PropertyName = "instancePoolSupported")]
        public bool? InstancePoolSupported { get; private set; }

        /// <summary>
        /// Gets true if this service objective is supported for standalone
        /// managed instances.
        /// </summary>
        [JsonProperty(PropertyName = "standaloneSupported")]
        public bool? StandaloneSupported { get; private set; }

        /// <summary>
        /// Gets the status of the capability. Possible values include:
        /// 'Visible', 'Available', 'Default', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public CapabilityStatus? Status { get; private set; }

        /// <summary>
        /// Gets or sets the reason for the capability not being available.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

    }
}
