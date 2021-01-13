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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An update of an addon resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AddonUpdate
    {
        /// <summary>
        /// Initializes a new instance of the AddonUpdate class.
        /// </summary>
        public AddonUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddonUpdate class.
        /// </summary>
        /// <param name="licenseKey">The SRM license</param>
        /// <param name="addonType">The type of private cloud addon. Possible
        /// values include: 'SRM', 'VR'</param>
        /// <param name="provisioningState">The state of the addon
        /// provisioning. Possible values include: 'Succeeded', 'Failed',
        /// 'Cancelled', 'Deleting', 'Updating'</param>
        public AddonUpdate(string licenseKey = default(string), string addonType = default(string), string provisioningState = default(string))
        {
            LicenseKey = licenseKey;
            AddonType = addonType;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SRM license
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.licenseKey")]
        public string LicenseKey { get; set; }

        /// <summary>
        /// Gets or sets the type of private cloud addon. Possible values
        /// include: 'SRM', 'VR'
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.addonType")]
        public string AddonType { get; set; }

        /// <summary>
        /// Gets the state of the addon provisioning. Possible values include:
        /// 'Succeeded', 'Failed', 'Cancelled', 'Deleting', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties.provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
