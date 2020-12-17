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
    using System.Linq;

    /// <summary>
    /// The min capacity capability
    /// </summary>
    public partial class MinCapacityCapability
    {
        /// <summary>
        /// Initializes a new instance of the MinCapacityCapability class.
        /// </summary>
        public MinCapacityCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MinCapacityCapability class.
        /// </summary>
        /// <param name="value">Min capacity value</param>
        /// <param name="status">The status of the capability. Possible values
        /// include: 'Visible', 'Available', 'Default', 'Disabled'</param>
        /// <param name="reason">The reason for the capability not being
        /// available.</param>
        public MinCapacityCapability(double? value = default(double?), CapabilityStatus? status = default(CapabilityStatus?), string reason = default(string))
        {
            Value = value;
            Status = status;
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets min capacity value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; private set; }

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
