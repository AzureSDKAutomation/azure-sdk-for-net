// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The application client details to track the entity creating/updating
    /// the managed app resource.
    /// </summary>
    public partial class ApplicationClientDetails
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationClientDetails class.
        /// </summary>
        public ApplicationClientDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationClientDetails class.
        /// </summary>
        /// <param name="oid">The client Oid.</param>
        /// <param name="puid">The client Puid</param>
        /// <param name="applicationId">The client application Id.</param>
        public ApplicationClientDetails(string oid = default(string), string puid = default(string), string applicationId = default(string))
        {
            Oid = oid;
            Puid = puid;
            ApplicationId = applicationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the client Oid.
        /// </summary>
        [JsonProperty(PropertyName = "oid")]
        public string Oid { get; set; }

        /// <summary>
        /// Gets or sets the client Puid
        /// </summary>
        [JsonProperty(PropertyName = "puid")]
        public string Puid { get; set; }

        /// <summary>
        /// Gets or sets the client application Id.
        /// </summary>
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }

    }
}
