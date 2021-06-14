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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties of the key.
    /// </summary>
    public partial class KeyProperties
    {
        /// <summary>
        /// Initializes a new instance of the KeyProperties class.
        /// </summary>
        public KeyProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyProperties class.
        /// </summary>
        /// <param name="attributes">The attributes of the key.</param>
        /// <param name="kty">The type of the key. For valid values, see
        /// JsonWebKeyType. Possible values include: 'EC', 'EC-HSM', 'RSA',
        /// 'RSA-HSM'</param>
        /// <param name="keySize">The key size in bits. For example: 2048,
        /// 3072, or 4096 for RSA.</param>
        /// <param name="curveName">The elliptic curve name. For valid values,
        /// see JsonWebKeyCurveName. Possible values include: 'P-256', 'P-384',
        /// 'P-521', 'P-256K'</param>
        /// <param name="keyUri">The URI to retrieve the current version of the
        /// key.</param>
        /// <param name="keyUriWithVersion">The URI to retrieve the specific
        /// version of the key.</param>
        /// <param name="rotationPolicy">Key rotation policy in response. It
        /// will be used for both output and input. Omitted if empty</param>
        public KeyProperties(KeyAttributes attributes = default(KeyAttributes), string kty = default(string), IList<string> keyOps = default(IList<string>), int? keySize = default(int?), string curveName = default(string), string keyUri = default(string), string keyUriWithVersion = default(string), RotationPolicy rotationPolicy = default(RotationPolicy))
        {
            Attributes = attributes;
            Kty = kty;
            KeyOps = keyOps;
            KeySize = keySize;
            CurveName = curveName;
            KeyUri = keyUri;
            KeyUriWithVersion = keyUriWithVersion;
            RotationPolicy = rotationPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the attributes of the key.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public KeyAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets the type of the key. For valid values, see
        /// JsonWebKeyType. Possible values include: 'EC', 'EC-HSM', 'RSA',
        /// 'RSA-HSM'
        /// </summary>
        [JsonProperty(PropertyName = "kty")]
        public string Kty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "keyOps")]
        public IList<string> KeyOps { get; set; }

        /// <summary>
        /// Gets or sets the key size in bits. For example: 2048, 3072, or 4096
        /// for RSA.
        /// </summary>
        [JsonProperty(PropertyName = "keySize")]
        public int? KeySize { get; set; }

        /// <summary>
        /// Gets or sets the elliptic curve name. For valid values, see
        /// JsonWebKeyCurveName. Possible values include: 'P-256', 'P-384',
        /// 'P-521', 'P-256K'
        /// </summary>
        [JsonProperty(PropertyName = "curveName")]
        public string CurveName { get; set; }

        /// <summary>
        /// Gets the URI to retrieve the current version of the key.
        /// </summary>
        [JsonProperty(PropertyName = "keyUri")]
        public string KeyUri { get; private set; }

        /// <summary>
        /// Gets the URI to retrieve the specific version of the key.
        /// </summary>
        [JsonProperty(PropertyName = "keyUriWithVersion")]
        public string KeyUriWithVersion { get; private set; }

        /// <summary>
        /// Gets or sets key rotation policy in response. It will be used for
        /// both output and input. Omitted if empty
        /// </summary>
        [JsonProperty(PropertyName = "rotationPolicy")]
        public RotationPolicy RotationPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Kty != null)
            {
                if (Kty.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Kty", 1);
                }
            }
        }
    }
}
