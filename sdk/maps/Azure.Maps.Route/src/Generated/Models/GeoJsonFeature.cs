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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A valid `GeoJSON Feature` object type. Please refer to [RFC
    /// 7946](https://tools.ietf.org/html/rfc7946#section-3.2) for details.
    /// </summary>
    public partial class GeoJsonFeature
    {
        /// <summary>
        /// Initializes a new instance of the GeoJsonFeature class.
        /// </summary>
        public GeoJsonFeature()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeoJsonFeature class.
        /// </summary>
        /// <param name="type">Specifies the `GeoJSON` type. Must be one of the
        /// nine valid GeoJSON object types - Point, MultiPoint, LineString,
        /// MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature
        /// and FeatureCollection. Possible values include: 'GeoJsonPoint',
        /// 'GeoJsonMultiPoint', 'GeoJsonLineString', 'GeoJsonMultiLineString',
        /// 'GeoJsonPolygon', 'GeoJsonMultiPolygon',
        /// 'GeoJsonGeometryCollection', 'GeoJsonFeature',
        /// 'GeoJsonFeatureCollection'</param>
        /// <param name="properties">Properties can contain any additional
        /// metadata about the `Feature`. Value can be any JSON object or a
        /// JSON null value</param>
        /// <param name="id">Identifier for the feature.</param>
        /// <param name="featureType">The type of the feature. The value
        /// depends on the data model the current feature is part of. Some data
        /// models may have an empty value.</param>
        public GeoJsonFeature(string type, GeoJsonGeometry geometry, object properties = default(object), string id = default(string), string featureType = default(string))
        {
            Type = type;
            Geometry = geometry;
            Properties = properties;
            Id = id;
            FeatureType = featureType;
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
        /// </summary>
        [JsonProperty(PropertyName = "geometry")]
        public GeoJsonGeometry Geometry { get; set; }

        /// <summary>
        /// Gets or sets properties can contain any additional metadata about
        /// the `Feature`. Value can be any JSON object or a JSON null value
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

        /// <summary>
        /// Gets or sets identifier for the feature.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the feature. The value depends on the data
        /// model the current feature is part of. Some data models may have an
        /// empty value.
        /// </summary>
        [JsonProperty(PropertyName = "featureType")]
        public string FeatureType { get; set; }

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
            if (Geometry == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Geometry");
            }
        }
    }
}
