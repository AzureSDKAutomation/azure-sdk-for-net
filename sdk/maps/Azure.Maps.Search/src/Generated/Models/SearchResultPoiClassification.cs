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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The classification for the POI being returned
    /// </summary>
    public partial class SearchResultPoiClassification
    {
        /// <summary>
        /// Initializes a new instance of the SearchResultPoiClassification
        /// class.
        /// </summary>
        public SearchResultPoiClassification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SearchResultPoiClassification
        /// class.
        /// </summary>
        /// <param name="code">Code property</param>
        /// <param name="names">Names array</param>
        public SearchResultPoiClassification(string code = default(string), IList<SearchResultPoiClassificationName> names = default(IList<SearchResultPoiClassificationName>))
        {
            Code = code;
            Names = names;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets code property
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets names array
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<SearchResultPoiClassificationName> Names { get; private set; }

    }
}
