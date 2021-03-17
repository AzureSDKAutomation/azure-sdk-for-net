// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Network Settings
    /// </summary>
    public partial class NetworkSettings
    {
        /// <summary>
        /// Initializes a new instance of the NetworkSettings class.
        /// </summary>
        public NetworkSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkSettings class.
        /// </summary>
        /// <param name="publicNetworkAccess">Enable or Disable public network
        /// access to workspace. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        public NetworkSettings(string publicNetworkAccess = default(string))
        {
            PublicNetworkAccess = publicNetworkAccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets enable or Disable public network access to workspace.
        /// Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

    }
}
