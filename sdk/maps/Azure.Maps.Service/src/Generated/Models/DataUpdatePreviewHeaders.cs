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
    /// Defines headers for UpdatePreview operation.
    /// </summary>
    public partial class DataUpdatePreviewHeaders
    {
        /// <summary>
        /// Initializes a new instance of the DataUpdatePreviewHeaders class.
        /// </summary>
        public DataUpdatePreviewHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataUpdatePreviewHeaders class.
        /// </summary>
        /// <param name="resourceLocation">If successful, a URI where details
        /// on the newly created resource can be found.</param>
        /// <param name="operationLocation">New URL to check for the results of
        /// the long running process.</param>
        public DataUpdatePreviewHeaders(string resourceLocation = default(string), string operationLocation = default(string))
        {
            ResourceLocation = resourceLocation;
            OperationLocation = operationLocation;
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

        /// <summary>
        /// Gets or sets new URL to check for the results of the long running
        /// process.
        /// </summary>
        [JsonProperty(PropertyName = "Operation-Location")]
        public string OperationLocation { get; set; }

    }
}
