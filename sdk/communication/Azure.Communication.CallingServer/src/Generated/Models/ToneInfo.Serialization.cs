// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class ToneInfo
    {
        internal static ToneInfo DeserializeToneInfo(JsonElement element)
        {
            int sequenceId = default;
            ToneValue tone = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sequenceId"))
                {
                    sequenceId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("tone"))
                {
                    tone = new ToneValue(property.Value.GetString());
                    continue;
                }
            }
            return new ToneInfo(sequenceId, tone);
        }
    }
}
