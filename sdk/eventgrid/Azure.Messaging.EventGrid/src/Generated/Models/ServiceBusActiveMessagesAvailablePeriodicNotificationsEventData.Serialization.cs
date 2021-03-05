// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ServiceBusActiveMessagesAvailablePeriodicNotificationsEventDataConverter))]
    public partial class ServiceBusActiveMessagesAvailablePeriodicNotificationsEventData
    {
        internal static ServiceBusActiveMessagesAvailablePeriodicNotificationsEventData DeserializeServiceBusActiveMessagesAvailablePeriodicNotificationsEventData(JsonElement element)
        {
            Optional<string> namespaceName = default;
            Optional<string> requestUri = default;
            Optional<string> entityType = default;
            Optional<string> queueName = default;
            Optional<string> topicName = default;
            Optional<string> subscriptionName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("namespaceName"))
                {
                    namespaceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestUri"))
                {
                    requestUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entityType"))
                {
                    entityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueName"))
                {
                    queueName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topicName"))
                {
                    topicName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionName"))
                {
                    subscriptionName = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceBusActiveMessagesAvailablePeriodicNotificationsEventData(namespaceName.Value, requestUri.Value, entityType.Value, queueName.Value, topicName.Value, subscriptionName.Value);
        }

        internal partial class ServiceBusActiveMessagesAvailablePeriodicNotificationsEventDataConverter : JsonConverter<ServiceBusActiveMessagesAvailablePeriodicNotificationsEventData>
        {
            public override void Write(Utf8JsonWriter writer, ServiceBusActiveMessagesAvailablePeriodicNotificationsEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ServiceBusActiveMessagesAvailablePeriodicNotificationsEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeServiceBusActiveMessagesAvailablePeriodicNotificationsEventData(document.RootElement);
            }
        }
    }
}