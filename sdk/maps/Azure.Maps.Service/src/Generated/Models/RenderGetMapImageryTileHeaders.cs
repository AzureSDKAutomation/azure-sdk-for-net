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
    /// Defines headers for GetMapImageryTile operation.
    /// </summary>
    public partial class RenderGetMapImageryTileHeaders
    {
        /// <summary>
        /// Initializes a new instance of the RenderGetMapImageryTileHeaders
        /// class.
        /// </summary>
        public RenderGetMapImageryTileHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RenderGetMapImageryTileHeaders
        /// class.
        /// </summary>
        /// <param name="contentType">The content-type for the
        /// response.</param>
        public RenderGetMapImageryTileHeaders(string contentType = default(string))
        {
            ContentType = contentType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the content-type for the response.
        /// </summary>
        [JsonProperty(PropertyName = "Content-Type")]
        public string ContentType { get; set; }

    }
}
