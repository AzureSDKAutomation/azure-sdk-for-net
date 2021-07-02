// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Render.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This object is returned from a successful Get Copyright Caption call
    /// </summary>
    public partial class GetCopyrightCaptionResult
    {
        /// <summary>
        /// Initializes a new instance of the GetCopyrightCaptionResult class.
        /// </summary>
        public GetCopyrightCaptionResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetCopyrightCaptionResult class.
        /// </summary>
        /// <param name="formatVersion">Format Version property</param>
        /// <param name="copyrightsCaption">Copyrights Caption property</param>
        public GetCopyrightCaptionResult(string formatVersion = default(string), string copyrightsCaption = default(string))
        {
            FormatVersion = formatVersion;
            CopyrightsCaption = copyrightsCaption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets format Version property
        /// </summary>
        [JsonProperty(PropertyName = "formatVersion")]
        public string FormatVersion { get; private set; }

        /// <summary>
        /// Gets copyrights Caption property
        /// </summary>
        [JsonProperty(PropertyName = "copyrightsCaption")]
        public string CopyrightsCaption { get; private set; }

    }
}
