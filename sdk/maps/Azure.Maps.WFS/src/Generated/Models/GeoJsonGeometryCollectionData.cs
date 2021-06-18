// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.WFS.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class GeoJsonGeometryCollectionData
    {
        /// <summary>
        /// Initializes a new instance of the GeoJsonGeometryCollectionData
        /// class.
        /// </summary>
        public GeoJsonGeometryCollectionData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeoJsonGeometryCollectionData
        /// class.
        /// </summary>
        /// <param name="geometries">Contains a list of valid `GeoJSON`
        /// geometry objects. **Note** that coordinates in GeoJSON are in x, y
        /// order (longitude, latitude).</param>
        public GeoJsonGeometryCollectionData(IList<GeoJsonGeometry> geometries)
        {
            Geometries = geometries;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets contains a list of valid `GeoJSON` geometry objects.
        /// **Note** that coordinates in GeoJSON are in x, y order (longitude,
        /// latitude).
        /// </summary>
        [JsonProperty(PropertyName = "geometries")]
        public IList<GeoJsonGeometry> Geometries { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Geometries == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Geometries");
            }
        }
    }
}
