// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Media.Edge.LiveVideoAnalytics.Client.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for MediaGraphImageScaleMode.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(MediaGraphImageScaleModeConverter))]
    public struct MediaGraphImageScaleMode : System.IEquatable<MediaGraphImageScaleMode>
    {
        private MediaGraphImageScaleMode(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Use the same aspect ratio as the input frame.
        /// </summary>
        public static readonly MediaGraphImageScaleMode PreserveAspectRatio = "PreserveAspectRatio";

        /// <summary>
        /// Center pad the input frame to match the given dimensions.
        /// </summary>
        public static readonly MediaGraphImageScaleMode Pad = "Pad";

        /// <summary>
        /// Stretch input frame to match given dimensions.
        /// </summary>
        public static readonly MediaGraphImageScaleMode Stretch = "Stretch";


        /// <summary>
        /// Underlying value of enum MediaGraphImageScaleMode
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for MediaGraphImageScaleMode
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type MediaGraphImageScaleMode
        /// </summary>
        public bool Equals(MediaGraphImageScaleMode e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to MediaGraphImageScaleMode
        /// </summary>
        public static implicit operator MediaGraphImageScaleMode(string value)
        {
            return new MediaGraphImageScaleMode(value);
        }

        /// <summary>
        /// Implicit operator to convert MediaGraphImageScaleMode to string
        /// </summary>
        public static implicit operator string(MediaGraphImageScaleMode e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum MediaGraphImageScaleMode
        /// </summary>
        public static bool operator == (MediaGraphImageScaleMode e1, MediaGraphImageScaleMode e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum MediaGraphImageScaleMode
        /// </summary>
        public static bool operator != (MediaGraphImageScaleMode e1, MediaGraphImageScaleMode e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for MediaGraphImageScaleMode
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is MediaGraphImageScaleMode && Equals((MediaGraphImageScaleMode)obj);
        }

        /// <summary>
        /// Returns for hashCode MediaGraphImageScaleMode
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
