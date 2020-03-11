// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response from generation of an SSH key pair.
    /// </summary>
    public partial class SshPublicKeyGenerateKeyPairResult
    {
        /// <summary>
        /// Initializes a new instance of the SshPublicKeyGenerateKeyPairResult
        /// class.
        /// </summary>
        public SshPublicKeyGenerateKeyPairResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SshPublicKeyGenerateKeyPairResult
        /// class.
        /// </summary>
        /// <param name="privateKey">Private key portion of the key pair used
        /// to authenticate to a virtual machine through ssh. The private key
        /// is returned in RFC3447 format and should be treated as a
        /// secret.</param>
        /// <param name="publicKey">Public key portion of the key pair used to
        /// authenticate to a virtual machine through ssh. The public key is in
        /// ssh-rsa format.</param>
        /// <param name="id">The ARM resource id in the form of
        /// /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/sshPublicKeys/{SshPublicKeyName}</param>
        public SshPublicKeyGenerateKeyPairResult(string privateKey, string publicKey, string id)
        {
            PrivateKey = privateKey;
            PublicKey = publicKey;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets private key portion of the key pair used to
        /// authenticate to a virtual machine through ssh. The private key is
        /// returned in RFC3447 format and should be treated as a secret.
        /// </summary>
        [JsonProperty(PropertyName = "privateKey")]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Gets or sets public key portion of the key pair used to
        /// authenticate to a virtual machine through ssh. The public key is in
        /// ssh-rsa format.
        /// </summary>
        [JsonProperty(PropertyName = "publicKey")]
        public string PublicKey { get; set; }

        /// <summary>
        /// Gets or sets the ARM resource id in the form of
        /// /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/sshPublicKeys/{SshPublicKeyName}
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PrivateKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PrivateKey");
            }
            if (PublicKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PublicKey");
            }
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
