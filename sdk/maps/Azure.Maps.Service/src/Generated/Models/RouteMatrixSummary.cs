// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Service.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Summary object
    /// </summary>
    public partial class RouteMatrixSummary
    {
        /// <summary>
        /// Initializes a new instance of the RouteMatrixSummary class.
        /// </summary>
        public RouteMatrixSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RouteMatrixSummary class.
        /// </summary>
        /// <param name="successfulRoutes">Number of successful routes in the
        /// response.</param>
        /// <param name="totalRoutes">Total number of routes requested. Number
        /// of cells in the input matrix.</param>
        public RouteMatrixSummary(int? successfulRoutes = default(int?), int? totalRoutes = default(int?))
        {
            SuccessfulRoutes = successfulRoutes;
            TotalRoutes = totalRoutes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets number of successful routes in the response.
        /// </summary>
        [JsonProperty(PropertyName = "successfulRoutes")]
        public int? SuccessfulRoutes { get; private set; }

        /// <summary>
        /// Gets total number of routes requested. Number of cells in the input
        /// matrix.
        /// </summary>
        [JsonProperty(PropertyName = "totalRoutes")]
        public int? TotalRoutes { get; private set; }

    }
}
