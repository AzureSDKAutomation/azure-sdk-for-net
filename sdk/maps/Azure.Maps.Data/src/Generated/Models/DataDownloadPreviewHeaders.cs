// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Data.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for DownloadPreview operation.
    /// </summary>
    public partial class DataDownloadPreviewHeaders
    {
        /// <summary>
        /// Initializes a new instance of the DataDownloadPreviewHeaders class.
        /// </summary>
        public DataDownloadPreviewHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataDownloadPreviewHeaders class.
        /// </summary>
        /// <param name="contentType">The content-type for the Download API
        /// response.</param>
        public DataDownloadPreviewHeaders(string contentType = default(string))
        {
            ContentType = contentType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the content-type for the Download API response.
        /// </summary>
        [JsonProperty(PropertyName = "Content-Type")]
        public string ContentType { get; set; }

    }
}
