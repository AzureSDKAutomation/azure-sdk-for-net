// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Tileset.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response model for the Tileset List API. Returns a list of all
    /// tilesets.
    /// </summary>
    public partial class TilesetListResponse
    {
        /// <summary>
        /// Initializes a new instance of the TilesetListResponse class.
        /// </summary>
        public TilesetListResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TilesetListResponse class.
        /// </summary>
        /// <param name="tilesets">A list of all tilesets.</param>
        /// <param name="nextLink">If present, the location of the next page of
        /// data.</param>
        public TilesetListResponse(IList<TilesetDetailInfo> tilesets = default(IList<TilesetDetailInfo>), string nextLink = default(string))
        {
            Tilesets = tilesets;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a list of all tilesets.
        /// </summary>
        [JsonProperty(PropertyName = "tilesets")]
        public IList<TilesetDetailInfo> Tilesets { get; private set; }

        /// <summary>
        /// Gets if present, the location of the next page of data.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}
