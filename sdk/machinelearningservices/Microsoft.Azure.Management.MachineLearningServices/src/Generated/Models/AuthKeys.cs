// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AuthKeys
    {
        /// <summary>
        /// Initializes a new instance of the AuthKeys class.
        /// </summary>
        public AuthKeys()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AuthKeys class.
        /// </summary>
        /// <param name="primaryKey">The primary key.</param>
        /// <param name="secondaryKey">The secondary key.</param>
        public AuthKeys(string primaryKey = default(string), string secondaryKey = default(string))
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the primary key.
        /// </summary>
        [JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets the secondary key.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKey")]
        public string SecondaryKey { get; set; }

    }
}
