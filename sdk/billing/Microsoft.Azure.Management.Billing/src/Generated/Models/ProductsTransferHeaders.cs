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
    using System.Linq;

    /// <summary>
    /// Defines headers for Transfer operation.
    /// </summary>
    public partial class ProductsTransferHeaders
    {
        /// <summary>
        /// Initializes a new instance of the ProductsTransferHeaders class.
        /// </summary>
        public ProductsTransferHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProductsTransferHeaders class.
        /// </summary>
        /// <param name="location">Location URI to poll for result</param>
        /// <param name="retryAfter">Recommended time to wait before making
        /// another request to check the status of the operation. The time is
        /// specified in seconds.</param>
        public ProductsTransferHeaders(string location = default(string), int? retryAfter = default(int?))
        {
            Location = location;
            RetryAfter = retryAfter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets location URI to poll for result
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets recommended time to wait before making another request
        /// to check the status of the operation. The time is specified in
        /// seconds.
        /// </summary>
        [JsonProperty(PropertyName = "Retry-After")]
        public int? RetryAfter { get; set; }

    }
}
