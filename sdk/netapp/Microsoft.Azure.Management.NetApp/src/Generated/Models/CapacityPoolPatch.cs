// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Capacity pool patch resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CapacityPoolPatch : IResource
    {
        /// <summary>
        /// Initializes a new instance of the CapacityPoolPatch class.
        /// </summary>
        public CapacityPoolPatch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapacityPoolPatch class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="size">size</param>
        /// <param name="qosType">qosType</param>
        public CapacityPoolPatch(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), long? size = default(long?), string qosType = default(string))
        {
            Location = location;
            Id = id;
            Name = name;
            Type = type;
            Tags = tags;
            Size = size;
            QosType = qosType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets size
        /// </summary>
        /// <remarks>
        /// Provisioned size of the pool (in bytes). Allowed values are in 4TiB
        /// chunks (value must be multiply of 4398046511104).
        /// </remarks>
        [JsonProperty(PropertyName = "properties.size")]
        public long? Size { get; set; }

        /// <summary>
        /// Gets or sets qosType
        /// </summary>
        /// <remarks>
        /// The qos type of the pool. Possible values include: 'Auto', 'Manual'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.qosType")]
        public string QosType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Size > 549755813888000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Size", 549755813888000);
            }
            if (Size < 4398046511104)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Size", 4398046511104);
            }
        }
    }
}
