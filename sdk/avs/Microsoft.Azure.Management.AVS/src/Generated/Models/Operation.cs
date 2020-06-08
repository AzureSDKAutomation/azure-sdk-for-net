// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AVS.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A REST API operation
    /// </summary>
    public partial class Operation
    {
        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        /// <param name="name">Name of the operation being performed on this
        /// object</param>
        /// <param name="display">Contains the localized display information
        /// for this operation</param>
        public Operation(string name = default(string), OperationDisplay display = default(OperationDisplay))
        {
            Name = name;
            Display = display;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the operation being performed on this object
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets contains the localized display information for this operation
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationDisplay Display { get; private set; }

    }
}
