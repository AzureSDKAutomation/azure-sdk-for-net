// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Route.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This object is returned from a successful Route Directions Batch
    /// service call.
    /// </summary>
    public partial class RouteDirectionsBatchResponse : BatchResponse
    {
        /// <summary>
        /// Initializes a new instance of the RouteDirectionsBatchResponse
        /// class.
        /// </summary>
        public RouteDirectionsBatchResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RouteDirectionsBatchResponse
        /// class.
        /// </summary>
        /// <param name="summary">Summary for the batch request</param>
        /// <param name="batchItems">Array containing the batch
        /// results.</param>
        public RouteDirectionsBatchResponse(BatchResponseSummary summary = default(BatchResponseSummary), IList<RouteDirectionsBatchItem> batchItems = default(IList<RouteDirectionsBatchItem>))
            : base(summary)
        {
            BatchItems = batchItems;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets array containing the batch results.
        /// </summary>
        [JsonProperty(PropertyName = "batchItems")]
        public IList<RouteDirectionsBatchItem> BatchItems { get; private set; }

    }
}
