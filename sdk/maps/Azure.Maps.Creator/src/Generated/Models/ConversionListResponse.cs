// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Creator.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response model for the Conversion List API.
    /// </summary>
    public partial class ConversionListResponse
    {
        /// <summary>
        /// Initializes a new instance of the ConversionListResponse class.
        /// </summary>
        public ConversionListResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConversionListResponse class.
        /// </summary>
        /// <param name="conversions">A list of all the previously submitted
        /// conversion requests.</param>
        /// <param name="nextLink">If present, the location of the next page of
        /// data.</param>
        public ConversionListResponse(IList<ConversionListDetailInfo> conversions = default(IList<ConversionListDetailInfo>), string nextLink = default(string))
        {
            Conversions = conversions;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a list of all the previously submitted conversion requests.
        /// </summary>
        [JsonProperty(PropertyName = "conversions")]
        public IList<ConversionListDetailInfo> Conversions { get; private set; }

        /// <summary>
        /// Gets if present, the location of the next page of data.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}
