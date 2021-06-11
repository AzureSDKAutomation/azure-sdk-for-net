// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CostManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The status of the long running operation.
    /// </summary>
    public partial class Status
    {
        /// <summary>
        /// Initializes a new instance of the Status class.
        /// </summary>
        public Status()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Status class.
        /// </summary>
        /// <param name="statusProperty">The status of the long running
        /// operation. Possible values include: 'Running', 'Completed',
        /// 'Failed'</param>
        public Status(string statusProperty = default(string))
        {
            StatusProperty = statusProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the status of the long running operation. Possible
        /// values include: 'Running', 'Completed', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string StatusProperty { get; set; }

    }
}
