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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Indication when the internal search engine has applied a geospatial
    /// bias to improve the ranking of results.  In  some methods, this can be
    /// affected by setting the lat and lon parameters where available.  In
    /// other cases it is  purely internal.
    /// </summary>
    public partial class SearchSummaryGeoBias
    {
        /// <summary>
        /// Initializes a new instance of the SearchSummaryGeoBias class.
        /// </summary>
        public SearchSummaryGeoBias()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SearchSummaryGeoBias class.
        /// </summary>
        /// <param name="lat">Latitude property</param>
        /// <param name="lon">Longitude property</param>
        public SearchSummaryGeoBias(double? lat = default(double?), double? lon = default(double?))
        {
            Lat = lat;
            Lon = lon;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets latitude property
        /// </summary>
        [JsonProperty(PropertyName = "lat")]
        public double? Lat { get; private set; }

        /// <summary>
        /// Gets longitude property
        /// </summary>
        [JsonProperty(PropertyName = "lon")]
        public double? Lon { get; private set; }

    }
}
