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
    /// Tag attribute details
    /// </summary>
    public partial class TagAttributesBase
    {
        /// <summary>
        /// Initializes a new instance of the TagAttributesBase class.
        /// </summary>
        public TagAttributesBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TagAttributesBase class.
        /// </summary>
        /// <param name="name">Tag name</param>
        /// <param name="digest">Tag digest</param>
        /// <param name="createdTime">Tag created time</param>
        /// <param name="lastUpdateTime">Tag last update time</param>
        /// <param name="signed">Is signed</param>
        /// <param name="changeableAttributes">Tag Changeable
        /// attributes</param>
        public TagAttributesBase(string name = default(string), string digest = default(string), string createdTime = default(string), string lastUpdateTime = default(string), bool? signed = default(bool?), TagChangeableAttributes changeableAttributes = default(TagChangeableAttributes))
        {
            Name = name;
            Digest = digest;
            CreatedTime = createdTime;
            LastUpdateTime = lastUpdateTime;
            Signed = signed;
            ChangeableAttributes = changeableAttributes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets tag name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets tag digest
        /// </summary>
        [JsonProperty(PropertyName = "digest")]
        public string Digest { get; set; }

        /// <summary>
        /// Gets or sets tag created time
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets tag last update time
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateTime")]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// Gets or sets is signed
        /// </summary>
        [JsonProperty(PropertyName = "signed")]
        public bool? Signed { get; set; }

        /// <summary>
        /// Gets or sets tag Changeable attributes
        /// </summary>
        [JsonProperty(PropertyName = "changeableAttributes")]
        public TagChangeableAttributes ChangeableAttributes { get; set; }

    }
}
