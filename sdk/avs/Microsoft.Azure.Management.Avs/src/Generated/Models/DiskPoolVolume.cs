// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An iSCSI volume from Microsoft.StoragePool provider
    /// </summary>
    public partial class DiskPoolVolume
    {
        /// <summary>
        /// Initializes a new instance of the DiskPoolVolume class.
        /// </summary>
        public DiskPoolVolume()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskPoolVolume class.
        /// </summary>
        /// <param name="endpoints">iSCSI provider target IP address
        /// list</param>
        /// <param name="lunName">Name of the LUN to be used</param>
        public DiskPoolVolume(IList<string> endpoints = default(IList<string>), string lunName = default(string))
        {
            Endpoints = endpoints;
            LunName = lunName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets iSCSI provider target IP address list
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public IList<string> Endpoints { get; set; }

        /// <summary>
        /// Gets or sets name of the LUN to be used
        /// </summary>
        [JsonProperty(PropertyName = "lunName")]
        public string LunName { get; set; }

    }
}
