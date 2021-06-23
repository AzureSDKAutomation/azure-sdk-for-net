// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Mobility.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The price of a ticket that the user is expected to purchase throughout
    /// this itinerary.
    /// </summary>
    public partial class FareTicket
    {
        /// <summary>
        /// Initializes a new instance of the FareTicket class.
        /// </summary>
        public FareTicket()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FareTicket class.
        /// </summary>
        /// <param name="amount">Price of the ticket in cents. For example,
        /// $5.00 is returned as ‘500’.</param>
        /// <param name="currencyCode">Currency code, for example for US
        /// dollars “USD”.</param>
        public FareTicket(int? amount = default(int?), string currencyCode = default(string))
        {
            Amount = amount;
            CurrencyCode = currencyCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets price of the ticket in cents. For example, $5.00 is
        /// returned as ‘500’.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// Gets or sets currency code, for example for US dollars “USD”.
        /// </summary>
        [JsonProperty(PropertyName = "currencyCode")]
        public string CurrencyCode { get; set; }

    }
}
