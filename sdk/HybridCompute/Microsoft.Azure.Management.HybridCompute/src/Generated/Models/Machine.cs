// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridCompute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a hybrid machine.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Machine : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Machine class.
        /// </summary>
        public Machine()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Machine class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="osProfile">Specifies the operating system settings for
        /// the hybrid machine.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="status">The status of the hybrid machine agent.
        /// Possible values include: 'Connected', 'Disconnected',
        /// 'Error'</param>
        /// <param name="lastStatusChange">The time of the last status
        /// change.</param>
        /// <param name="errorDetails">Details about the error state.</param>
        /// <param name="agentVersion">The hybrid machine agent full
        /// version.</param>
        /// <param name="vmId">Specifies the hybrid machine unique ID.</param>
        /// <param name="displayName">Specifies the hybrid machine display
        /// name.</param>
        /// <param name="machineFqdn">Specifies the hybrid machine
        /// FQDN.</param>
        /// <param name="clientPublicKey">Public Key that the client provides
        /// to be used during initial resource onboarding</param>
        /// <param name="osName">The Operating System running on the hybrid
        /// machine.</param>
        /// <param name="osVersion">The version of Operating System running on
        /// the hybrid machine.</param>
        /// <param name="vmUuid">Specifies the Arc Machine's unique SMBIOS
        /// ID</param>
        /// <param name="extensions">Machine Extensions information</param>
        /// <param name="osSku">Specifies the Operating System product
        /// SKU.</param>
        /// <param name="domainName">Specifies the Windows domain name.</param>
        /// <param name="adFqdn">Specifies the AD fully qualified display
        /// name.</param>
        /// <param name="dnsFqdn">Specifies the DNS fully qualified display
        /// name.</param>
        /// <param name="privateLinkScopedResources">List of private link
        /// scoped resources associated with this machine.</param>
        public Machine(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), LocationData locationData = default(LocationData), MachinePropertiesOsProfile osProfile = default(MachinePropertiesOsProfile), string provisioningState = default(string), string status = default(string), System.DateTime? lastStatusChange = default(System.DateTime?), IList<ErrorDetail> errorDetails = default(IList<ErrorDetail>), string agentVersion = default(string), string vmId = default(string), string displayName = default(string), string machineFqdn = default(string), string clientPublicKey = default(string), string osName = default(string), string osVersion = default(string), string vmUuid = default(string), IList<MachineExtensionInstanceView> extensions = default(IList<MachineExtensionInstanceView>), string osSku = default(string), string domainName = default(string), string adFqdn = default(string), string dnsFqdn = default(string), IList<string> privateLinkScopedResources = default(IList<string>), MachineIdentity identity = default(MachineIdentity))
            : base(location, id, name, type, tags)
        {
            LocationData = locationData;
            OsProfile = osProfile;
            ProvisioningState = provisioningState;
            Status = status;
            LastStatusChange = lastStatusChange;
            ErrorDetails = errorDetails;
            AgentVersion = agentVersion;
            VmId = vmId;
            DisplayName = displayName;
            MachineFqdn = machineFqdn;
            ClientPublicKey = clientPublicKey;
            OsName = osName;
            OsVersion = osVersion;
            VmUuid = vmUuid;
            Extensions = extensions;
            OsSku = osSku;
            DomainName = domainName;
            AdFqdn = adFqdn;
            DnsFqdn = dnsFqdn;
            PrivateLinkScopedResources = privateLinkScopedResources;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.locationData")]
        public LocationData LocationData { get; set; }

        /// <summary>
        /// Gets or sets specifies the operating system settings for the hybrid
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.osProfile")]
        public MachinePropertiesOsProfile OsProfile { get; set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the status of the hybrid machine agent. Possible values
        /// include: 'Connected', 'Disconnected', 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the time of the last status change.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastStatusChange")]
        public System.DateTime? LastStatusChange { get; private set; }

        /// <summary>
        /// Gets details about the error state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorDetails")]
        public IList<ErrorDetail> ErrorDetails { get; private set; }

        /// <summary>
        /// Gets the hybrid machine agent full version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.agentVersion")]
        public string AgentVersion { get; private set; }

        /// <summary>
        /// Gets or sets specifies the hybrid machine unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmId")]
        public string VmId { get; set; }

        /// <summary>
        /// Gets specifies the hybrid machine display name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets specifies the hybrid machine FQDN.
        /// </summary>
        [JsonProperty(PropertyName = "properties.machineFqdn")]
        public string MachineFqdn { get; private set; }

        /// <summary>
        /// Gets or sets public Key that the client provides to be used during
        /// initial resource onboarding
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientPublicKey")]
        public string ClientPublicKey { get; set; }

        /// <summary>
        /// Gets the Operating System running on the hybrid machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.osName")]
        public string OsName { get; private set; }

        /// <summary>
        /// Gets the version of Operating System running on the hybrid machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.osVersion")]
        public string OsVersion { get; private set; }

        /// <summary>
        /// Gets specifies the Arc Machine's unique SMBIOS ID
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmUuid")]
        public string VmUuid { get; private set; }

        /// <summary>
        /// Gets or sets machine Extensions information
        /// </summary>
        [JsonProperty(PropertyName = "properties.extensions")]
        public IList<MachineExtensionInstanceView> Extensions { get; set; }

        /// <summary>
        /// Gets specifies the Operating System product SKU.
        /// </summary>
        [JsonProperty(PropertyName = "properties.osSku")]
        public string OsSku { get; private set; }

        /// <summary>
        /// Gets specifies the Windows domain name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.domainName")]
        public string DomainName { get; private set; }

        /// <summary>
        /// Gets specifies the AD fully qualified display name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.adFqdn")]
        public string AdFqdn { get; private set; }

        /// <summary>
        /// Gets specifies the DNS fully qualified display name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsFqdn")]
        public string DnsFqdn { get; private set; }

        /// <summary>
        /// Gets list of private link scoped resources associated with this
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkScopedResources")]
        public IList<string> PrivateLinkScopedResources { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public MachineIdentity Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (LocationData != null)
            {
                LocationData.Validate();
            }
            if (ErrorDetails != null)
            {
                foreach (var element in ErrorDetails)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
