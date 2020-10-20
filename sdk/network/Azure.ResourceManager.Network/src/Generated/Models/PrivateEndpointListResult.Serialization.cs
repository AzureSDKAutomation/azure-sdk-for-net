// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PrivateEndpointListResult
    {
        internal static PrivateEndpointListResult DeserializePrivateEndpointListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PrivateEndpoint>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PrivateEndpoint> array = new List<PrivateEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateEndpoint.DeserializePrivateEndpoint(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PrivateEndpointListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
