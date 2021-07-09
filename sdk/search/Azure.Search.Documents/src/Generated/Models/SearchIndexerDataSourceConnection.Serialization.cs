// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerDataSourceConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("credentials");
            writer.WriteObjectValue(CredentialsInternal);
            writer.WritePropertyName("container");
            writer.WriteObjectValue(Container);
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity");
                    writer.WriteObjectValue(Identity);
                }
                else
                {
                    writer.WriteNull("identity");
                }
            }
            if (Optional.IsDefined(DataChangeDetectionPolicy))
            {
                if (DataChangeDetectionPolicy != null)
                {
                    writer.WritePropertyName("dataChangeDetectionPolicy");
                    writer.WriteObjectValue(DataChangeDetectionPolicy);
                }
                else
                {
                    writer.WriteNull("dataChangeDetectionPolicy");
                }
            }
            if (Optional.IsDefined(DataDeletionDetectionPolicy))
            {
                if (DataDeletionDetectionPolicy != null)
                {
                    writer.WritePropertyName("dataDeletionDetectionPolicy");
                    writer.WriteObjectValue(DataDeletionDetectionPolicy);
                }
                else
                {
                    writer.WriteNull("dataDeletionDetectionPolicy");
                }
            }
            if (Optional.IsDefined(_etag))
            {
                writer.WritePropertyName("@odata.etag");
                writer.WriteStringValue(_etag);
            }
            if (Optional.IsDefined(EncryptionKey))
            {
                if (EncryptionKey != null)
                {
                    writer.WritePropertyName("encryptionKey");
                    writer.WriteObjectValue(EncryptionKey);
                }
                else
                {
                    writer.WriteNull("encryptionKey");
                }
            }
            writer.WriteEndObject();
        }

        internal static SearchIndexerDataSourceConnection DeserializeSearchIndexerDataSourceConnection(JsonElement element)
        {
            string name = default;
            Optional<string> description = default;
            SearchIndexerDataSourceType type = default;
            DataSourceCredentials credentials = default;
            SearchIndexerDataContainer container = default;
            Optional<SearchIndexerDataIdentity> identity = default;
            Optional<DataChangeDetectionPolicy> dataChangeDetectionPolicy = default;
            Optional<DataDeletionDetectionPolicy> dataDeletionDetectionPolicy = default;
            Optional<string> odataEtag = default;
            Optional<SearchResourceEncryptionKey> encryptionKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new SearchIndexerDataSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credentials"))
                {
                    credentials = DataSourceCredentials.DeserializeDataSourceCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("container"))
                {
                    container = SearchIndexerDataContainer.DeserializeSearchIndexerDataContainer(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = SearchIndexerDataIdentity.DeserializeSearchIndexerDataIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("dataChangeDetectionPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataChangeDetectionPolicy = null;
                        continue;
                    }
                    dataChangeDetectionPolicy = DataChangeDetectionPolicy.DeserializeDataChangeDetectionPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDeletionDetectionPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataDeletionDetectionPolicy = null;
                        continue;
                    }
                    dataDeletionDetectionPolicy = DataDeletionDetectionPolicy.DeserializeDataDeletionDetectionPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.etag"))
                {
                    odataEtag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        encryptionKey = null;
                        continue;
                    }
                    encryptionKey = SearchResourceEncryptionKey.DeserializeSearchResourceEncryptionKey(property.Value);
                    continue;
                }
            }
            return new SearchIndexerDataSourceConnection(name, description.Value, type, credentials, container, identity.Value, dataChangeDetectionPolicy.Value, dataDeletionDetectionPolicy.Value, odataEtag.Value, encryptionKey.Value);
        }
    }
}
