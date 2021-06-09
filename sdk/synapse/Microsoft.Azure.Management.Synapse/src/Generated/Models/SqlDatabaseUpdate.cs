// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A sql database resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SqlDatabaseUpdate
    {
        /// <summary>
        /// Initializes a new instance of the SqlDatabaseUpdate class.
        /// </summary>
        public SqlDatabaseUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlDatabaseUpdate class.
        /// </summary>
        /// <param name="collation">The collation of the database.</param>
        /// <param name="storageRedundancy">Storage redundancy of the database.
        /// Possible values include: 'Geo', 'GeoZone', 'Local', 'Zone'</param>
        /// <param name="maxSizeBytes">The max size of the database expressed
        /// in bytes.</param>
        /// <param name="databaseGuid">The Guid of the database.</param>
        /// <param name="status">Status of the database.</param>
        /// <param name="tags">Resource tags.</param>
        public SqlDatabaseUpdate(string collation = default(string), string storageRedundancy = default(string), long? maxSizeBytes = default(long?), System.Guid? databaseGuid = default(System.Guid?), string status = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Collation = collation;
            StorageRedundancy = storageRedundancy;
            MaxSizeBytes = maxSizeBytes;
            DatabaseGuid = databaseGuid;
            Status = status;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the collation of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.collation")]
        public string Collation { get; set; }

        /// <summary>
        /// Gets or sets storage redundancy of the database. Possible values
        /// include: 'Geo', 'GeoZone', 'Local', 'Zone'
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageRedundancy")]
        public string StorageRedundancy { get; set; }

        /// <summary>
        /// Gets or sets the max size of the database expressed in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxSizeBytes")]
        public long? MaxSizeBytes { get; set; }

        /// <summary>
        /// Gets the Guid of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseGuid")]
        public System.Guid? DatabaseGuid { get; private set; }

        /// <summary>
        /// Gets status of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
