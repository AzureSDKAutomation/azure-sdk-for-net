// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Modern Reservation transaction resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ModernReservationTransaction : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ModernReservationTransaction
        /// class.
        /// </summary>
        public ModernReservationTransaction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModernReservationTransaction
        /// class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="amount">The charge of the transaction.</param>
        /// <param name="armSkuName">This is the ARM Sku name. It can be used
        /// to join with the serviceType field in additional info in usage
        /// records.</param>
        /// <param name="billingFrequency">The billing frequency, which can be
        /// either one-time or recurring.</param>
        /// <param name="billingProfileId">Billing profile Id.</param>
        /// <param name="billingProfileName">Billing profile name.</param>
        /// <param name="currency">The ISO currency in which the transaction is
        /// charged, for example, USD.</param>
        /// <param name="description">The description of the
        /// transaction.</param>
        /// <param name="eventDate">The date of the transaction</param>
        /// <param name="eventType">The type of the transaction (Purchase,
        /// Cancel, etc.)</param>
        /// <param name="invoice">Invoice Number</param>
        /// <param name="invoiceId">Invoice Id as on the invoice where the
        /// specific transaction appears.</param>
        /// <param name="invoiceSectionId">Invoice Section Id</param>
        /// <param name="invoiceSectionName">Invoice Section Name.</param>
        /// <param name="purchasingSubscriptionGuid">The subscription guid that
        /// makes the transaction.</param>
        /// <param name="purchasingSubscriptionName">The subscription name that
        /// makes the transaction.</param>
        /// <param name="quantity">The quantity of the transaction.</param>
        /// <param name="region">The region of the transaction.</param>
        /// <param name="reservationOrderId">The reservation order ID is the
        /// identifier for a reservation purchase. Each reservation order ID
        /// represents a single purchase transaction. A reservation order
        /// contains reservations. The reservation order specifies the VM size
        /// and region for the reservations.</param>
        /// <param name="reservationOrderName">The name of the reservation
        /// order.</param>
        /// <param name="term">This is the term of the transaction.</param>
        public ModernReservationTransaction(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), decimal? amount = default(decimal?), string armSkuName = default(string), string billingFrequency = default(string), string billingProfileId = default(string), string billingProfileName = default(string), string currency = default(string), string description = default(string), System.DateTime? eventDate = default(System.DateTime?), string eventType = default(string), string invoice = default(string), string invoiceId = default(string), string invoiceSectionId = default(string), string invoiceSectionName = default(string), System.Guid? purchasingSubscriptionGuid = default(System.Guid?), string purchasingSubscriptionName = default(string), decimal? quantity = default(decimal?), string region = default(string), string reservationOrderId = default(string), string reservationOrderName = default(string), string term = default(string))
            : base(id, name, type, tags)
        {
            Amount = amount;
            ArmSkuName = armSkuName;
            BillingFrequency = billingFrequency;
            BillingProfileId = billingProfileId;
            BillingProfileName = billingProfileName;
            Currency = currency;
            Description = description;
            EventDate = eventDate;
            EventType = eventType;
            Invoice = invoice;
            InvoiceId = invoiceId;
            InvoiceSectionId = invoiceSectionId;
            InvoiceSectionName = invoiceSectionName;
            PurchasingSubscriptionGuid = purchasingSubscriptionGuid;
            PurchasingSubscriptionName = purchasingSubscriptionName;
            Quantity = quantity;
            Region = region;
            ReservationOrderId = reservationOrderId;
            ReservationOrderName = reservationOrderName;
            Term = term;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the charge of the transaction.
        /// </summary>
        [JsonProperty(PropertyName = "properties.amount")]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// Gets this is the ARM Sku name. It can be used to join with the
        /// serviceType field in additional info in usage records.
        /// </summary>
        [JsonProperty(PropertyName = "properties.armSkuName")]
        public string ArmSkuName { get; private set; }

        /// <summary>
        /// Gets the billing frequency, which can be either one-time or
        /// recurring.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingFrequency")]
        public string BillingFrequency { get; private set; }

        /// <summary>
        /// Gets billing profile Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileId")]
        public string BillingProfileId { get; private set; }

        /// <summary>
        /// Gets billing profile name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileName")]
        public string BillingProfileName { get; private set; }

        /// <summary>
        /// Gets the ISO currency in which the transaction is charged, for
        /// example, USD.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currency")]
        public string Currency { get; private set; }

        /// <summary>
        /// Gets the description of the transaction.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets the date of the transaction
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventDate")]
        public System.DateTime? EventDate { get; private set; }

        /// <summary>
        /// Gets the type of the transaction (Purchase, Cancel, etc.)
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventType")]
        public string EventType { get; private set; }

        /// <summary>
        /// Gets invoice Number
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoice")]
        public string Invoice { get; private set; }

        /// <summary>
        /// Gets invoice Id as on the invoice where the specific transaction
        /// appears.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceId")]
        public string InvoiceId { get; private set; }

        /// <summary>
        /// Gets invoice Section Id
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionId")]
        public string InvoiceSectionId { get; private set; }

        /// <summary>
        /// Gets invoice Section Name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionName")]
        public string InvoiceSectionName { get; private set; }

        /// <summary>
        /// Gets the subscription guid that makes the transaction.
        /// </summary>
        [JsonProperty(PropertyName = "properties.purchasingSubscriptionGuid")]
        public System.Guid? PurchasingSubscriptionGuid { get; private set; }

        /// <summary>
        /// Gets the subscription name that makes the transaction.
        /// </summary>
        [JsonProperty(PropertyName = "properties.purchasingSubscriptionName")]
        public string PurchasingSubscriptionName { get; private set; }

        /// <summary>
        /// Gets the quantity of the transaction.
        /// </summary>
        [JsonProperty(PropertyName = "properties.quantity")]
        public decimal? Quantity { get; private set; }

        /// <summary>
        /// Gets the region of the transaction.
        /// </summary>
        [JsonProperty(PropertyName = "properties.region")]
        public string Region { get; private set; }

        /// <summary>
        /// Gets the reservation order ID is the identifier for a reservation
        /// purchase. Each reservation order ID represents a single purchase
        /// transaction. A reservation order contains reservations. The
        /// reservation order specifies the VM size and region for the
        /// reservations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reservationOrderId")]
        public string ReservationOrderId { get; private set; }

        /// <summary>
        /// Gets the name of the reservation order.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reservationOrderName")]
        public string ReservationOrderName { get; private set; }

        /// <summary>
        /// Gets this is the term of the transaction.
        /// </summary>
        [JsonProperty(PropertyName = "properties.term")]
        public string Term { get; private set; }

    }
}
