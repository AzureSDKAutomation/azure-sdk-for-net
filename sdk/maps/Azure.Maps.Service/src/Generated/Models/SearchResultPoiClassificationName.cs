// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Service.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Name for the classification
    /// </summary>
    public partial class SearchResultPoiClassificationName
    {
        /// <summary>
        /// Initializes a new instance of the SearchResultPoiClassificationName
        /// class.
        /// </summary>
        public SearchResultPoiClassificationName()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SearchResultPoiClassificationName
        /// class.
        /// </summary>
        /// <param name="nameLocale">Name Locale property</param>
        /// <param name="name">Name property</param>
        public SearchResultPoiClassificationName(string nameLocale = default(string), string name = default(string))
        {
            NameLocale = nameLocale;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name Locale property
        /// </summary>
        [JsonProperty(PropertyName = "nameLocale")]
        public string NameLocale { get; private set; }

        /// <summary>
        /// Gets name property
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

    }
}
