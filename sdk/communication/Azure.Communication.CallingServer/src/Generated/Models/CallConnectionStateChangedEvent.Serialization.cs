// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class CallConnectionStateChangedEvent
    {
        internal static CallConnectionStateChangedEvent DeserializeCallConnectionStateChangedEvent(JsonElement element)
        {
            Optional<string> serverCallId = default;
            Optional<string> callConnectionId = default;
            CallConnectionState callConnectionState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serverCallId"))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callConnectionId"))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callConnectionState"))
                {
                    callConnectionState = new CallConnectionState(property.Value.GetString());
                    continue;
                }
            }
            return new CallConnectionStateChangedEvent(serverCallId.Value, callConnectionId.Value, callConnectionState);
        }
    }
}
