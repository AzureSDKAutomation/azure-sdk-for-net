// <auto-generated>
//
// </auto-generated>

namespace Microsoft.Azure.Management.Scheduler.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobActionType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobActionType
    {
        [EnumMember(Value = "Http")]
        Http,
        [EnumMember(Value = "Https")]
        Https,
        [EnumMember(Value = "StorageQueue")]
        StorageQueue,
        [EnumMember(Value = "ServiceBusQueue")]
        ServiceBusQueue,
        [EnumMember(Value = "ServiceBusTopic")]
        ServiceBusTopic
    }
    internal static class JobActionTypeEnumExtension
    {
        internal static string ToSerializedValue(this JobActionType? value)
        {
            return value == null ? null : ((JobActionType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this JobActionType value)
        {
            switch( value )
            {
                case JobActionType.Http:
                    return "Http";
                case JobActionType.Https:
                    return "Https";
                case JobActionType.StorageQueue:
                    return "StorageQueue";
                case JobActionType.ServiceBusQueue:
                    return "ServiceBusQueue";
                case JobActionType.ServiceBusTopic:
                    return "ServiceBusTopic";
            }
            return null;
        }

        internal static JobActionType? ParseJobActionType(this string value)
        {
            switch( value )
            {
                case "Http":
                    return JobActionType.Http;
                case "Https":
                    return JobActionType.Https;
                case "StorageQueue":
                    return JobActionType.StorageQueue;
                case "ServiceBusQueue":
                    return JobActionType.ServiceBusQueue;
                case "ServiceBusTopic":
                    return JobActionType.ServiceBusTopic;
            }
            return null;
        }
    }
}
