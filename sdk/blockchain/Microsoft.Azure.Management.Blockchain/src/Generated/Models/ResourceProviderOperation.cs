// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blockchain.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Operation payload which is exposed in the response of the resource
    /// provider.
    /// </summary>
    public partial class ResourceProviderOperation
    {
        /// <summary>
        /// Initializes a new instance of the ResourceProviderOperation class.
        /// </summary>
        public ResourceProviderOperation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceProviderOperation class.
        /// </summary>
        /// <param name="origin">Gets or sets the origin.</param>
        /// <param name="name">Gets or sets the operation name.</param>
        /// <param name="isDataAction">Gets or sets a value indicating whether
        /// the operation is a data action or not.</param>
        /// <param name="display">Gets or sets operation display</param>
        public ResourceProviderOperation(string origin = default(string), string name = default(string), bool? isDataAction = default(bool?), ResourceProviderOperationDisplay display = default(ResourceProviderOperationDisplay))
        {
            Origin = origin;
            Name = name;
            IsDataAction = isDataAction;
            Display = display;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the origin.
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets the operation name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the operation is a data
        /// action or not.
        /// </summary>
        [JsonProperty(PropertyName = "isDataAction")]
        public bool? IsDataAction { get; set; }

        /// <summary>
        /// Gets or sets operation display
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public ResourceProviderOperationDisplay Display { get; set; }

    }
}
