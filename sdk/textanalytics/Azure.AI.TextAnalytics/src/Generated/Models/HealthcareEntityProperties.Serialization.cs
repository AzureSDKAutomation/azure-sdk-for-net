// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class HealthcareEntityProperties
    {
        internal static HealthcareEntityProperties DeserializeHealthcareEntityProperties(JsonElement element)
        {
            string text = default;
            HealthcareEntityCategory category = default;
            Optional<string> subcategory = default;
            int offset = default;
            int length = default;
            double confidenceScore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"))
                {
                    category = new HealthcareEntityCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subcategory"))
                {
                    subcategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offset"))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("confidenceScore"))
                {
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
            }
            return new HealthcareEntityProperties(text, category, subcategory.Value, offset, length, confidenceScore);
        }
    }
}
