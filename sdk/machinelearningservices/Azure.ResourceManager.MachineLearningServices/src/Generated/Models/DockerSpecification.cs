// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Class to represent configuration settings for Docker. </summary>
    public partial class DockerSpecification
    {
        /// <summary> Initializes a new instance of DockerSpecification. </summary>
        public DockerSpecification()
        {
        }

        /// <summary> Initializes a new instance of DockerSpecification. </summary>
        /// <param name="type"> Docker specification must be either Build or Image. </param>
        internal DockerSpecification(DockerSpecificationType type)
        {
            Type = type;
        }

        /// <summary> Docker specification must be either Build or Image. </summary>
        internal DockerSpecificationType Type { get; set; }
    }
}
