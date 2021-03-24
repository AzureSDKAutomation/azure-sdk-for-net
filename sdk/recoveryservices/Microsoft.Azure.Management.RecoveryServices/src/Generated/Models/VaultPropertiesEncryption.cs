// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Customer Managed Key details of the resource.
    /// </summary>
    public partial class VaultPropertiesEncryption
    {
        /// <summary>
        /// Initializes a new instance of the VaultPropertiesEncryption class.
        /// </summary>
        public VaultPropertiesEncryption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VaultPropertiesEncryption class.
        /// </summary>
        /// <param name="infrastructureEncryption">Enabling/Disabling the
        /// Double Encryption state. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        public VaultPropertiesEncryption(CmkKeyVaultProperties keyVaultProperties = default(CmkKeyVaultProperties), CmkKekIdentity kekIdentity = default(CmkKekIdentity), string infrastructureEncryption = default(string))
        {
            KeyVaultProperties = keyVaultProperties;
            KekIdentity = kekIdentity;
            InfrastructureEncryption = infrastructureEncryption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "keyVaultProperties")]
        public CmkKeyVaultProperties KeyVaultProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kekIdentity")]
        public CmkKekIdentity KekIdentity { get; set; }

        /// <summary>
        /// Gets or sets enabling/Disabling the Double Encryption state.
        /// Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "infrastructureEncryption")]
        public string InfrastructureEncryption { get; set; }

    }
}
