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
    /// Defines values for ConfigReferenceSource.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConfigReferenceSource
    {
        [EnumMember(Value = "KeyVault")]
        KeyVault
    }
    internal static class ConfigReferenceSourceEnumExtension
    {
        internal static string ToSerializedValue(this ConfigReferenceSource? value)
        {
            return value == null ? null : ((ConfigReferenceSource)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ConfigReferenceSource value)
        {
            switch( value )
            {
                case ConfigReferenceSource.KeyVault:
                    return "KeyVault";
            }
            return null;
        }

        internal static ConfigReferenceSource? ParseConfigReferenceSource(this string value)
        {
            switch( value )
            {
                case "KeyVault":
                    return ConfigReferenceSource.KeyVault;
            }
            return null;
        }
    }
}
