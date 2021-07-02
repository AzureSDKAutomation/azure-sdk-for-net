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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Data contained by a `GeoJson Point`.
    /// </summary>
    public partial class GeoJsonPointData
    {
        /// <summary>
        /// Initializes a new instance of the GeoJsonPointData class.
        /// </summary>
        public GeoJsonPointData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeoJsonPointData class.
        /// </summary>
        public GeoJsonPointData(IList<double?> coordinates)
        {
            Coordinates = coordinates;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "coordinates")]
        public IList<double?> Coordinates { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Coordinates == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Coordinates");
            }
        }
    }
}
