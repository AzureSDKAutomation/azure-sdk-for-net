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
    /// Hyperscale node edition capabilities.
    /// </summary>
    public partial class HyperscaleNodeEditionCapability
    {
        /// <summary>
        /// Initializes a new instance of the HyperscaleNodeEditionCapability
        /// class.
        /// </summary>
        public HyperscaleNodeEditionCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HyperscaleNodeEditionCapability
        /// class.
        /// </summary>
        /// <param name="name">Server edition name</param>
        /// <param name="supportedStorageEditions">The list of editions
        /// supported by this server edition.</param>
        /// <param name="supportedServerVersions">The list of server versions
        /// supported by this server edition.</param>
        /// <param name="supportedNodeTypes">The list of Node Types supported
        /// by this server edition.</param>
        /// <param name="status">The status</param>
        public HyperscaleNodeEditionCapability(string name = default(string), IList<StorageEditionCapability> supportedStorageEditions = default(IList<StorageEditionCapability>), IList<ServerVersionCapability> supportedServerVersions = default(IList<ServerVersionCapability>), IList<NodeTypeCapability> supportedNodeTypes = default(IList<NodeTypeCapability>), string status = default(string))
        {
            Name = name;
            SupportedStorageEditions = supportedStorageEditions;
            SupportedServerVersions = supportedServerVersions;
            SupportedNodeTypes = supportedNodeTypes;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets server edition name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the list of editions supported by this server edition.
        /// </summary>
        [JsonProperty(PropertyName = "supportedStorageEditions")]
        public IList<StorageEditionCapability> SupportedStorageEditions { get; private set; }

        /// <summary>
        /// Gets the list of server versions supported by this server edition.
        /// </summary>
        [JsonProperty(PropertyName = "supportedServerVersions")]
        public IList<ServerVersionCapability> SupportedServerVersions { get; private set; }

        /// <summary>
        /// Gets the list of Node Types supported by this server edition.
        /// </summary>
        [JsonProperty(PropertyName = "supportedNodeTypes")]
        public IList<NodeTypeCapability> SupportedNodeTypes { get; private set; }

        /// <summary>
        /// Gets the status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

    }
}
