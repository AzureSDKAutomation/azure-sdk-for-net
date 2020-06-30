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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Enables a graph to record media to an Azure Media Services asset, for
    /// subsequent playback.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.MediaGraphAssetSink")]
    public partial class MediaGraphAssetSink : MediaGraphSink
    {
        /// <summary>
        /// Initializes a new instance of the MediaGraphAssetSink class.
        /// </summary>
        public MediaGraphAssetSink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaGraphAssetSink class.
        /// </summary>
        /// <param name="name">Name to be used for the media graph
        /// sink.</param>
        /// <param name="inputs">An array of the names of the other nodes in
        /// the media graph, the outputs of which are used as input for this
        /// sink node.</param>
        /// <param name="assetNamePattern">A name pattern when creating new
        /// assets.</param>
        /// <param name="segmentLength">When writing media to an asset, wait
        /// until at least this duration of media has been accumulated on the
        /// Edge. Expressed in increments of 30 seconds, with a minimum of 30
        /// seconds and a recommended maximum of 5 minutes.</param>
        /// <param name="localMediaCachePath">Path to a local file system
        /// directory for temporary caching of media, before writing to an
        /// Asset. Used when the Edge device is temporarily disconnected from
        /// Azure.</param>
        /// <param name="localMediaCacheMaximumSizeMiB">Maximum amount of disk
        /// space that can be used for temporary caching of media.</param>
        public MediaGraphAssetSink(string name, IList<MediaGraphNodeInput> inputs, string assetNamePattern = default(string), System.TimeSpan? segmentLength = default(System.TimeSpan?), string localMediaCachePath = default(string), string localMediaCacheMaximumSizeMiB = default(string))
            : base(name, inputs)
        {
            AssetNamePattern = assetNamePattern;
            SegmentLength = segmentLength;
            LocalMediaCachePath = localMediaCachePath;
            LocalMediaCacheMaximumSizeMiB = localMediaCacheMaximumSizeMiB;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a name pattern when creating new assets.
        /// </summary>
        [JsonProperty(PropertyName = "assetNamePattern")]
        public string AssetNamePattern { get; set; }

        /// <summary>
        /// Gets or sets when writing media to an asset, wait until at least
        /// this duration of media has been accumulated on the Edge. Expressed
        /// in increments of 30 seconds, with a minimum of 30 seconds and a
        /// recommended maximum of 5 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "segmentLength")]
        public System.TimeSpan? SegmentLength { get; set; }

        /// <summary>
        /// Gets or sets path to a local file system directory for temporary
        /// caching of media, before writing to an Asset. Used when the Edge
        /// device is temporarily disconnected from Azure.
        /// </summary>
        [JsonProperty(PropertyName = "localMediaCachePath")]
        public string LocalMediaCachePath { get; set; }

        /// <summary>
        /// Gets or sets maximum amount of disk space that can be used for
        /// temporary caching of media.
        /// </summary>
        [JsonProperty(PropertyName = "localMediaCacheMaximumSizeMiB")]
        public string LocalMediaCacheMaximumSizeMiB { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
