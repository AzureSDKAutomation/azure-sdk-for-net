// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A JSON web signature
    /// </summary>
    public partial class JWK
    {
        /// <summary>
        /// Initializes a new instance of the JWK class.
        /// </summary>
        public JWK()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JWK class.
        /// </summary>
        /// <param name="alg">The algorithm used to sign or encrypt the
        /// JWT</param>
        public JWK(JWKHeader jwk = default(JWKHeader), string alg = default(string))
        {
            Jwk = jwk;
            Alg = alg;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jwk")]
        public JWKHeader Jwk { get; set; }

        /// <summary>
        /// Gets or sets the algorithm used to sign or encrypt the JWT
        /// </summary>
        [JsonProperty(PropertyName = "alg")]
        public string Alg { get; set; }

    }
}
