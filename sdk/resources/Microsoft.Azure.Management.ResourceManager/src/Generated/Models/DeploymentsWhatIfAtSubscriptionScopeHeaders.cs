// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for WhatIfAtSubscriptionScope operation.
    /// </summary>
    public partial class DeploymentsWhatIfAtSubscriptionScopeHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DeploymentsWhatIfAtSubscriptionScopeHeaders class.
        /// </summary>
        public DeploymentsWhatIfAtSubscriptionScopeHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DeploymentsWhatIfAtSubscriptionScopeHeaders class.
        /// </summary>
        /// <param name="location">URL to get status of this long-running
        /// operation.</param>
        /// <param name="retryAfter">Number of seconds to wait before polling
        /// for status.</param>
        public DeploymentsWhatIfAtSubscriptionScopeHeaders(string location = default(string), string retryAfter = default(string))
        {
            Location = location;
            RetryAfter = retryAfter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URL to get status of this long-running operation.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets number of seconds to wait before polling for status.
        /// </summary>
        [JsonProperty(PropertyName = "Retry-After")]
        public string RetryAfter { get; set; }

    }
}
