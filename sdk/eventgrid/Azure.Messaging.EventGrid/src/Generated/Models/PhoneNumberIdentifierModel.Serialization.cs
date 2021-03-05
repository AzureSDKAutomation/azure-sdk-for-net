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
    [JsonConverter(typeof(PhoneNumberIdentifierModelConverter))]
    public partial class PhoneNumberIdentifierModel
    {
        internal static PhoneNumberIdentifierModel DeserializePhoneNumberIdentifierModel(JsonElement element)
        {
            string value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new PhoneNumberIdentifierModel(value);
        }

        internal partial class PhoneNumberIdentifierModelConverter : JsonConverter<PhoneNumberIdentifierModel>
        {
            public override void Write(Utf8JsonWriter writer, PhoneNumberIdentifierModel model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override PhoneNumberIdentifierModel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializePhoneNumberIdentifierModel(document.RootElement);
            }
        }
    }
}