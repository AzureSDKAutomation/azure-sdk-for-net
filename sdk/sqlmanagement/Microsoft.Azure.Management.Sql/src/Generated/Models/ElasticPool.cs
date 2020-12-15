// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An elastic pool.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ElasticPool : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the ElasticPool class.
        /// </summary>
        public ElasticPool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ElasticPool class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="sku">The elastic pool SKU.
        ///
        /// The list of SKUs may vary by region and support offer. To determine
        /// the SKUs (including the SKU name, tier/edition, family, and
        /// capacity) that are available to your subscription in an Azure
        /// region, use the `Capabilities_ListByLocation` REST API or the
        /// following command:
        ///
        /// ```azurecli
        /// az sql elastic-pool list-editions -l &lt;location&gt; -o table
        /// ````
        /// </param>
        /// <param name="kind">Kind of elastic pool. This is metadata used for
        /// the Azure portal experience.</param>
        /// <param name="state">The state of the elastic pool. Possible values
        /// include: 'Creating', 'Ready', 'Disabled'</param>
        /// <param name="creationDate">The creation date of the elastic pool
        /// (ISO8601 format).</param>
        /// <param name="maxSizeBytes">The storage limit for the database
        /// elastic pool in bytes.</param>
        /// <param name="perDatabaseSettings">The per database settings for the
        /// elastic pool.</param>
        /// <param name="zoneRedundant">Whether or not this elastic pool is
        /// zone redundant, which means the replicas of this elastic pool will
        /// be spread across multiple availability zones.</param>
        /// <param name="licenseType">The license type to apply for this
        /// elastic pool. Possible values include: 'LicenseIncluded',
        /// 'BasePrice'</param>
        /// <param name="maintenanceConfigurationId">Maintenance configuration
        /// id assigned to the elastic pool. This configuration defines the
        /// period when the maintenance updates will will occur.</param>
        public ElasticPool(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), string kind = default(string), string state = default(string), System.DateTime? creationDate = default(System.DateTime?), long? maxSizeBytes = default(long?), ElasticPoolPerDatabaseSettings perDatabaseSettings = default(ElasticPoolPerDatabaseSettings), bool? zoneRedundant = default(bool?), string licenseType = default(string), string maintenanceConfigurationId = default(string))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            Kind = kind;
            State = state;
            CreationDate = creationDate;
            MaxSizeBytes = maxSizeBytes;
            PerDatabaseSettings = perDatabaseSettings;
            ZoneRedundant = zoneRedundant;
            LicenseType = licenseType;
            MaintenanceConfigurationId = maintenanceConfigurationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the elastic pool SKU.
        ///
        /// The list of SKUs may vary by region and support offer. To determine
        /// the SKUs (including the SKU name, tier/edition, family, and
        /// capacity) that are available to your subscription in an Azure
        /// region, use the `Capabilities_ListByLocation` REST API or the
        /// following command:
        ///
        /// ```azurecli
        /// az sql elastic-pool list-editions -l &amp;lt;location&amp;gt; -o
        /// table
        /// ````
        ///
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets kind of elastic pool. This is metadata used for the Azure
        /// portal experience.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

        /// <summary>
        /// Gets the state of the elastic pool. Possible values include:
        /// 'Creating', 'Ready', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets the creation date of the elastic pool (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; private set; }

        /// <summary>
        /// Gets or sets the storage limit for the database elastic pool in
        /// bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxSizeBytes")]
        public long? MaxSizeBytes { get; set; }

        /// <summary>
        /// Gets or sets the per database settings for the elastic pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.perDatabaseSettings")]
        public ElasticPoolPerDatabaseSettings PerDatabaseSettings { get; set; }

        /// <summary>
        /// Gets or sets whether or not this elastic pool is zone redundant,
        /// which means the replicas of this elastic pool will be spread across
        /// multiple availability zones.
        /// </summary>
        [JsonProperty(PropertyName = "properties.zoneRedundant")]
        public bool? ZoneRedundant { get; set; }

        /// <summary>
        /// Gets or sets the license type to apply for this elastic pool.
        /// Possible values include: 'LicenseIncluded', 'BasePrice'
        /// </summary>
        [JsonProperty(PropertyName = "properties.licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets or sets maintenance configuration id assigned to the elastic
        /// pool. This configuration defines the period when the maintenance
        /// updates will will occur.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maintenanceConfigurationId")]
        public string MaintenanceConfigurationId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
