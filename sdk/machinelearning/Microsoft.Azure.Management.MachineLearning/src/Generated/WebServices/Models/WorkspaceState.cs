// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for WorkspaceState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkspaceState
    {
        [EnumMember(Value = "Deleted")]
        Deleted,
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled,
        [EnumMember(Value = "Migrated")]
        Migrated,
        [EnumMember(Value = "Updated")]
        Updated,
        [EnumMember(Value = "Registered")]
        Registered,
        [EnumMember(Value = "Unregistered")]
        Unregistered
    }
    internal static class WorkspaceStateEnumExtension
    {
        internal static string ToSerializedValue(this WorkspaceState? value)
        {
            return value == null ? null : ((WorkspaceState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WorkspaceState value)
        {
            switch( value )
            {
                case WorkspaceState.Deleted:
                    return "Deleted";
                case WorkspaceState.Enabled:
                    return "Enabled";
                case WorkspaceState.Disabled:
                    return "Disabled";
                case WorkspaceState.Migrated:
                    return "Migrated";
                case WorkspaceState.Updated:
                    return "Updated";
                case WorkspaceState.Registered:
                    return "Registered";
                case WorkspaceState.Unregistered:
                    return "Unregistered";
            }
            return null;
        }

        internal static WorkspaceState? ParseWorkspaceState(this string value)
        {
            switch( value )
            {
                case "Deleted":
                    return WorkspaceState.Deleted;
                case "Enabled":
                    return WorkspaceState.Enabled;
                case "Disabled":
                    return WorkspaceState.Disabled;
                case "Migrated":
                    return WorkspaceState.Migrated;
                case "Updated":
                    return WorkspaceState.Updated;
                case "Registered":
                    return WorkspaceState.Registered;
                case "Unregistered":
                    return WorkspaceState.Unregistered;
            }
            return null;
        }
    }
}
