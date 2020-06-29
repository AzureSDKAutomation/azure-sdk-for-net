// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Allowed formats for the image.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.MediaGraphImageFormatEncoded")]
    public partial class MediaGraphImageFormatEncoded : MediaGraphImageFormat
    {
        /// <summary>
        /// Initializes a new instance of the MediaGraphImageFormatEncoded
        /// class.
        /// </summary>
        public MediaGraphImageFormatEncoded()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaGraphImageFormatEncoded
        /// class.
        /// </summary>
        /// <param name="encoding">The different encoding formats that can be
        /// used for the image. Possible values include: 'Jpeg', 'Bmp',
        /// 'Png'</param>
        /// <param name="quality">The image quality (used for JPEG only). Value
        /// must be between 0 to 100 (best quality).</param>
        public MediaGraphImageFormatEncoded(MediaGraphImageEncodingFormat? encoding = default(MediaGraphImageEncodingFormat?), string quality = default(string))
        {
            Encoding = encoding;
            Quality = quality;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the different encoding formats that can be used for
        /// the image. Possible values include: 'Jpeg', 'Bmp', 'Png'
        /// </summary>
        [JsonProperty(PropertyName = "encoding")]
        public MediaGraphImageEncodingFormat? Encoding { get; set; }

        /// <summary>
        /// Gets or sets the image quality (used for JPEG only). Value must be
        /// between 0 to 100 (best quality).
        /// </summary>
        [JsonProperty(PropertyName = "quality")]
        public string Quality { get; set; }

    }
}
