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
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Workspace connection.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WorkspaceConnection : IResource
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceConnection class.
        /// </summary>
        public WorkspaceConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceConnection class.
        /// </summary>
        /// <param name="id">ResourceId of the workspace connection.</param>
        /// <param name="name">Friendly name of the workspace
        /// connection.</param>
        /// <param name="type">Resource type of workspace connection.</param>
        /// <param name="category">Category of the workspace
        /// connection.</param>
        /// <param name="target">Target of the workspace connection.</param>
        /// <param name="authType">Authorization type of the workspace
        /// connection.</param>
        /// <param name="value">Value details of the workspace
        /// connection.</param>
        public WorkspaceConnection(string id = default(string), string name = default(string), string type = default(string), string category = default(string), string target = default(string), string authType = default(string), string value = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            Category = category;
            Target = target;
            AuthType = authType;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resourceId of the workspace connection.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets friendly name of the workspace connection.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type of workspace connection.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets category of the workspace connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets target of the workspace connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets authorization type of the workspace connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authType")]
        public string AuthType { get; set; }

        /// <summary>
        /// Gets or sets value details of the workspace connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.value")]
        public string Value { get; set; }

    }
}
