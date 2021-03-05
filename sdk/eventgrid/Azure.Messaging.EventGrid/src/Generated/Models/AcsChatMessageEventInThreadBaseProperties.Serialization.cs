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
    [JsonConverter(typeof(AcsChatMessageEventInThreadBasePropertiesConverter))]
    public partial class AcsChatMessageEventInThreadBaseProperties
    {
        internal static AcsChatMessageEventInThreadBaseProperties DeserializeAcsChatMessageEventInThreadBaseProperties(JsonElement element)
        {
            Optional<string> messageId = default;
            Optional<CommunicationIdentifierModel> senderCommunicationIdentifier = default;
            Optional<string> senderDisplayName = default;
            Optional<DateTimeOffset> composeTime = default;
            Optional<string> type = default;
            Optional<long> version = default;
            Optional<string> threadId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageId"))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderCommunicationIdentifier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    senderCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("senderDisplayName"))
                {
                    senderDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("composeTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    composeTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("threadId"))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsChatMessageEventInThreadBaseProperties(threadId.Value, messageId.Value, senderCommunicationIdentifier.Value, senderDisplayName.Value, Optional.ToNullable(composeTime), type.Value, Optional.ToNullable(version));
        }

        internal partial class AcsChatMessageEventInThreadBasePropertiesConverter : JsonConverter<AcsChatMessageEventInThreadBaseProperties>
        {
            public override void Write(Utf8JsonWriter writer, AcsChatMessageEventInThreadBaseProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AcsChatMessageEventInThreadBaseProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsChatMessageEventInThreadBaseProperties(document.RootElement);
            }
        }
    }
}