// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    [Rest.Serialization.JsonTransformation]
    public partial class PurchaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the PurchaseRequest class.
        /// </summary>
        public PurchaseRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PurchaseRequest class.
        /// </summary>
        /// <param name="location">The Azure Region where the reserved resource
        /// lives.</param>
        /// <param name="reservedResourceType">Possible values include:
        /// 'VirtualMachines', 'SqlDatabases', 'SuseLinux', 'CosmosDb',
        /// 'RedHat', 'SqlDataWarehouse', 'VMwareCloudSimple', 'RedHatOsa',
        /// 'Databricks', 'AppService', 'ManagedDisk', 'BlockBlob',
        /// 'RedisCache', 'AzureDataExplorer', 'MySql', 'MariaDb',
        /// 'PostgreSql', 'DedicatedHost', 'SapHana',
        /// 'SqlAzureHybridBenefit'</param>
        /// <param name="term">Possible values include: 'P1Y', 'P3Y'</param>
        /// <param name="billingPlan">Possible values include: 'Upfront',
        /// 'Monthly'</param>
        /// <param name="displayName">Friendly name of the Reservation</param>
        /// <param name="appliedScopeType">Possible values include: 'Single',
        /// 'Shared'</param>
        /// <param name="reservedResourceProperties">Properties specific to
        /// each reserved resource type. Not required if not
        /// applicable.</param>
        public PurchaseRequest(SkuName sku = default(SkuName), string location = default(string), string reservedResourceType = default(string), string billingScopeId = default(string), string term = default(string), string billingPlan = default(string), string quantity = default(string), string displayName = default(string), string appliedScopeType = default(string), IList<string> appliedScopes = default(IList<string>), bool? renew = default(bool?), PurchaseRequestPropertiesReservedResourceProperties reservedResourceProperties = default(PurchaseRequestPropertiesReservedResourceProperties))
        {
            Sku = sku;
            Location = location;
            ReservedResourceType = reservedResourceType;
            BillingScopeId = billingScopeId;
            Term = term;
            BillingPlan = billingPlan;
            Quantity = quantity;
            DisplayName = displayName;
            AppliedScopeType = appliedScopeType;
            AppliedScopes = appliedScopes;
            Renew = renew;
            ReservedResourceProperties = reservedResourceProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public SkuName Sku { get; set; }

        /// <summary>
        /// Gets or sets the Azure Region where the reserved resource lives.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'VirtualMachines',
        /// 'SqlDatabases', 'SuseLinux', 'CosmosDb', 'RedHat',
        /// 'SqlDataWarehouse', 'VMwareCloudSimple', 'RedHatOsa', 'Databricks',
        /// 'AppService', 'ManagedDisk', 'BlockBlob', 'RedisCache',
        /// 'AzureDataExplorer', 'MySql', 'MariaDb', 'PostgreSql',
        /// 'DedicatedHost', 'SapHana', 'SqlAzureHybridBenefit'
        /// </summary>
        [JsonProperty(PropertyName = "properties.reservedResourceType")]
        public string ReservedResourceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingScopeId")]
        public string BillingScopeId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'P1Y', 'P3Y'
        /// </summary>
        [JsonProperty(PropertyName = "properties.term")]
        public string Term { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Upfront', 'Monthly'
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingPlan")]
        public string BillingPlan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// Gets or sets friendly name of the Reservation
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Single', 'Shared'
        /// </summary>
        [JsonProperty(PropertyName = "properties.appliedScopeType")]
        public string AppliedScopeType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.appliedScopes")]
        public IList<string> AppliedScopes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.renew")]
        public bool? Renew { get; set; }

        /// <summary>
        /// Gets or sets properties specific to each reserved resource type.
        /// Not required if not applicable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reservedResourceProperties")]
        public PurchaseRequestPropertiesReservedResourceProperties ReservedResourceProperties { get; set; }

    }
}
