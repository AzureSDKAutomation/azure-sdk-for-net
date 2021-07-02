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
    using System.Linq;

    /// <summary>
    /// Optimized way point object.
    /// </summary>
    public partial class RouteOptimizedWaypoint
    {
        /// <summary>
        /// Initializes a new instance of the RouteOptimizedWaypoint class.
        /// </summary>
        public RouteOptimizedWaypoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RouteOptimizedWaypoint class.
        /// </summary>
        /// <param name="providedIndex">Way point index provided by the
        /// user.</param>
        /// <param name="optimizedIndex">Optimized way point index from the
        /// system.</param>
        public RouteOptimizedWaypoint(int? providedIndex = default(int?), int? optimizedIndex = default(int?))
        {
            ProvidedIndex = providedIndex;
            OptimizedIndex = optimizedIndex;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets way point index provided by the user.
        /// </summary>
        [JsonProperty(PropertyName = "providedIndex")]
        public int? ProvidedIndex { get; private set; }

        /// <summary>
        /// Gets optimized way point index from the system.
        /// </summary>
        [JsonProperty(PropertyName = "optimizedIndex")]
        public int? OptimizedIndex { get; private set; }

    }
}
