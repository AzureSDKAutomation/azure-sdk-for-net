// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of the managed HSM Pool
    /// </summary>
    public partial class ManagedHsmProperties
    {
        /// <summary>
        /// Initializes a new instance of the ManagedHsmProperties class.
        /// </summary>
        public ManagedHsmProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedHsmProperties class.
        /// </summary>
        /// <param name="tenantId">The Azure Active Directory tenant ID that
        /// should be used for authenticating requests to the managed HSM
        /// pool.</param>
        /// <param name="initialAdminObjectIds">Array of initial administrators
        /// object ids for this managed hsm pool.</param>
        /// <param name="hsmUri">The URI of the managed hsm pool for performing
        /// operations on keys.</param>
        /// <param name="enableSoftDelete">Property to specify whether the
        /// 'soft delete' functionality is enabled for this managed HSM pool.
        /// If it's not set to any value(true or false) when creating new
        /// managed HSM pool, it will be set to true by default. Once set to
        /// true, it cannot be reverted to false.</param>
        /// <param name="softDeleteRetentionInDays">softDelete data retention
        /// days. It accepts &gt;=7 and &lt;=90.</param>
        /// <param name="enablePurgeProtection">Property specifying whether
        /// protection against purge is enabled for this managed HSM pool.
        /// Setting this property to true activates protection against purge
        /// for this managed HSM pool and its content - only the Managed HSM
        /// service may initiate a hard, irrecoverable deletion. The setting is
        /// effective only if soft delete is also enabled. Enabling this
        /// functionality is irreversible.</param>
        /// <param name="createMode">The create mode to indicate whether the
        /// resource is being created or is being recovered from a deleted
        /// resource. Possible values include: 'recover', 'default'</param>
        /// <param name="statusMessage">Resource Status Message.</param>
        /// <param name="provisioningState">Provisioning state. Possible values
        /// include: 'Succeeded', 'Provisioning', 'Failed', 'Updating',
        /// 'Deleting', 'Activated', 'SecurityDomainRestore',
        /// 'Restoring'</param>
        /// <param name="networkAcls">Rules governing the accessibility of the
        /// key vault from specific network locations.</param>
        /// <param name="privateEndpointConnections">List of private endpoint
        /// connections associated with the managed hsm pool.</param>
        /// <param name="publicNetworkAccess">Control permission for data plane
        /// traffic coming from public networks while private endpoint is
        /// enabled. Possible values include: 'Enabled', 'Disabled'</param>
        public ManagedHsmProperties(System.Guid? tenantId = default(System.Guid?), IList<string> initialAdminObjectIds = default(IList<string>), string hsmUri = default(string), bool? enableSoftDelete = default(bool?), int? softDeleteRetentionInDays = default(int?), bool? enablePurgeProtection = default(bool?), CreateMode? createMode = default(CreateMode?), string statusMessage = default(string), string provisioningState = default(string), MHSMNetworkRuleSet networkAcls = default(MHSMNetworkRuleSet), IList<MHSMPrivateEndpointConnectionItem> privateEndpointConnections = default(IList<MHSMPrivateEndpointConnectionItem>), string publicNetworkAccess = default(string))
        {
            TenantId = tenantId;
            InitialAdminObjectIds = initialAdminObjectIds;
            HsmUri = hsmUri;
            EnableSoftDelete = enableSoftDelete;
            SoftDeleteRetentionInDays = softDeleteRetentionInDays;
            EnablePurgeProtection = enablePurgeProtection;
            CreateMode = createMode;
            StatusMessage = statusMessage;
            ProvisioningState = provisioningState;
            NetworkAcls = networkAcls;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Active Directory tenant ID that should be
        /// used for authenticating requests to the managed HSM pool.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid? TenantId { get; set; }

        /// <summary>
        /// Gets or sets array of initial administrators object ids for this
        /// managed hsm pool.
        /// </summary>
        [JsonProperty(PropertyName = "initialAdminObjectIds")]
        public IList<string> InitialAdminObjectIds { get; set; }

        /// <summary>
        /// Gets the URI of the managed hsm pool for performing operations on
        /// keys.
        /// </summary>
        [JsonProperty(PropertyName = "hsmUri")]
        public string HsmUri { get; private set; }

        /// <summary>
        /// Gets or sets property to specify whether the 'soft delete'
        /// functionality is enabled for this managed HSM pool. If it's not set
        /// to any value(true or false) when creating new managed HSM pool, it
        /// will be set to true by default. Once set to true, it cannot be
        /// reverted to false.
        /// </summary>
        [JsonProperty(PropertyName = "enableSoftDelete")]
        public bool? EnableSoftDelete { get; set; }

        /// <summary>
        /// Gets or sets softDelete data retention days. It accepts &amp;gt;=7
        /// and &amp;lt;=90.
        /// </summary>
        [JsonProperty(PropertyName = "softDeleteRetentionInDays")]
        public int? SoftDeleteRetentionInDays { get; set; }

        /// <summary>
        /// Gets or sets property specifying whether protection against purge
        /// is enabled for this managed HSM pool. Setting this property to true
        /// activates protection against purge for this managed HSM pool and
        /// its content - only the Managed HSM service may initiate a hard,
        /// irrecoverable deletion. The setting is effective only if soft
        /// delete is also enabled. Enabling this functionality is
        /// irreversible.
        /// </summary>
        [JsonProperty(PropertyName = "enablePurgeProtection")]
        public bool? EnablePurgeProtection { get; set; }

        /// <summary>
        /// Gets or sets the create mode to indicate whether the resource is
        /// being created or is being recovered from a deleted resource.
        /// Possible values include: 'recover', 'default'
        /// </summary>
        [JsonProperty(PropertyName = "createMode")]
        public CreateMode? CreateMode { get; set; }

        /// <summary>
        /// Gets resource Status Message.
        /// </summary>
        [JsonProperty(PropertyName = "statusMessage")]
        public string StatusMessage { get; private set; }

        /// <summary>
        /// Gets provisioning state. Possible values include: 'Succeeded',
        /// 'Provisioning', 'Failed', 'Updating', 'Deleting', 'Activated',
        /// 'SecurityDomainRestore', 'Restoring'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets rules governing the accessibility of the key vault
        /// from specific network locations.
        /// </summary>
        [JsonProperty(PropertyName = "networkAcls")]
        public MHSMNetworkRuleSet NetworkAcls { get; set; }

        /// <summary>
        /// Gets list of private endpoint connections associated with the
        /// managed hsm pool.
        /// </summary>
        [JsonProperty(PropertyName = "privateEndpointConnections")]
        public IList<MHSMPrivateEndpointConnectionItem> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets or sets control permission for data plane traffic coming from
        /// public networks while private endpoint is enabled. Possible values
        /// include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

    }
}
