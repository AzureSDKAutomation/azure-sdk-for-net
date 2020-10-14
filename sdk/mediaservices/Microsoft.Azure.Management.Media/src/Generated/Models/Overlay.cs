// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Base type for all overlays - image, audio or video.
    /// </summary>
    public partial class Overlay
    {
        /// <summary>
        /// Initializes a new instance of the Overlay class.
        /// </summary>
        public Overlay()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Overlay class.
        /// </summary>
        /// <param name="inputLabel">The label of the job input which is to be
        /// used as an overlay. The Input must specify exactly one file. You
        /// can specify an image file in JPG or PNG formats, or an audio file
        /// (such as a WAV, MP3, WMA or M4A file), or a video file. See
        /// https://aka.ms/mesformats for the complete list of supported audio
        /// and video file formats.</param>
        /// <param name="start">The start position, with reference to the input
        /// video, at which the overlay starts. The value should be in ISO 8601
        /// format. For example, PT05S to start the overlay at 5 seconds into
        /// the input video. If not specified the overlay starts from the
        /// beginning of the input video.</param>
        /// <param name="end">The end position, with reference to the input
        /// video, at which the overlay ends. The value should be in ISO 8601
        /// format. For example, PT30S to end the overlay at 30 seconds into
        /// the input video. If not specified or the value is greater than the
        /// input video duration, the overlay will be applied until the end of
        /// the input video if the overlay media duration is greater than the
        /// input video duration, else the overlay will last as long as the
        /// overlay media duration.</param>
        /// <param name="fadeInDuration">The duration over which the overlay
        /// fades in onto the input video. The value should be in ISO 8601
        /// duration format. If not specified the default behavior is to have
        /// no fade in (same as PT0S).</param>
        /// <param name="fadeOutDuration">The duration over which the overlay
        /// fades out of the input video. The value should be in ISO 8601
        /// duration format. If not specified the default behavior is to have
        /// no fade out (same as PT0S).</param>
        /// <param name="audioGainLevel">The gain level of audio in the
        /// overlay. The value should be in the range [0, 1.0]. The default is
        /// 1.0.</param>
        public Overlay(string inputLabel, System.TimeSpan? start = default(System.TimeSpan?), System.TimeSpan? end = default(System.TimeSpan?), System.TimeSpan? fadeInDuration = default(System.TimeSpan?), System.TimeSpan? fadeOutDuration = default(System.TimeSpan?), double? audioGainLevel = default(double?))
        {
            InputLabel = inputLabel;
            Start = start;
            End = end;
            FadeInDuration = fadeInDuration;
            FadeOutDuration = fadeOutDuration;
            AudioGainLevel = audioGainLevel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the label of the job input which is to be used as an
        /// overlay. The Input must specify exactly one file. You can specify
        /// an image file in JPG or PNG formats, or an audio file (such as a
        /// WAV, MP3, WMA or M4A file), or a video file. See
        /// https://aka.ms/mesformats for the complete list of supported audio
        /// and video file formats.
        /// </summary>
        [JsonProperty(PropertyName = "inputLabel")]
        public string InputLabel { get; set; }

        /// <summary>
        /// Gets or sets the start position, with reference to the input video,
        /// at which the overlay starts. The value should be in ISO 8601
        /// format. For example, PT05S to start the overlay at 5 seconds into
        /// the input video. If not specified the overlay starts from the
        /// beginning of the input video.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public System.TimeSpan? Start { get; set; }

        /// <summary>
        /// Gets or sets the end position, with reference to the input video,
        /// at which the overlay ends. The value should be in ISO 8601 format.
        /// For example, PT30S to end the overlay at 30 seconds into the input
        /// video. If not specified or the value is greater than the input
        /// video duration, the overlay will be applied until the end of the
        /// input video if the overlay media duration is greater than the input
        /// video duration, else the overlay will last as long as the overlay
        /// media duration.
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public System.TimeSpan? End { get; set; }

        /// <summary>
        /// Gets or sets the duration over which the overlay fades in onto the
        /// input video. The value should be in ISO 8601 duration format. If
        /// not specified the default behavior is to have no fade in (same as
        /// PT0S).
        /// </summary>
        [JsonProperty(PropertyName = "fadeInDuration")]
        public System.TimeSpan? FadeInDuration { get; set; }

        /// <summary>
        /// Gets or sets the duration over which the overlay fades out of the
        /// input video. The value should be in ISO 8601 duration format. If
        /// not specified the default behavior is to have no fade out (same as
        /// PT0S).
        /// </summary>
        [JsonProperty(PropertyName = "fadeOutDuration")]
        public System.TimeSpan? FadeOutDuration { get; set; }

        /// <summary>
        /// Gets or sets the gain level of audio in the overlay. The value
        /// should be in the range [0, 1.0]. The default is 1.0.
        /// </summary>
        [JsonProperty(PropertyName = "audioGainLevel")]
        public double? AudioGainLevel { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (InputLabel == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InputLabel");
            }
        }
    }
}
