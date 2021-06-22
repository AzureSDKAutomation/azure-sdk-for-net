// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EdgeOrder.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Cost information for the product system
    /// </summary>
    public partial class CostInformation
    {
        /// <summary>
        /// Initializes a new instance of the CostInformation class.
        /// </summary>
        public CostInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CostInformation class.
        /// </summary>
        /// <param name="billingMeterDetails">Details on the various billing
        /// aspects for the product system.</param>
        /// <param name="billingInfoUrl">Default url to display billing
        /// information</param>
        public CostInformation(IList<BillingMeterDetails> billingMeterDetails = default(IList<BillingMeterDetails>), string billingInfoUrl = default(string))
        {
            BillingMeterDetails = billingMeterDetails;
            BillingInfoUrl = billingInfoUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets details on the various billing aspects for the product system.
        /// </summary>
        [JsonProperty(PropertyName = "billingMeterDetails")]
        public IList<BillingMeterDetails> BillingMeterDetails { get; private set; }

        /// <summary>
        /// Gets default url to display billing information
        /// </summary>
        [JsonProperty(PropertyName = "billingInfoUrl")]
        public string BillingInfoUrl { get; private set; }

    }
}
