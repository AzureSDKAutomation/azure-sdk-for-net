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
    /// This object is returned from a successful Search Address Reverse
    /// CrossStreet call
    /// </summary>
    public partial class SearchAddressReverseCrossStreetResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SearchAddressReverseCrossStreetResponse class.
        /// </summary>
        public SearchAddressReverseCrossStreetResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SearchAddressReverseCrossStreetResponse class.
        /// </summary>
        /// <param name="summary">Summary object for a Search Address Reverse
        /// Cross Street response</param>
        /// <param name="addresses">Addresses array</param>
        public SearchAddressReverseCrossStreetResponse(SearchCommonSummary summary = default(SearchCommonSummary), IList<SearchAddressReverseCrossStreetResult> addresses = default(IList<SearchAddressReverseCrossStreetResult>))
        {
            Summary = summary;
            Addresses = addresses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets summary object for a Search Address Reverse Cross Street
        /// response
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public SearchCommonSummary Summary { get; private set; }

        /// <summary>
        /// Gets addresses array
        /// </summary>
        [JsonProperty(PropertyName = "addresses")]
        public IList<SearchAddressReverseCrossStreetResult> Addresses { get; private set; }

    }
}
