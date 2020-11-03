// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// KeyVault contract details.
    /// </summary>
    public partial class KeyVaultContractProperties : KeyVaultContractCreateProperties
    {
        /// <summary>
        /// Initializes a new instance of the KeyVaultContractProperties class.
        /// </summary>
        public KeyVaultContractProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyVaultContractProperties class.
        /// </summary>
        /// <param name="secretIdentifier">Key vault secret identifier for
        /// fetching secret.</param>
        /// <param name="identityClientId">SystemAssignedIdentity or
        /// UserAssignedIdentity Client Id which will be used to access key
        /// vault secret.</param>
        /// <param name="lastStatus">Last time sync and refresh status of
        /// secret from key vault.</param>
        public KeyVaultContractProperties(string secretIdentifier = default(string), string identityClientId = default(string), KeyVaultLastAccessStatusContractProperties lastStatus = default(KeyVaultLastAccessStatusContractProperties))
            : base(secretIdentifier, identityClientId)
        {
            LastStatus = lastStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets last time sync and refresh status of secret from key
        /// vault.
        /// </summary>
        [JsonProperty(PropertyName = "lastStatus")]
        public KeyVaultLastAccessStatusContractProperties LastStatus { get; set; }

    }
}
