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

    /// <summary>
    /// collection of GeoJSON features
    /// </summary>
    public partial class CollectionDefinitionResponse
    {
        /// <summary>
        /// Initializes a new instance of the CollectionDefinitionResponse
        /// class.
        /// </summary>
        public CollectionDefinitionResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CollectionDefinitionResponse
        /// class.
        /// </summary>
        /// <param name="idPrefix">prefix of the collection used</param>
        /// <param name="name">identifier of the collection used, for example,
        /// in URIs</param>
        /// <param name="geometryType">type of geometry returned. Possible
        /// values include: 'GeoJsonPoint', 'GeoJsonMultiPoint',
        /// 'GeoJsonLineString', 'GeoJsonMultiLineString', 'GeoJsonPolygon',
        /// 'GeoJsonMultiPolygon', 'GeoJsonGeometryCollection'</param>
        /// <param name="featureTypes">type of features returned</param>
        /// <param name="description">describes the collection</param>
        /// <param name="title">title of collection</param>
        /// <param name="properties">attributes of the collection used</param>
        /// <param name="links">Links to other WFS endpoints.</param>
        public CollectionDefinitionResponse(string idPrefix, string name, string geometryType, IList<string> featureTypes, string description = default(string), string title = default(string), string ontology = default(string), IList<DefinitionProperties> properties = default(IList<DefinitionProperties>), IList<WfsEndpointLink> links = default(IList<WfsEndpointLink>))
        {
            Description = description;
            IdPrefix = idPrefix;
            Name = name;
            Title = title;
            Ontology = ontology;
            GeometryType = geometryType;
            FeatureTypes = featureTypes;
            Properties = properties;
            Links = links;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes the collection
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets prefix of the collection used
        /// </summary>
        [JsonProperty(PropertyName = "idPrefix")]
        public string IdPrefix { get; set; }

        /// <summary>
        /// Gets or sets identifier of the collection used, for example, in
        /// URIs
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets title of collection
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ontology")]
        public string Ontology { get; set; }

        /// <summary>
        /// Gets or sets type of geometry returned. Possible values include:
        /// 'GeoJsonPoint', 'GeoJsonMultiPoint', 'GeoJsonLineString',
        /// 'GeoJsonMultiLineString', 'GeoJsonPolygon', 'GeoJsonMultiPolygon',
        /// 'GeoJsonGeometryCollection'
        /// </summary>
        [JsonProperty(PropertyName = "geometryType")]
        public string GeometryType { get; set; }

        /// <summary>
        /// Gets or sets type of features returned
        /// </summary>
        [JsonProperty(PropertyName = "featureTypes")]
        public IList<string> FeatureTypes { get; set; }

        /// <summary>
        /// Gets or sets attributes of the collection used
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IList<DefinitionProperties> Properties { get; set; }

        /// <summary>
        /// Gets or sets links to other WFS endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public IList<WfsEndpointLink> Links { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (IdPrefix == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IdPrefix");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (GeometryType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GeometryType");
            }
            if (FeatureTypes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FeatureTypes");
            }
            if (Properties != null)
            {
                foreach (var element in Properties)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Links != null)
            {
                foreach (var element1 in Links)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
