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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The list of invoices.
    /// </summary>
    public partial class InvoiceListResult
    {
        /// <summary>
        /// Initializes a new instance of the InvoiceListResult class.
        /// </summary>
        public InvoiceListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InvoiceListResult class.
        /// </summary>
        /// <param name="value">The list of invoices.</param>
        /// <param name="nextLink">The link (url) to the next page of
        /// results.</param>
        public InvoiceListResult(IList<Invoice> value = default(IList<Invoice>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the list of invoices.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Invoice> Value { get; private set; }

        /// <summary>
        /// Gets the link (url) to the next page of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}
