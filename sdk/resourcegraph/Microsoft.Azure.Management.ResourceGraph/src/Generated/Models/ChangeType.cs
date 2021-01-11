// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceGraph.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ChangeType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChangeType
    {
        [EnumMember(Value = "Create")]
        Create,
        [EnumMember(Value = "Update")]
        Update,
        [EnumMember(Value = "Delete")]
        Delete
    }
    internal static class ChangeTypeEnumExtension
    {
        internal static string ToSerializedValue(this ChangeType? value)
        {
            return value == null ? null : ((ChangeType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ChangeType value)
        {
            switch( value )
            {
                case ChangeType.Create:
                    return "Create";
                case ChangeType.Update:
                    return "Update";
                case ChangeType.Delete:
                    return "Delete";
            }
            return null;
        }

        internal static ChangeType? ParseChangeType(this string value)
        {
            switch( value )
            {
                case "Create":
                    return ChangeType.Create;
                case "Update":
                    return ChangeType.Update;
                case "Delete":
                    return ChangeType.Delete;
            }
            return null;
        }
    }
}
