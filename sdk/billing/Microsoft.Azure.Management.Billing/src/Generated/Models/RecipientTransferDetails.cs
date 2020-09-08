// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details of the transfer.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RecipientTransferDetails : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RecipientTransferDetails class.
        /// </summary>
        public RecipientTransferDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecipientTransferDetails class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="creationTime">The time at which the transfer request
        /// was created.</param>
        /// <param name="expirationTime">The time at which the transfer request
        /// expires.</param>
        /// <param name="allowedProductType">Type of subscriptions that can be
        /// transferred.</param>
        /// <param name="transferStatus">Overall transfer status. Possible
        /// values include: 'Pending', 'InProgress', 'Completed',
        /// 'CompletedWithErrors', 'Failed', 'Canceled', 'Declined'</param>
        /// <param name="recipientEmailId">The email ID of the user to whom the
        /// transfer request was sent.</param>
        /// <param name="initiatorEmailId">The email ID of the user who sent
        /// the transfer request.</param>
        /// <param name="resellerId">Optional MPN ID of the reseller for
        /// transfer requests that are sent from a Microsoft Partner Agreement
        /// billing account.</param>
        /// <param name="resellerName">Optional name of the reseller for
        /// transfer requests that are sent from Microsoft Partner Agreement
        /// billing account.</param>
        /// <param name="initiatorCustomerType">The type of customer who sent
        /// the transfer request.</param>
        /// <param name="canceledBy">The email ID of the user who canceled the
        /// transfer request.</param>
        /// <param name="lastModifiedTime">The time at which the transfer
        /// request was last modified.</param>
        /// <param name="detailedTransferStatus">Detailed transfer
        /// status.</param>
        public RecipientTransferDetails(string id = default(string), string name = default(string), string type = default(string), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? expirationTime = default(System.DateTime?), IList<string> allowedProductType = default(IList<string>), string transferStatus = default(string), string recipientEmailId = default(string), string initiatorEmailId = default(string), string resellerId = default(string), string resellerName = default(string), string initiatorCustomerType = default(string), string canceledBy = default(string), System.DateTime? lastModifiedTime = default(System.DateTime?), IList<DetailedTransferStatus> detailedTransferStatus = default(IList<DetailedTransferStatus>))
            : base(id, name, type)
        {
            CreationTime = creationTime;
            ExpirationTime = expirationTime;
            AllowedProductType = allowedProductType;
            TransferStatus = transferStatus;
            RecipientEmailId = recipientEmailId;
            InitiatorEmailId = initiatorEmailId;
            ResellerId = resellerId;
            ResellerName = resellerName;
            InitiatorCustomerType = initiatorCustomerType;
            CanceledBy = canceledBy;
            LastModifiedTime = lastModifiedTime;
            DetailedTransferStatus = detailedTransferStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the time at which the transfer request was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the time at which the transfer request expires.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expirationTime")]
        public System.DateTime? ExpirationTime { get; private set; }

        /// <summary>
        /// Gets type of subscriptions that can be transferred.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowedProductType")]
        public IList<string> AllowedProductType { get; private set; }

        /// <summary>
        /// Gets overall transfer status. Possible values include: 'Pending',
        /// 'InProgress', 'Completed', 'CompletedWithErrors', 'Failed',
        /// 'Canceled', 'Declined'
        /// </summary>
        [JsonProperty(PropertyName = "properties.transferStatus")]
        public string TransferStatus { get; private set; }

        /// <summary>
        /// Gets the email ID of the user to whom the transfer request was
        /// sent.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recipientEmailId")]
        public string RecipientEmailId { get; private set; }

        /// <summary>
        /// Gets the email ID of the user who sent the transfer request.
        /// </summary>
        [JsonProperty(PropertyName = "properties.initiatorEmailId")]
        public string InitiatorEmailId { get; private set; }

        /// <summary>
        /// Gets optional MPN ID of the reseller for transfer requests that are
        /// sent from a Microsoft Partner Agreement billing account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resellerId")]
        public string ResellerId { get; private set; }

        /// <summary>
        /// Gets optional name of the reseller for transfer requests that are
        /// sent from Microsoft Partner Agreement billing account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resellerName")]
        public string ResellerName { get; private set; }

        /// <summary>
        /// Gets the type of customer who sent the transfer request.
        /// </summary>
        [JsonProperty(PropertyName = "properties.initiatorCustomerType")]
        public string InitiatorCustomerType { get; private set; }

        /// <summary>
        /// Gets the email ID of the user who canceled the transfer request.
        /// </summary>
        [JsonProperty(PropertyName = "properties.canceledBy")]
        public string CanceledBy { get; private set; }

        /// <summary>
        /// Gets the time at which the transfer request was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets detailed transfer status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.detailedTransferStatus")]
        public IList<DetailedTransferStatus> DetailedTransferStatus { get; private set; }

    }
}
