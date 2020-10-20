// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class NotebookWorkspaceListResult
    {
        internal static NotebookWorkspaceListResult DeserializeNotebookWorkspaceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<NotebookWorkspace>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<NotebookWorkspace> array = new List<NotebookWorkspace>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NotebookWorkspace.DeserializeNotebookWorkspace(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new NotebookWorkspaceListResult(Optional.ToList(value));
        }
    }
}
