// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for CreateOrUpdate operation.
    /// </summary>
    public partial class ApiSchemaCreateOrUpdateHeaders
    {
        /// <summary>
        /// Initializes a new instance of the ApiSchemaCreateOrUpdateHeaders
        /// class.
        /// </summary>
        public ApiSchemaCreateOrUpdateHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiSchemaCreateOrUpdateHeaders
        /// class.
        /// </summary>
        /// <param name="eTag">Current entity state version. Should be treated
        /// as opaque and used to make conditional HTTP requests.</param>
        /// <param name="location">The URL where the status of the long running
        /// operation can be checked.</param>
        public ApiSchemaCreateOrUpdateHeaders(string eTag = default(string), string location = default(string))
        {
            ETag = eTag;
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets current entity state version. Should be treated as
        /// opaque and used to make conditional HTTP requests.
        /// </summary>
        [JsonProperty(PropertyName = "ETag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the URL where the status of the long running operation
        /// can be checked.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
