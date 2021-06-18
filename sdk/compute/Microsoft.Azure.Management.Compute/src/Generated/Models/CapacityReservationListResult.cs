// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The list Capacity Reservation operation response.
    /// </summary>
    public partial class CapacityReservationListResult
    {
        /// <summary>
        /// Initializes a new instance of the CapacityReservationListResult
        /// class.
        /// </summary>
        public CapacityReservationListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapacityReservationListResult
        /// class.
        /// </summary>
        /// <param name="value">The list of Capacity Reservations</param>
        /// <param name="nextLink">The URI to fetch the next page of Capacity
        /// Reservations. Call ListNext() with this URI to fetch the next page
        /// of Capacity Reservations.</param>
        public CapacityReservationListResult(IList<CapacityReservation> value, string nextLink = default(string))
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
        /// Gets or sets the list of Capacity Reservations
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<CapacityReservation> Value { get; set; }

        /// <summary>
        /// Gets or sets the URI to fetch the next page of Capacity
        /// Reservations. Call ListNext() with this URI to fetch the next page
        /// of Capacity Reservations.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
            if (Value != null)
            {
                foreach (var element in Value)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
