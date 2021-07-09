// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering.Models
{
    public partial class KnowledgebaseAnswerRequestContext : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("previousQnaId");
            writer.WriteNumberValue(PreviousQnaId);
            if (Optional.IsDefined(PreviousUserQuery))
            {
                writer.WritePropertyName("previousUserQuery");
                writer.WriteStringValue(PreviousUserQuery);
            }
            writer.WriteEndObject();
        }
    }
}
