// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Quota.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Quota limits.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CurrentQuotaLimit : IResource
    {
        /// <summary>
        /// Initializes a new instance of the CurrentQuotaLimit class.
        /// </summary>
        public CurrentQuotaLimit()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CurrentQuotaLimit class.
        /// </summary>
        /// <param name="properties">Quota properties for the resource.</param>
        /// <param name="provisioningState">The quota request status. Possible
        /// values include: 'Accepted', 'Invalid', 'Succeeded', 'Failed',
        /// 'InProgress'</param>
        /// <param name="message">A user friendly message.</param>
        public CurrentQuotaLimit(QuotaProperties properties = default(QuotaProperties), string provisioningState = default(string), string message = default(string))
        {
            Properties = properties;
            ProvisioningState = provisioningState;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets quota properties for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "quotaInformation.properties")]
        public QuotaProperties Properties { get; set; }

        /// <summary>
        /// Gets the quota request status. Possible values include: 'Accepted',
        /// 'Invalid', 'Succeeded', 'Failed', 'InProgress'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets a user friendly message.
        /// </summary>
        [JsonProperty(PropertyName = "properties.message")]
        public string Message { get; private set; }

    }
}
