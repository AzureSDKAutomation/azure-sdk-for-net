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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Put subscription properties.
    /// </summary>
    public partial class PutAliasRequestProperties
    {
        /// <summary>
        /// Initializes a new instance of the PutAliasRequestProperties class.
        /// </summary>
        public PutAliasRequestProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PutAliasRequestProperties class.
        /// </summary>
        /// <param name="displayName">The friendly name of the
        /// subscription.</param>
        /// <param name="workload">The workload type of the subscription. It
        /// can be either Production or DevTest. Possible values include:
        /// 'Production', 'DevTest'</param>
        /// <param name="billingScope">Determines whether subscription is
        /// fieldLed, partnerLed or LegacyEA</param>
        /// <param name="subscriptionId">This parameter can be used to create
        /// alias for existing subscription Id</param>
        /// <param name="resellerId">Reseller Id</param>
        /// <param name="additionalProperties">Put alias request additional
        /// properties.</param>
        public PutAliasRequestProperties(string displayName, string workload, string billingScope, string subscriptionId = default(string), string resellerId = default(string), PutAliasRequestAdditionalProperties additionalProperties = default(PutAliasRequestAdditionalProperties))
        {
            DisplayName = displayName;
            Workload = workload;
            BillingScope = billingScope;
            SubscriptionId = subscriptionId;
            ResellerId = resellerId;
            AdditionalProperties = additionalProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the friendly name of the subscription.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the workload type of the subscription. It can be
        /// either Production or DevTest. Possible values include:
        /// 'Production', 'DevTest'
        /// </summary>
        [JsonProperty(PropertyName = "workload")]
        public string Workload { get; set; }

        /// <summary>
        /// Gets or sets determines whether subscription is fieldLed,
        /// partnerLed or LegacyEA
        /// </summary>
        [JsonProperty(PropertyName = "billingScope")]
        public string BillingScope { get; set; }

        /// <summary>
        /// Gets or sets this parameter can be used to create alias for
        /// existing subscription Id
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets reseller Id
        /// </summary>
        [JsonProperty(PropertyName = "resellerId")]
        public string ResellerId { get; set; }

        /// <summary>
        /// Gets or sets put alias request additional properties.
        /// </summary>
        [JsonProperty(PropertyName = "additionalProperties")]
        public PutAliasRequestAdditionalProperties AdditionalProperties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Workload == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Workload");
            }
            if (BillingScope == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BillingScope");
            }
        }
    }
}
