// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Search.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An item returned from Search Address Reverse Batch service call.
    /// </summary>
    public partial class SearchAddressReverseBatchItem : BatchItem
    {
        /// <summary>
        /// Initializes a new instance of the SearchAddressReverseBatchItem
        /// class.
        /// </summary>
        public SearchAddressReverseBatchItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SearchAddressReverseBatchItem
        /// class.
        /// </summary>
        /// <param name="statusCode">HTTP request status code.</param>
        /// <param name="response">The result of the query.
        /// SearchAddressReverseResponse if the query completed successfully,
        /// ErrorResponse otherwise.</param>
        public SearchAddressReverseBatchItem(double? statusCode = default(double?), SearchAddressReverseBatchItemResponse response = default(SearchAddressReverseBatchItemResponse))
            : base(statusCode)
        {
            Response = response;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the result of the query. SearchAddressReverseResponse if the
        /// query completed successfully, ErrorResponse otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "response")]
        public SearchAddressReverseBatchItemResponse Response { get; private set; }

    }
}
