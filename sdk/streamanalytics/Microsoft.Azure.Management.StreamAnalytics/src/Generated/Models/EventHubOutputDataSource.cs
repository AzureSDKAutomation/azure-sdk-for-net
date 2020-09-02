// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes an Event Hub output data source.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.ServiceBus/EventHub")]
    [Rest.Serialization.JsonTransformation]
    public partial class EventHubOutputDataSource : OutputDataSource
    {
        /// <summary>
        /// Initializes a new instance of the EventHubOutputDataSource class.
        /// </summary>
        public EventHubOutputDataSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventHubOutputDataSource class.
        /// </summary>
        /// <param name="serviceBusNamespace">The namespace that is associated
        /// with the desired Event Hub, Service Bus Queue, Service Bus Topic,
        /// etc. Required on PUT (CreateOrReplace) requests.</param>
        /// <param name="sharedAccessPolicyName">The shared access policy name
        /// for the Event Hub, Service Bus Queue, Service Bus Topic, etc.
        /// Required on PUT (CreateOrReplace) requests.</param>
        /// <param name="sharedAccessPolicyKey">The shared access policy key
        /// for the specified shared access policy. Required on PUT
        /// (CreateOrReplace) requests.</param>
        /// <param name="eventHubName">The name of the Event Hub. Required on
        /// PUT (CreateOrReplace) requests.</param>
        /// <param name="partitionKey">The key/column that is used to determine
        /// to which partition to send event data.</param>
        public EventHubOutputDataSource(string serviceBusNamespace = default(string), string sharedAccessPolicyName = default(string), string sharedAccessPolicyKey = default(string), string eventHubName = default(string), string partitionKey = default(string), IList<string> propertyColumns = default(IList<string>))
        {
            ServiceBusNamespace = serviceBusNamespace;
            SharedAccessPolicyName = sharedAccessPolicyName;
            SharedAccessPolicyKey = sharedAccessPolicyKey;
            EventHubName = eventHubName;
            PartitionKey = partitionKey;
            PropertyColumns = propertyColumns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the namespace that is associated with the desired
        /// Event Hub, Service Bus Queue, Service Bus Topic, etc. Required on
        /// PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceBusNamespace")]
        public string ServiceBusNamespace { get; set; }

        /// <summary>
        /// Gets or sets the shared access policy name for the Event Hub,
        /// Service Bus Queue, Service Bus Topic, etc. Required on PUT
        /// (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedAccessPolicyName")]
        public string SharedAccessPolicyName { get; set; }

        /// <summary>
        /// Gets or sets the shared access policy key for the specified shared
        /// access policy. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedAccessPolicyKey")]
        public string SharedAccessPolicyKey { get; set; }

        /// <summary>
        /// Gets or sets the name of the Event Hub. Required on PUT
        /// (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventHubName")]
        public string EventHubName { get; set; }

        /// <summary>
        /// Gets or sets the key/column that is used to determine to which
        /// partition to send event data.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partitionKey")]
        public string PartitionKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.propertyColumns")]
        public IList<string> PropertyColumns { get; set; }

    }
}
