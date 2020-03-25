// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The password that will be used for authenticating the token of a
    /// container registry.
    /// </summary>
    public partial class TokenPassword
    {
        /// <summary>
        /// Initializes a new instance of the TokenPassword class.
        /// </summary>
        public TokenPassword()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TokenPassword class.
        /// </summary>
        /// <param name="creationTime">The creation datetime of the
        /// password.</param>
        /// <param name="expiry">The expiry datetime of the password.</param>
        /// <param name="name">The password name "password1" or "password2".
        /// Possible values include: 'password1', 'password2'</param>
        /// <param name="value">The password value.</param>
        public TokenPassword(System.DateTime? creationTime = default(System.DateTime?), System.DateTime? expiry = default(System.DateTime?), string name = default(string), string value = default(string))
        {
            CreationTime = creationTime;
            Expiry = expiry;
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the creation datetime of the password.
        /// </summary>
        [JsonProperty(PropertyName = "creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the expiry datetime of the password.
        /// </summary>
        [JsonProperty(PropertyName = "expiry")]
        public System.DateTime? Expiry { get; set; }

        /// <summary>
        /// Gets or sets the password name "password1" or "password2". Possible
        /// values include: 'password1', 'password2'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the password value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; private set; }

    }
}
