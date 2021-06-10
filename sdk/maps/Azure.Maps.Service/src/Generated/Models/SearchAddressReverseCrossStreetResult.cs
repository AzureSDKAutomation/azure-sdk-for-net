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
    /// Result object for a Search Address Reverse Cross Street response
    /// </summary>
    public partial class SearchAddressReverseCrossStreetResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SearchAddressReverseCrossStreetResult class.
        /// </summary>
        public SearchAddressReverseCrossStreetResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SearchAddressReverseCrossStreetResult class.
        /// </summary>
        /// <param name="position">Position property in the form of
        /// "{latitude},{longitude}"</param>
        public SearchAddressReverseCrossStreetResult(SearchResultAddress address = default(SearchResultAddress), string position = default(string))
        {
            Address = address;
            Position = position;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public SearchResultAddress Address { get; set; }

        /// <summary>
        /// Gets position property in the form of "{latitude},{longitude}"
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public string Position { get; private set; }

    }
}
