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
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MediaGraphOutputSelectorOperator.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MediaGraphOutputSelectorOperator
    {
        /// <summary>
        /// A media type is the same type or a subtype.
        /// </summary>
        [EnumMember(Value = "is")]
        Is,
        /// <summary>
        /// A media type is not the same type or a subtype.
        /// </summary>
        [EnumMember(Value = "isNot")]
        IsNot
    }
    internal static class MediaGraphOutputSelectorOperatorEnumExtension
    {
        internal static string ToSerializedValue(this MediaGraphOutputSelectorOperator? value)
        {
            return value == null ? null : ((MediaGraphOutputSelectorOperator)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MediaGraphOutputSelectorOperator value)
        {
            switch( value )
            {
                case MediaGraphOutputSelectorOperator.Is:
                    return "is";
                case MediaGraphOutputSelectorOperator.IsNot:
                    return "isNot";
            }
            return null;
        }

        internal static MediaGraphOutputSelectorOperator? ParseMediaGraphOutputSelectorOperator(this string value)
        {
            switch( value )
            {
                case "is":
                    return MediaGraphOutputSelectorOperator.Is;
                case "isNot":
                    return MediaGraphOutputSelectorOperator.IsNot;
            }
            return null;
        }
    }
}
