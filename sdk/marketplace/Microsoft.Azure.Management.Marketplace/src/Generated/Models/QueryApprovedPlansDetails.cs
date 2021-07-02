// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Marketplace.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Query approved plans response
    /// </summary>
    public partial class QueryApprovedPlansDetails
    {
        /// <summary>
        /// Initializes a new instance of the QueryApprovedPlansDetails class.
        /// </summary>
        public QueryApprovedPlansDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryApprovedPlansDetails class.
        /// </summary>
        /// <param name="planId">Plan id</param>
        /// <param name="subscriptionIds">Approved subscription ids list. In
        /// case all subscriptions are approved for a plan, allSubscriptions
        /// flag is true and list is empty ( else flag is set to false). In
        /// case both subscriptions list is empty and allSubscriptions flag is
        /// false, the plan is not approved for any subscription.</param>
        /// <param name="allSubscriptions">Indicates whether all subscriptions
        /// are approved for this plan</param>
        public QueryApprovedPlansDetails(string planId = default(string), IList<string> subscriptionIds = default(IList<string>), bool? allSubscriptions = default(bool?))
        {
            PlanId = planId;
            SubscriptionIds = subscriptionIds;
            AllSubscriptions = allSubscriptions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets plan id
        /// </summary>
        [JsonProperty(PropertyName = "planId")]
        public string PlanId { get; set; }

        /// <summary>
        /// Gets or sets approved subscription ids list. In case all
        /// subscriptions are approved for a plan, allSubscriptions flag is
        /// true and list is empty ( else flag is set to false). In case both
        /// subscriptions list is empty and allSubscriptions flag is false, the
        /// plan is not approved for any subscription.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionIds")]
        public IList<string> SubscriptionIds { get; set; }

        /// <summary>
        /// Gets or sets indicates whether all subscriptions are approved for
        /// this plan
        /// </summary>
        [JsonProperty(PropertyName = "allSubscriptions")]
        public bool? AllSubscriptions { get; set; }

    }
}
