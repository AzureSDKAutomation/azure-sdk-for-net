// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class ModelEnvironmentDefinitionResponseDocker : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BaseImage))
            {
                writer.WritePropertyName("baseImage");
                writer.WriteStringValue(BaseImage);
            }
            if (Optional.IsDefined(BaseDockerfile))
            {
                writer.WritePropertyName("baseDockerfile");
                writer.WriteStringValue(BaseDockerfile);
            }
            if (Optional.IsDefined(BaseImageRegistry))
            {
                writer.WritePropertyName("baseImageRegistry");
                writer.WriteObjectValue(BaseImageRegistry);
            }
            writer.WriteEndObject();
        }

        internal static ModelEnvironmentDefinitionResponseDocker DeserializeModelEnvironmentDefinitionResponseDocker(JsonElement element)
        {
            Optional<string> baseImage = default;
            Optional<string> baseDockerfile = default;
            Optional<ContainerRegistryResponse> baseImageRegistry = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseImage"))
                {
                    baseImage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("baseDockerfile"))
                {
                    baseDockerfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("baseImageRegistry"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    baseImageRegistry = ContainerRegistryResponse.DeserializeContainerRegistryResponse(property.Value);
                    continue;
                }
            }
            return new ModelEnvironmentDefinitionResponseDocker(baseImage.Value, baseDockerfile.Value, baseImageRegistry.Value);
        }
    }
}
