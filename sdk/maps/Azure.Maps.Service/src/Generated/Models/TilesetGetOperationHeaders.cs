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
    /// Defines headers for GetOperation operation.
    /// </summary>
    public partial class TilesetGetOperationHeaders
    {
        /// <summary>
        /// Initializes a new instance of the TilesetGetOperationHeaders class.
        /// </summary>
        public TilesetGetOperationHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TilesetGetOperationHeaders class.
        /// </summary>
        /// <param name="resourceLocation">If successful, a URI where details
        /// on the newly created resource can be found.</param>
        public TilesetGetOperationHeaders(string resourceLocation = default(string))
        {
            ResourceLocation = resourceLocation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if successful, a URI where details on the newly
        /// created resource can be found.
        /// </summary>
        [JsonProperty(PropertyName = "Resource-Location")]
        public string ResourceLocation { get; set; }

    }
}
