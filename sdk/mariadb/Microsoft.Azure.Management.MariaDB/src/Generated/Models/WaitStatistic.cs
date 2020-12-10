// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MariaDB.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a Wait Statistic.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WaitStatistic : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the WaitStatistic class.
        /// </summary>
        public WaitStatistic()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WaitStatistic class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="startTime">Observation start time.</param>
        /// <param name="endTime">Observation end time.</param>
        /// <param name="eventName">Wait event name.</param>
        /// <param name="eventTypeName">Wait event type name.</param>
        /// <param name="queryId">Database query identifier.</param>
        /// <param name="databaseName">Database Name.</param>
        /// <param name="userId">Database user identifier.</param>
        /// <param name="count">Wait event count observed in this time
        /// interval.</param>
        /// <param name="totalTimeInMs">Total time of wait in milliseconds in
        /// this time interval.</param>
        public WaitStatistic(string id = default(string), string name = default(string), string type = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string eventName = default(string), string eventTypeName = default(string), long? queryId = default(long?), string databaseName = default(string), long? userId = default(long?), long? count = default(long?), double? totalTimeInMs = default(double?))
            : base(id, name, type)
        {
            StartTime = startTime;
            EndTime = endTime;
            EventName = eventName;
            EventTypeName = eventTypeName;
            QueryId = queryId;
            DatabaseName = databaseName;
            UserId = userId;
            Count = count;
            TotalTimeInMs = totalTimeInMs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets observation start time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets observation end time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets wait event name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventName")]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or sets wait event type name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventTypeName")]
        public string EventTypeName { get; set; }

        /// <summary>
        /// Gets or sets database query identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.queryId")]
        public long? QueryId { get; set; }

        /// <summary>
        /// Gets or sets database Name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets database user identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// Gets or sets wait event count observed in this time interval.
        /// </summary>
        [JsonProperty(PropertyName = "properties.count")]
        public long? Count { get; set; }

        /// <summary>
        /// Gets or sets total time of wait in milliseconds in this time
        /// interval.
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalTimeInMs")]
        public double? TotalTimeInMs { get; set; }

    }
}
