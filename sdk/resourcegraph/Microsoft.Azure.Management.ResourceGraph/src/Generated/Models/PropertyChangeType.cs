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
    /// Defines values for PropertyChangeType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PropertyChangeType
    {
        [EnumMember(Value = "Insert")]
        Insert,
        [EnumMember(Value = "Update")]
        Update,
        [EnumMember(Value = "Remove")]
        Remove
    }
    internal static class PropertyChangeTypeEnumExtension
    {
        internal static string ToSerializedValue(this PropertyChangeType? value)
        {
            return value == null ? null : ((PropertyChangeType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this PropertyChangeType value)
        {
            switch( value )
            {
                case PropertyChangeType.Insert:
                    return "Insert";
                case PropertyChangeType.Update:
                    return "Update";
                case PropertyChangeType.Remove:
                    return "Remove";
            }
            return null;
        }

        internal static PropertyChangeType? ParsePropertyChangeType(this string value)
        {
            switch( value )
            {
                case "Insert":
                    return PropertyChangeType.Insert;
                case "Update":
                    return PropertyChangeType.Update;
                case "Remove":
                    return PropertyChangeType.Remove;
            }
            return null;
        }
    }
}
