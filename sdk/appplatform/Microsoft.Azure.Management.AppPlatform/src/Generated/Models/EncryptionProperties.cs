// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class EncryptionProperties
    {
        /// <summary>
        /// Initializes a new instance of the EncryptionProperties class.
        /// </summary>
        public EncryptionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncryptionProperties class.
        /// </summary>
        /// <param name="keySource">Possible values include: 'None',
        /// 'Microsoft.AppPlatform', 'Microsoft.KeyVault'</param>
        public EncryptionProperties(string keySource = default(string), EncryptionKeyProperties keyVaultProperties = default(EncryptionKeyProperties))
        {
            KeySource = keySource;
            KeyVaultProperties = keyVaultProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'None',
        /// 'Microsoft.AppPlatform', 'Microsoft.KeyVault'
        /// </summary>
        [JsonProperty(PropertyName = "keySource")]
        public string KeySource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "keyVaultProperties")]
        public EncryptionKeyProperties KeyVaultProperties { get; set; }

    }
}
