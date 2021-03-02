// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for CreateOrUpdate operation.
    /// </summary>
    public partial class NetworkGroupsCreateOrUpdateHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// NetworkGroupsCreateOrUpdateHeaders class.
        /// </summary>
        public NetworkGroupsCreateOrUpdateHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// NetworkGroupsCreateOrUpdateHeaders class.
        /// </summary>
        /// <param name="eTag">The current entity tag.</param>
        public NetworkGroupsCreateOrUpdateHeaders(string eTag = default(string))
        {
            ETag = eTag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the current entity tag.
        /// </summary>
        [JsonProperty(PropertyName = "ETag")]
        public string ETag { get; set; }

    }
}
