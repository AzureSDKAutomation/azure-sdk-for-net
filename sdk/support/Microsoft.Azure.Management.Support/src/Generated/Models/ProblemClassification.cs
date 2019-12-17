// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Support.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Object that represents a ProblemClassification resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ProblemClassification
    {
        /// <summary>
        /// Initializes a new instance of the ProblemClassification class.
        /// </summary>
        public ProblemClassification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProblemClassification class.
        /// </summary>
        /// <param name="id">Id of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of the resource
        /// 'Microsoft.Support/problemClassification'.</param>
        /// <param name="displayName">Localized name of problem
        /// classification.</param>
        public ProblemClassification(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets id of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets type of the resource
        /// 'Microsoft.Support/problemClassification'.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets localized name of problem classification.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

    }
}
