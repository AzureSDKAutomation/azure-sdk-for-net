// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DataMaskingState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataMaskingState
    {
        [EnumMember(Value = "Disabled")]
        Disabled,
        [EnumMember(Value = "Enabled")]
        Enabled
    }
    internal static class DataMaskingStateEnumExtension
    {
        internal static string ToSerializedValue(this DataMaskingState? value)
        {
            return value == null ? null : ((DataMaskingState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DataMaskingState value)
        {
            switch( value )
            {
                case DataMaskingState.Disabled:
                    return "Disabled";
                case DataMaskingState.Enabled:
                    return "Enabled";
            }
            return null;
        }

        internal static DataMaskingState? ParseDataMaskingState(this string value)
        {
            switch( value )
            {
                case "Disabled":
                    return DataMaskingState.Disabled;
                case "Enabled":
                    return DataMaskingState.Enabled;
            }
            return null;
        }
    }
}
