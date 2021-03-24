// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EncryptionEnforcementStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EncryptionEnforcementStatus
    {
        [EnumMember(Value = "unspecified")]
        Unspecified,
        [EnumMember(Value = "enabled")]
        Enabled,
        [EnumMember(Value = "disabled")]
        Disabled
    }
    internal static class EncryptionEnforcementStatusEnumExtension
    {
        internal static string ToSerializedValue(this EncryptionEnforcementStatus? value)
        {
            return value == null ? null : ((EncryptionEnforcementStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this EncryptionEnforcementStatus value)
        {
            switch( value )
            {
                case EncryptionEnforcementStatus.Unspecified:
                    return "unspecified";
                case EncryptionEnforcementStatus.Enabled:
                    return "enabled";
                case EncryptionEnforcementStatus.Disabled:
                    return "disabled";
            }
            return null;
        }

        internal static EncryptionEnforcementStatus? ParseEncryptionEnforcementStatus(this string value)
        {
            switch( value )
            {
                case "unspecified":
                    return EncryptionEnforcementStatus.Unspecified;
                case "enabled":
                    return EncryptionEnforcementStatus.Enabled;
                case "disabled":
                    return EncryptionEnforcementStatus.Disabled;
            }
            return null;
        }
    }
}
