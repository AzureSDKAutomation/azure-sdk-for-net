// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Subscription.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The created subscription object.
    /// </summary>
    public partial class SubscriptionCreationResult
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionCreationResult class.
        /// </summary>
        public SubscriptionCreationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionCreationResult class.
        /// </summary>
        /// <param name="subscriptionLink">The link to the new subscription.
        /// Use this link to check the status of subscription creation
        /// operation.</param>
        public SubscriptionCreationResult(string subscriptionLink = default(string))
        {
            SubscriptionLink = subscriptionLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the link to the new subscription. Use this link to
        /// check the status of subscription creation operation.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionLink")]
        public string SubscriptionLink { get; set; }

    }
}
