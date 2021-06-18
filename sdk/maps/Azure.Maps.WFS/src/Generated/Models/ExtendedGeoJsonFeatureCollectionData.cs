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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ExtendedGeoJsonFeatureCollectionData
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ExtendedGeoJsonFeatureCollectionData class.
        /// </summary>
        public ExtendedGeoJsonFeatureCollectionData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ExtendedGeoJsonFeatureCollectionData class.
        /// </summary>
        /// <param name="numberReturned">Number of returned features.</param>
        /// <param name="links">Links to other WFS endpoints.</param>
        public ExtendedGeoJsonFeatureCollectionData(string ontology = default(string), int? numberReturned = default(int?), IList<WfsEndpointLink> links = default(IList<WfsEndpointLink>))
        {
            Ontology = ontology;
            NumberReturned = numberReturned;
            Links = links;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ontology")]
        public string Ontology { get; set; }

        /// <summary>
        /// Gets or sets number of returned features.
        /// </summary>
        [JsonProperty(PropertyName = "numberReturned")]
        public int? NumberReturned { get; set; }

        /// <summary>
        /// Gets or sets links to other WFS endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public IList<WfsEndpointLink> Links { get; set; }

    }
}
