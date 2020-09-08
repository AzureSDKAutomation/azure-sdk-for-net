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
    public partial class TransferDetails : Resource
    {
        /// <summary>
        /// Initializes a new instance of the TransferDetails class.
        /// </summary>
        public TransferDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransferDetails class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="creationTime">The time at which the transfer request
        /// was created.</param>
        /// <param name="expirationTime">The time at which the transfer request
        /// expires.</param>
        /// <param name="invoiceSectionId">The ID of the invoice section to
        /// which the product is billed after the transfer request is
        /// completed.</param>
        /// <param name="billingAccountId">The ID of the billing account to
        /// which the product is billed after the transfer request is
        /// completed.</param>
        /// <param name="resellerId">Optional MPN ID of the reseller for
        /// transfer requests that are sent from a Microsoft Partner Agreement
        /// billing account.</param>
        /// <param name="resellerName">Optional name of the reseller for
        /// transfer requests that are sent from Microsoft Partner Agreement
        /// billing account.</param>
        /// <param name="initiatorCustomerType">The type of customer who sent
        /// the transfer request.</param>
        /// <param name="billingProfileId">The ID of the billing profile to
        /// which the product will be billed after the transfer.</param>
        /// <param name="transferStatus">Overall transfer status. Possible
        /// values include: 'Pending', 'InProgress', 'Completed',
        /// 'CompletedWithErrors', 'Failed', 'Canceled', 'Declined'</param>
        /// <param name="recipientEmailId">The email ID of the user to whom the
        /// transfer request was sent.</param>
        /// <param name="initiatorEmailId">The email ID of the user who sent
        /// the transfer request.</param>
        /// <param name="canceledBy">The email ID of the user who canceled the
        /// transfer request.</param>
        /// <param name="lastModifiedTime">The time at which the transfer
        /// request was last modified.</param>
        /// <param name="detailedTransferStatus">Detailed transfer
        /// status.</param>
        public TransferDetails(string id = default(string), string name = default(string), string type = default(string), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? expirationTime = default(System.DateTime?), string invoiceSectionId = default(string), string billingAccountId = default(string), string resellerId = default(string), string resellerName = default(string), string initiatorCustomerType = default(string), string billingProfileId = default(string), string transferStatus = default(string), string recipientEmailId = default(string), string initiatorEmailId = default(string), string canceledBy = default(string), System.DateTime? lastModifiedTime = default(System.DateTime?), IList<DetailedTransferStatus> detailedTransferStatus = default(IList<DetailedTransferStatus>))
            : base(id, name, type)
        {
            CreationTime = creationTime;
            ExpirationTime = expirationTime;
            InvoiceSectionId = invoiceSectionId;
            BillingAccountId = billingAccountId;
            ResellerId = resellerId;
            ResellerName = resellerName;
            InitiatorCustomerType = initiatorCustomerType;
            BillingProfileId = billingProfileId;
            TransferStatus = transferStatus;
            RecipientEmailId = recipientEmailId;
            InitiatorEmailId = initiatorEmailId;
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
        /// Gets the ID of the invoice section to which the product is billed
        /// after the transfer request is completed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionId")]
        public string InvoiceSectionId { get; private set; }

        /// <summary>
        /// Gets the ID of the billing account to which the product is billed
        /// after the transfer request is completed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingAccountId")]
        public string BillingAccountId { get; private set; }

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
        /// Gets the ID of the billing profile to which the product will be
        /// billed after the transfer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileId")]
        public string BillingProfileId { get; private set; }

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
