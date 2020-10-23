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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The type of the paths for alias.
    /// </summary>
    public partial class AliasPath
    {
        /// <summary>
        /// Initializes a new instance of the AliasPath class.
        /// </summary>
        public AliasPath()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AliasPath class.
        /// </summary>
        /// <param name="path">The path of an alias.</param>
        /// <param name="apiVersions">The API versions.</param>
        /// <param name="pattern">The pattern for an alias path.</param>
        /// <param name="metadata">The metadata of the alias path. If missing,
        /// fall back to the default metadata of the alias.</param>
        public AliasPath(string path = default(string), IList<string> apiVersions = default(IList<string>), AliasPattern pattern = default(AliasPattern), AliasPathMetadata metadata = default(AliasPathMetadata))
        {
            Path = path;
            ApiVersions = apiVersions;
            Pattern = pattern;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the path of an alias.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the API versions.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersions")]
        public IList<string> ApiVersions { get; set; }

        /// <summary>
        /// Gets or sets the pattern for an alias path.
        /// </summary>
        [JsonProperty(PropertyName = "pattern")]
        public AliasPattern Pattern { get; set; }

        /// <summary>
        /// Gets the metadata of the alias path. If missing, fall back to the
        /// default metadata of the alias.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public AliasPathMetadata Metadata { get; private set; }

    }
}
