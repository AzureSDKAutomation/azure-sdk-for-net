// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WindowsIoT.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The operation supported by Azure Data Catalog Service.
    /// </summary>
    public partial class OperationEntity
    {
        /// <summary>
        /// Initializes a new instance of the OperationEntity class.
        /// </summary>
        public OperationEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationEntity class.
        /// </summary>
        /// <param name="name">Operation name:
        /// {provider}/{resource}/{operation}.</param>
        /// <param name="display">The operation supported by Azure Data Catalog
        /// Service.</param>
        /// <param name="isDataAction">Indicates whether the operation is a
        /// data action</param>
        /// <param name="origin">Indicates the executor of the
        /// operation.</param>
        public OperationEntity(string name = default(string), OperationDisplayInfo display = default(OperationDisplayInfo), bool? isDataAction = default(bool?), string origin = default(string))
        {
            Name = name;
            Display = display;
            IsDataAction = isDataAction;
            Origin = origin;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets operation name: {provider}/{resource}/{operation}.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the operation supported by Azure Data Catalog Service.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationDisplayInfo Display { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the operation is a data action
        /// </summary>
        [JsonProperty(PropertyName = "isDataAction")]
        public bool? IsDataAction { get; set; }

        /// <summary>
        /// Gets or sets indicates the executor of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

    }
}
