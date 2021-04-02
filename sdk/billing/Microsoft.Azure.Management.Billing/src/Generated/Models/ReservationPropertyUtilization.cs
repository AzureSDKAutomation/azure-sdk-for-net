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
    /// Reservation utilization
    /// </summary>
    public partial class ReservationPropertyUtilization
    {
        /// <summary>
        /// Initializes a new instance of the ReservationPropertyUtilization
        /// class.
        /// </summary>
        public ReservationPropertyUtilization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReservationPropertyUtilization
        /// class.
        /// </summary>
        /// <param name="trend">The number of days trend for a
        /// reservation</param>
        /// <param name="aggregates">The array of aggregates of a reservation's
        /// utilization</param>
        public ReservationPropertyUtilization(string trend = default(string), IList<ReservationUtilizationAggregates> aggregates = default(IList<ReservationUtilizationAggregates>))
        {
            Trend = trend;
            Aggregates = aggregates;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the number of days trend for a reservation
        /// </summary>
        [JsonProperty(PropertyName = "trend")]
        public string Trend { get; private set; }

        /// <summary>
        /// Gets or sets the array of aggregates of a reservation's utilization
        /// </summary>
        [JsonProperty(PropertyName = "aggregates")]
        public IList<ReservationUtilizationAggregates> Aggregates { get; set; }

    }
}
