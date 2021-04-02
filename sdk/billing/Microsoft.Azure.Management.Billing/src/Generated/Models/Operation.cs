// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Billing REST API operation.
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
        /// <param name="name">Operation name:
        /// {provider}/{resource}/{operation}.</param>
        /// <param name="isDataAction">Identifies if the operation is a data
        /// operation.</param>
        /// <param name="display">The object that represents the
        /// operation.</param>
        public Operation(string name = default(string), bool? isDataAction = default(bool?), OperationDisplay display = default(OperationDisplay))
        {
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
        /// Gets operation name: {provider}/{resource}/{operation}.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets identifies if the operation is a data operation.
        /// </summary>
        [JsonProperty(PropertyName = "isDataAction")]
        public bool? IsDataAction { get; private set; }

        /// <summary>
        /// Gets or sets the object that represents the operation.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationDisplay Display { get; set; }

    }
}
