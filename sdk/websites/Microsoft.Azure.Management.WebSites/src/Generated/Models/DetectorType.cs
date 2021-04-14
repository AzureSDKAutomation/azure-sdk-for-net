// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DetectorType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DetectorType
    {
        [EnumMember(Value = "Detector")]
        Detector,
        [EnumMember(Value = "Analysis")]
        Analysis,
        [EnumMember(Value = "CategoryOverview")]
        CategoryOverview
    }
    internal static class DetectorTypeEnumExtension
    {
        internal static string ToSerializedValue(this DetectorType? value)
        {
            return value == null ? null : ((DetectorType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DetectorType value)
        {
            switch( value )
            {
                case DetectorType.Detector:
                    return "Detector";
                case DetectorType.Analysis:
                    return "Analysis";
                case DetectorType.CategoryOverview:
                    return "CategoryOverview";
            }
            return null;
        }

        internal static DetectorType? ParseDetectorType(this string value)
        {
            switch( value )
            {
                case "Detector":
                    return DetectorType.Detector;
                case "Analysis":
                    return DetectorType.Analysis;
                case "CategoryOverview":
                    return DetectorType.CategoryOverview;
            }
            return null;
        }
    }
}
