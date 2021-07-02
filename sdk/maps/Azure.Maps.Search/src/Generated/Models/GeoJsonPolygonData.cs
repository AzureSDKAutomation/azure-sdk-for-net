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

    public partial class GeoJsonPolygonData
    {
        /// <summary>
        /// Initializes a new instance of the GeoJsonPolygonData class.
        /// </summary>
        public GeoJsonPolygonData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeoJsonPolygonData class.
        /// </summary>
        /// <param name="coordinates">Coordinates for the `GeoJson Polygon`
        /// geometry type.</param>
        public GeoJsonPolygonData(IList<IList<IList<double?>>> coordinates)
        {
            Coordinates = coordinates;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets coordinates for the `GeoJson Polygon` geometry type.
        /// </summary>
        [JsonProperty(PropertyName = "coordinates")]
        public IList<IList<IList<double?>>> Coordinates { get; set; }

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
