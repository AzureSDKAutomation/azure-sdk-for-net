// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of private endpoint connection associated with the specified
    /// storage account
    /// </summary>
    public partial class PrivateEndpointConnectionListResultDescription
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PrivateEndpointConnectionListResultDescription class.
        /// </summary>
        public PrivateEndpointConnectionListResultDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PrivateEndpointConnectionListResultDescription class.
        /// </summary>
        /// <param name="value">Array of private endpoint connections</param>
        public PrivateEndpointConnectionListResultDescription(IList<PrivateEndpointConnectionDescription> value = default(IList<PrivateEndpointConnectionDescription>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets array of private endpoint connections
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<PrivateEndpointConnectionDescription> Value { get; set; }

    }
}
