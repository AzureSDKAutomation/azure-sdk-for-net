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
    /// Batch Query object
    /// </summary>
    public partial class BatchRequestBodyBatchItemsItem
    {
        /// <summary>
        /// Initializes a new instance of the BatchRequestBodyBatchItemsItem
        /// class.
        /// </summary>
        public BatchRequestBodyBatchItemsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchRequestBodyBatchItemsItem
        /// class.
        /// </summary>
        /// <param name="query">Partial query string.</param>
        public BatchRequestBodyBatchItemsItem(string query = default(string))
        {
            Query = query;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets partial query string.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

    }
}
