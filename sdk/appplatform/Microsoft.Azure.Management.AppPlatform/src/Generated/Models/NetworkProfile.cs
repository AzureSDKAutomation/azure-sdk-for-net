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

    /// <summary>
    /// Service network profile payload
    /// </summary>
    public partial class NetworkProfile
    {
        /// <summary>
        /// Initializes a new instance of the NetworkProfile class.
        /// </summary>
        public NetworkProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkProfile class.
        /// </summary>
        /// <param name="serviceRuntimeSubnetId">Fully qualified resource Id of
        /// the subnet to host Azure Spring Cloud Service Runtime</param>
        /// <param name="appSubnetId">Fully qualified resource Id of the subnet
        /// to host Azure Spring Cloud Apps</param>
        /// <param name="serviceCidr">Azure Spring Cloud service reserved
        /// CIDR</param>
        public NetworkProfile(string serviceRuntimeSubnetId = default(string), string appSubnetId = default(string), string serviceCidr = default(string))
        {
            ServiceRuntimeSubnetId = serviceRuntimeSubnetId;
            AppSubnetId = appSubnetId;
            ServiceCidr = serviceCidr;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets fully qualified resource Id of the subnet to host
        /// Azure Spring Cloud Service Runtime
        /// </summary>
        [JsonProperty(PropertyName = "serviceRuntimeSubnetId")]
        public string ServiceRuntimeSubnetId { get; set; }

        /// <summary>
        /// Gets or sets fully qualified resource Id of the subnet to host
        /// Azure Spring Cloud Apps
        /// </summary>
        [JsonProperty(PropertyName = "appSubnetId")]
        public string AppSubnetId { get; set; }

        /// <summary>
        /// Gets or sets azure Spring Cloud service reserved CIDR
        /// </summary>
        [JsonProperty(PropertyName = "serviceCidr")]
        public string ServiceCidr { get; set; }

    }
}
