// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Support.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Additional set of information required for quota increase support
    /// ticket for certain quota types, e.g.: Virtual machine cores. Get
    /// complete details about Quota payload support request along with
    /// examples at [Support quota
    /// request](https://aka.ms/supportrpquotarequestpayload).
    /// </summary>
    public partial class QuotaTicketDetails
    {
        /// <summary>
        /// Initializes a new instance of the QuotaTicketDetails class.
        /// </summary>
        public QuotaTicketDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QuotaTicketDetails class.
        /// </summary>
        /// <param name="quotaChangeRequestSubType">Required for certain quota
        /// types when there is a sub type that you are requesting quota
        /// increase for. Example: Batch</param>
        /// <param name="quotaChangeRequestVersion">Quota change request
        /// version</param>
        /// <param name="quotaChangeRequests">This property is required for
        /// providing the region and new quota limits.</param>
        public QuotaTicketDetails(string quotaChangeRequestSubType = default(string), string quotaChangeRequestVersion = default(string), IList<QuotaChangeRequest> quotaChangeRequests = default(IList<QuotaChangeRequest>))
        {
            QuotaChangeRequestSubType = quotaChangeRequestSubType;
            QuotaChangeRequestVersion = quotaChangeRequestVersion;
            QuotaChangeRequests = quotaChangeRequests;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets required for certain quota types when there is a sub
        /// type that you are requesting quota increase for. Example: Batch
        /// </summary>
        [JsonProperty(PropertyName = "quotaChangeRequestSubType")]
        public string QuotaChangeRequestSubType { get; set; }

        /// <summary>
        /// Gets or sets quota change request version
        /// </summary>
        [JsonProperty(PropertyName = "quotaChangeRequestVersion")]
        public string QuotaChangeRequestVersion { get; set; }

        /// <summary>
        /// Gets or sets this property is required for providing the region and
        /// new quota limits.
        /// </summary>
        [JsonProperty(PropertyName = "quotaChangeRequests")]
        public IList<QuotaChangeRequest> QuotaChangeRequests { get; set; }

    }
}
