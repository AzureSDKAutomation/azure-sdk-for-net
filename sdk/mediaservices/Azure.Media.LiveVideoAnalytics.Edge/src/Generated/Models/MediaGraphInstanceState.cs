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
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MediaGraphInstanceState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MediaGraphInstanceState
    {
        /// <summary>
        /// Inactive state.
        /// </summary>
        [EnumMember(Value = "Inactive")]
        Inactive,
        /// <summary>
        /// Activating state.
        /// </summary>
        [EnumMember(Value = "Activating")]
        Activating,
        /// <summary>
        /// Active state.
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,
        /// <summary>
        /// Deactivating state.
        /// </summary>
        [EnumMember(Value = "Deactivating")]
        Deactivating
    }
    internal static class MediaGraphInstanceStateEnumExtension
    {
        internal static string ToSerializedValue(this MediaGraphInstanceState? value)
        {
            return value == null ? null : ((MediaGraphInstanceState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MediaGraphInstanceState value)
        {
            switch( value )
            {
                case MediaGraphInstanceState.Inactive:
                    return "Inactive";
                case MediaGraphInstanceState.Activating:
                    return "Activating";
                case MediaGraphInstanceState.Active:
                    return "Active";
                case MediaGraphInstanceState.Deactivating:
                    return "Deactivating";
            }
            return null;
        }

        internal static MediaGraphInstanceState? ParseMediaGraphInstanceState(this string value)
        {
            switch( value )
            {
                case "Inactive":
                    return MediaGraphInstanceState.Inactive;
                case "Activating":
                    return MediaGraphInstanceState.Activating;
                case "Active":
                    return MediaGraphInstanceState.Active;
                case "Deactivating":
                    return MediaGraphInstanceState.Deactivating;
            }
            return null;
        }
    }
}
