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
    /// Source information for a deployment
    /// </summary>
    public partial class UserSourceInfo
    {
        /// <summary>
        /// Initializes a new instance of the UserSourceInfo class.
        /// </summary>
        public UserSourceInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserSourceInfo class.
        /// </summary>
        /// <param name="type">Type of the source uploaded. Possible values
        /// include: 'Jar', 'NetCoreZip', 'Source', 'Container'</param>
        /// <param name="relativePath">Relative path of the storage which
        /// stores the source</param>
        /// <param name="version">Version of the source</param>
        /// <param name="artifactSelector">Selector for the artifact to be used
        /// for the deployment for multi-module projects. This should be
        /// the relative path to the target module/project.</param>
        /// <param name="customContainer">Custom container payload</param>
        public UserSourceInfo(string type = default(string), string relativePath = default(string), string version = default(string), string artifactSelector = default(string), CustomContainer customContainer = default(CustomContainer))
        {
            Type = type;
            RelativePath = relativePath;
            Version = version;
            ArtifactSelector = artifactSelector;
            CustomContainer = customContainer;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of the source uploaded. Possible values include:
        /// 'Jar', 'NetCoreZip', 'Source', 'Container'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets relative path of the storage which stores the source
        /// </summary>
        [JsonProperty(PropertyName = "relativePath")]
        public string RelativePath { get; set; }

        /// <summary>
        /// Gets or sets version of the source
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets selector for the artifact to be used for the
        /// deployment for multi-module projects. This should be
        /// the relative path to the target module/project.
        /// </summary>
        [JsonProperty(PropertyName = "artifactSelector")]
        public string ArtifactSelector { get; set; }

        /// <summary>
        /// Gets or sets custom container payload
        /// </summary>
        [JsonProperty(PropertyName = "customContainer")]
        public CustomContainer CustomContainer { get; set; }

    }
}
