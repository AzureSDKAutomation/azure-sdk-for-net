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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response model for the List API. Returns a list of all the
    /// previously created aliases.
    /// </summary>
    public partial class AliasListResponse
    {
        /// <summary>
        /// Initializes a new instance of the AliasListResponse class.
        /// </summary>
        public AliasListResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AliasListResponse class.
        /// </summary>
        /// <param name="aliases">A list of all the previously created
        /// aliases.</param>
        /// <param name="nextLink">If present, the location of the next page of
        /// data.</param>
        public AliasListResponse(IList<AliasListItem> aliases = default(IList<AliasListItem>), string nextLink = default(string))
        {
            Aliases = aliases;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a list of all the previously created aliases.
        /// </summary>
        [JsonProperty(PropertyName = "aliases")]
        public IList<AliasListItem> Aliases { get; private set; }

        /// <summary>
        /// Gets if present, the location of the next page of data.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}
