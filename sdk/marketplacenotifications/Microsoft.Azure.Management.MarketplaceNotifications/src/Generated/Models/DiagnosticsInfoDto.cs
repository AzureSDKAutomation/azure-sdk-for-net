// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MarketplaceNotifications.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Diagnostics Info
    /// </summary>
    public partial class DiagnosticsInfoDto
    {
        /// <summary>
        /// Initializes a new instance of the DiagnosticsInfoDto class.
        /// </summary>
        public DiagnosticsInfoDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiagnosticsInfoDto class.
        /// </summary>
        /// <param name="msCv">MS CV</param>
        /// <param name="buildNumber">build number</param>
        public DiagnosticsInfoDto(string msCv = default(string), string buildNumber = default(string))
        {
            MsCv = msCv;
            BuildNumber = buildNumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets MS CV
        /// </summary>
        [JsonProperty(PropertyName = "ms-cv")]
        public string MsCv { get; set; }

        /// <summary>
        /// Gets or sets build number
        /// </summary>
        [JsonProperty(PropertyName = "buildNumber")]
        public string BuildNumber { get; set; }

    }
}
