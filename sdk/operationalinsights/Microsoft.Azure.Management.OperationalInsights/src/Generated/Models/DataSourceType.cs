// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DataSourceType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataSourceType
    {
        [EnumMember(Value = "CustomLogs")]
        CustomLogs,
        [EnumMember(Value = "AzureWatson")]
        AzureWatson,
        [EnumMember(Value = "Query")]
        Query,
        [EnumMember(Value = "Ingestion")]
        Ingestion,
        [EnumMember(Value = "Alerts")]
        Alerts
    }
    internal static class DataSourceTypeEnumExtension
    {
        internal static string ToSerializedValue(this DataSourceType? value)
        {
            return value == null ? null : ((DataSourceType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DataSourceType value)
        {
            switch( value )
            {
                case DataSourceType.CustomLogs:
                    return "CustomLogs";
                case DataSourceType.AzureWatson:
                    return "AzureWatson";
                case DataSourceType.Query:
                    return "Query";
                case DataSourceType.Ingestion:
                    return "Ingestion";
                case DataSourceType.Alerts:
                    return "Alerts";
            }
            return null;
        }

        internal static DataSourceType? ParseDataSourceType(this string value)
        {
            switch( value )
            {
                case "CustomLogs":
                    return DataSourceType.CustomLogs;
                case "AzureWatson":
                    return DataSourceType.AzureWatson;
                case "Query":
                    return DataSourceType.Query;
                case "Ingestion":
                    return DataSourceType.Ingestion;
                case "Alerts":
                    return DataSourceType.Alerts;
            }
            return null;
        }
    }
}
