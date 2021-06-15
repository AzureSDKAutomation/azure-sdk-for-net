// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OpenAI.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SKU availability.
    /// </summary>
    public partial class SkuAvailability
    {
        /// <summary>
        /// Initializes a new instance of the SkuAvailability class.
        /// </summary>
        public SkuAvailability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SkuAvailability class.
        /// </summary>
        /// <param name="type">The Type of the resource.</param>
        /// <param name="skuName">The SKU of OpenAI account.</param>
        /// <param name="skuAvailable">Indicates the given SKU is available or
        /// not.</param>
        /// <param name="reason">Reason why the SKU is not available.</param>
        /// <param name="message">Additional error message.</param>
        public SkuAvailability(string type = default(string), string skuName = default(string), bool? skuAvailable = default(bool?), string reason = default(string), string message = default(string))
        {
            Type = type;
            SkuName = skuName;
            SkuAvailable = skuAvailable;
            Reason = reason;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the SKU of OpenAI account.
        /// </summary>
        [JsonProperty(PropertyName = "skuName")]
        public string SkuName { get; set; }

        /// <summary>
        /// Gets or sets indicates the given SKU is available or not.
        /// </summary>
        [JsonProperty(PropertyName = "skuAvailable")]
        public bool? SkuAvailable { get; set; }

        /// <summary>
        /// Gets or sets reason why the SKU is not available.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets additional error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
