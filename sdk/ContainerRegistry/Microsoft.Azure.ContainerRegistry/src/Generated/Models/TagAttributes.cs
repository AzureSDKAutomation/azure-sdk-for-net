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
    using System.Linq;

    /// <summary>
    /// Tag attributes
    /// </summary>
    public partial class TagAttributes
    {
        /// <summary>
        /// Initializes a new instance of the TagAttributes class.
        /// </summary>
        public TagAttributes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TagAttributes class.
        /// </summary>
        /// <param name="registry">Registry name</param>
        /// <param name="imageName">Image name</param>
        /// <param name="attributes">List of tag attribute details</param>
        public TagAttributes(string registry = default(string), string imageName = default(string), TagAttributesBase attributes = default(TagAttributesBase))
        {
            Registry = registry;
            ImageName = imageName;
            Attributes = attributes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets registry name
        /// </summary>
        [JsonProperty(PropertyName = "registry")]
        public string Registry { get; set; }

        /// <summary>
        /// Gets or sets image name
        /// </summary>
        [JsonProperty(PropertyName = "imageName")]
        public string ImageName { get; set; }

        /// <summary>
        /// Gets or sets list of tag attribute details
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public TagAttributesBase Attributes { get; set; }

    }
}
