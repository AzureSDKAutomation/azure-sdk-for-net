// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of manifest attributes
    /// </summary>
    public partial class ManifestAttributesManifest
    {
        /// <summary>
        /// Initializes a new instance of the ManifestAttributesManifest class.
        /// </summary>
        public ManifestAttributesManifest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManifestAttributesManifest class.
        /// </summary>
        /// <param name="references">List of manifest attributes
        /// details</param>
        /// <param name="quarantineTag">Quarantine tag name</param>
        public ManifestAttributesManifest(IList<ManifestAttributesManifestReferences> references = default(IList<ManifestAttributesManifestReferences>), string quarantineTag = default(string))
        {
            References = references;
            QuarantineTag = quarantineTag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of manifest attributes details
        /// </summary>
        [JsonProperty(PropertyName = "references")]
        public IList<ManifestAttributesManifestReferences> References { get; set; }

        /// <summary>
        /// Gets or sets quarantine tag name
        /// </summary>
        [JsonProperty(PropertyName = "quarantineTag")]
        public string QuarantineTag { get; set; }

    }
}
