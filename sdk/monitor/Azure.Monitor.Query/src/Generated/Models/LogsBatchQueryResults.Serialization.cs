// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    public partial class LogsBatchQueryResults
    {
        internal static LogsBatchQueryResults DeserializeLogsBatchQueryResults(JsonElement element)
        {
            Optional<IReadOnlyList<LogQueryResponse>> responses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("responses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LogQueryResponse> array = new List<LogQueryResponse>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogQueryResponse.DeserializeLogQueryResponse(item));
                    }
                    responses = array;
                    continue;
                }
            }
            return new LogsBatchQueryResults(Optional.ToList(responses));
        }
    }
}
