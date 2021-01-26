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
    /// Put subscription creation result properties.
    /// </summary>
    public partial class PutAliasResponseProperties
    {
        /// <summary>
        /// Initializes a new instance of the PutAliasResponseProperties class.
        /// </summary>
        public PutAliasResponseProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PutAliasResponseProperties class.
        /// </summary>
        /// <param name="subscriptionId">Newly created subscription Id.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values include: 'Accepted', 'Succeeded',
        /// 'Failed'</param>
        /// <param name="redeemUrl">Redeem url.</param>
        /// <param name="redeemState">The redeem state of the resource.
        /// Possible values include: 'Pending', 'Completed'</param>
        public PutAliasResponseProperties(string subscriptionId = default(string), string provisioningState = default(string), string redeemUrl = default(string), string redeemState = default(string))
        {
            SubscriptionId = subscriptionId;
            ProvisioningState = provisioningState;
            RedeemUrl = redeemUrl;
            RedeemState = redeemState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets newly created subscription Id.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; private set; }

        /// <summary>
        /// Gets or sets the provisioning state of the resource. Possible
        /// values include: 'Accepted', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets redeem url.
        /// </summary>
        [JsonProperty(PropertyName = "redeemUrl")]
        public string RedeemUrl { get; set; }

        /// <summary>
        /// Gets or sets the redeem state of the resource. Possible values
        /// include: 'Pending', 'Completed'
        /// </summary>
        [JsonProperty(PropertyName = "redeemState")]
        public string RedeemState { get; set; }

    }
}
