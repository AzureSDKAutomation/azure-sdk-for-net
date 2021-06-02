// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The configuration settings of the storage of the tokens if a file
    /// system is used.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FileSystemTokenStore : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the FileSystemTokenStore class.
        /// </summary>
        public FileSystemTokenStore()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileSystemTokenStore class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="directory">The directory in which the tokens will be
        /// stored.</param>
        public FileSystemTokenStore(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), string directory = default(string))
            : base(id, name, kind, type, systemData)
        {
            Directory = directory;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the directory in which the tokens will be stored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.directory")]
        public string Directory { get; set; }

    }
}
