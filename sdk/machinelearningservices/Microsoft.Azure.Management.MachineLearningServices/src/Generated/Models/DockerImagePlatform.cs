// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DockerImagePlatform
    {
        /// <summary>
        /// Initializes a new instance of the DockerImagePlatform class.
        /// </summary>
        public DockerImagePlatform()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DockerImagePlatform class.
        /// </summary>
        /// <param name="operatingSystemType">The OS type the Environment.
        /// Possible values include: 'Linux', 'Windows'</param>
        public DockerImagePlatform(string operatingSystemType = default(string))
        {
            OperatingSystemType = operatingSystemType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the OS type the Environment. Possible values include:
        /// 'Linux', 'Windows'
        /// </summary>
        [JsonProperty(PropertyName = "operatingSystemType")]
        public string OperatingSystemType { get; set; }

    }
}
