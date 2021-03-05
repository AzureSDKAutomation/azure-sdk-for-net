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
    [JsonConverter(typeof(AcsChatParticipantAddedToThreadEventDataConverter))]
    public partial class AcsChatParticipantAddedToThreadEventData
    {
        internal static AcsChatParticipantAddedToThreadEventData DeserializeAcsChatParticipantAddedToThreadEventData(JsonElement element)
        {
            Optional<DateTimeOffset> time = default;
            Optional<CommunicationIdentifierModel> addedByCommunicationIdentifier = default;
            Optional<AcsChatThreadParticipantProperties> participantAdded = default;
            Optional<long> version = default;
            Optional<string> threadId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("time"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    time = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("addedByCommunicationIdentifier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    addedByCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("participantAdded"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    participantAdded = AcsChatThreadParticipantProperties.DeserializeAcsChatThreadParticipantProperties(property.Value);
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
            return new AcsChatParticipantAddedToThreadEventData(threadId.Value, Optional.ToNullable(time), addedByCommunicationIdentifier.Value, participantAdded.Value, Optional.ToNullable(version));
        }

        internal partial class AcsChatParticipantAddedToThreadEventDataConverter : JsonConverter<AcsChatParticipantAddedToThreadEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsChatParticipantAddedToThreadEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AcsChatParticipantAddedToThreadEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsChatParticipantAddedToThreadEventData(document.RootElement);
            }
        }
    }
}