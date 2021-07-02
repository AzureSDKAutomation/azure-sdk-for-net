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
    /// A valid `GeoJSON FeatureCollection` object type. Please refer to [RFC
    /// 7946](https://tools.ietf.org/html/rfc7946#section-3.3) for details.
    /// </summary>
    public partial class GeoJsonFeatureCollection
    {
        /// <summary>
        /// Initializes a new instance of the GeoJsonFeatureCollection class.
        /// </summary>
        public GeoJsonFeatureCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeoJsonFeatureCollection class.
        /// </summary>
        /// <param name="type">Specifies the `GeoJSON` type. Must be one of the
        /// nine valid GeoJSON object types - Point, MultiPoint, LineString,
        /// MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature
        /// and FeatureCollection. Possible values include: 'GeoJsonPoint',
        /// 'GeoJsonMultiPoint', 'GeoJsonLineString', 'GeoJsonMultiLineString',
        /// 'GeoJsonPolygon', 'GeoJsonMultiPolygon',
        /// 'GeoJsonGeometryCollection', 'GeoJsonFeature',
        /// 'GeoJsonFeatureCollection'</param>
        /// <param name="features">Contains a list of valid `GeoJSON Feature`
        /// objects.</param>
        public GeoJsonFeatureCollection(string type, IList<GeoJsonFeature> features)
        {
            Type = type;
            Features = features;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the `GeoJSON` type. Must be one of the nine
        /// valid GeoJSON object types - Point, MultiPoint, LineString,
        /// MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature
        /// and FeatureCollection. Possible values include: 'GeoJsonPoint',
        /// 'GeoJsonMultiPoint', 'GeoJsonLineString', 'GeoJsonMultiLineString',
        /// 'GeoJsonPolygon', 'GeoJsonMultiPolygon',
        /// 'GeoJsonGeometryCollection', 'GeoJsonFeature',
        /// 'GeoJsonFeatureCollection'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets contains a list of valid `GeoJSON Feature` objects.
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public IList<GeoJsonFeature> Features { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Features == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Features");
            }
            if (Features != null)
            {
                foreach (var element in Features)
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
