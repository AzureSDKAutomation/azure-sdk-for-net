// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Server version capabilities.
    /// </summary>
    public partial class ServerVersionCapability
    {
        /// <summary>
        /// Initializes a new instance of the ServerVersionCapability class.
        /// </summary>
        public ServerVersionCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerVersionCapability class.
        /// </summary>
        /// <param name="name">server version</param>
        public ServerVersionCapability(string name = default(string), IList<VcoreCapability> supportedVcores = default(IList<VcoreCapability>))
        {
            Name = name;
            SupportedVcores = supportedVcores;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets server version
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supportedVcores")]
        public IList<VcoreCapability> SupportedVcores { get; private set; }

    }
}
