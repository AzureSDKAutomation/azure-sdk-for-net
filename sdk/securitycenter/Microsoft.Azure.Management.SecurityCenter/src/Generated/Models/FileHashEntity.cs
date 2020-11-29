// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a file hash value that is reported as part of the security
    /// detection alert, usually in relation to some file entity instance.
    /// </summary>
    [Newtonsoft.Json.JsonObject("filehash")]
    public partial class FileHashEntity : AlertEntity
    {
        /// <summary>
        /// Initializes a new instance of the FileHashEntity class.
        /// </summary>
        public FileHashEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileHashEntity class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="fileHashAlgorithm">The hash algorithm type.</param>
        /// <param name="value">The hash value.</param>
        public FileHashEntity(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string fileHashAlgorithm = default(string), string value = default(string))
            : base(additionalProperties)
        {
            FileHashAlgorithm = fileHashAlgorithm;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the hash algorithm type.
        /// </summary>
        [JsonProperty(PropertyName = "fileHashAlgorithm")]
        public string FileHashAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets the hash value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
