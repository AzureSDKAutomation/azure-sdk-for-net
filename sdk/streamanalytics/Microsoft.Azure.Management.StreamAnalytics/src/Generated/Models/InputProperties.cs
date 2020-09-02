// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties that are associated with an input.
    /// </summary>
    public partial class InputProperties
    {
        /// <summary>
        /// Initializes a new instance of the InputProperties class.
        /// </summary>
        public InputProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InputProperties class.
        /// </summary>
        /// <param name="serialization">Describes how data from an input is
        /// serialized or how data is serialized when written to an output.
        /// Required on PUT (CreateOrReplace) requests.</param>
        /// <param name="diagnostics">Describes conditions applicable to the
        /// Input, Output, or the job overall, that warrant customer
        /// attention.</param>
        /// <param name="etag">The current entity tag for the input. This is an
        /// opaque string. You can use it to detect whether the resource has
        /// changed between requests. You can also use it in the If-Match or
        /// If-None-Match headers for write operations for optimistic
        /// concurrency.</param>
        /// <param name="partitionKey">partitionKey Describes a key in the
        /// input data which is used for partitioning the input data</param>
        public InputProperties(Serialization serialization = default(Serialization), Diagnostics diagnostics = default(Diagnostics), string etag = default(string), Compression compression = default(Compression), string partitionKey = default(string))
        {
            Serialization = serialization;
            Diagnostics = diagnostics;
            Etag = etag;
            Compression = compression;
            PartitionKey = partitionKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes how data from an input is serialized or how
        /// data is serialized when written to an output. Required on PUT
        /// (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "serialization")]
        public Serialization Serialization { get; set; }

        /// <summary>
        /// Gets describes conditions applicable to the Input, Output, or the
        /// job overall, that warrant customer attention.
        /// </summary>
        [JsonProperty(PropertyName = "diagnostics")]
        public Diagnostics Diagnostics { get; private set; }

        /// <summary>
        /// Gets the current entity tag for the input. This is an opaque
        /// string. You can use it to detect whether the resource has changed
        /// between requests. You can also use it in the If-Match or
        /// If-None-Match headers for write operations for optimistic
        /// concurrency.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "compression")]
        public Compression Compression { get; set; }

        /// <summary>
        /// Gets or sets partitionKey Describes a key in the input data which
        /// is used for partitioning the input data
        /// </summary>
        [JsonProperty(PropertyName = "partitionKey")]
        public string PartitionKey { get; set; }

    }
}
