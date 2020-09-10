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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Legacy Reservation transaction resource.
    /// </summary>
    public partial class LegacyReservationTransaction : ReservationTransaction
    {
        /// <summary>
        /// Initializes a new instance of the LegacyReservationTransaction
        /// class.
        /// </summary>
        public LegacyReservationTransaction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LegacyReservationTransaction
        /// class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="eventDate">The date of the transaction</param>
        /// <param name="reservationOrderId">The reservation order ID is the
        /// identifier for a reservation purchase. Each reservation order ID
        /// represents a single purchase transaction. A reservation order
        /// contains reservations. The reservation order specifies the VM size
        /// and region for the reservations.</param>
        /// <param name="description">The description of the
        /// transaction.</param>
        /// <param name="eventType">The type of the transaction (Purchase,
        /// Cancel, etc.)</param>
        /// <param name="quantity">The quantity of the transaction.</param>
        /// <param name="amount">The charge of the transaction.</param>
        /// <param name="currency">The ISO currency in which the transaction is
        /// charged, for example, USD.</param>
        /// <param name="reservationOrderName">The name of the reservation
        /// order.</param>
        /// <param name="purchasingEnrollment">The purchasing
        /// enrollment.</param>
        /// <param name="purchasingSubscriptionGuid">The subscription guid that
        /// makes the transaction.</param>
        /// <param name="purchasingSubscriptionName">The subscription name that
        /// makes the transaction.</param>
        /// <param name="armSkuName">This is the ARM Sku name. It can be used
        /// to join with the serviceType field in additional info in usage
        /// records.</param>
        /// <param name="term">This is the term of the transaction.</param>
        /// <param name="region">The region of the transaction.</param>
        /// <param name="accountName">The name of the account that makes the
        /// transaction.</param>
        /// <param name="accountOwnerEmail">The email of the account owner that
        /// makes the transaction.</param>
        /// <param name="departmentName">The department name.</param>
        /// <param name="costCenter">The cost center of this department if it
        /// is a department and a cost center is provided.</param>
        /// <param name="currentEnrollment">The current enrollment.</param>
        /// <param name="billingFrequency">The billing frequency, which can be
        /// either one-time or recurring.</param>
        public LegacyReservationTransaction(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.DateTime? eventDate = default(System.DateTime?), string reservationOrderId = default(string), string description = default(string), string eventType = default(string), decimal? quantity = default(decimal?), decimal? amount = default(decimal?), string currency = default(string), string reservationOrderName = default(string), string purchasingEnrollment = default(string), System.Guid? purchasingSubscriptionGuid = default(System.Guid?), string purchasingSubscriptionName = default(string), string armSkuName = default(string), string term = default(string), string region = default(string), string accountName = default(string), string accountOwnerEmail = default(string), string departmentName = default(string), string costCenter = default(string), string currentEnrollment = default(string), string billingFrequency = default(string))
            : base(id, name, type, tags, eventDate, reservationOrderId, description, eventType, quantity, amount, currency, reservationOrderName, purchasingEnrollment, purchasingSubscriptionGuid, purchasingSubscriptionName, armSkuName, term, region, accountName, accountOwnerEmail, departmentName, costCenter, currentEnrollment, billingFrequency)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
