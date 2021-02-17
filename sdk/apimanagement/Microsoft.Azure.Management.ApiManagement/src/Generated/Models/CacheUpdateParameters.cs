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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Cache update details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CacheUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the CacheUpdateParameters class.
        /// </summary>
        public CacheUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CacheUpdateParameters class.
        /// </summary>
        /// <param name="description">Cache description</param>
        /// <param name="connectionString">Runtime connection string to
        /// cache</param>
        /// <param name="useFromLocation">Location identifier to use cache from
        /// (should be either 'default' or valid Azure region
        /// identifier)</param>
        /// <param name="resourceId">Original uri of entity in external system
        /// cache points to</param>
        public CacheUpdateParameters(string description = default(string), string connectionString = default(string), string useFromLocation = default(string), string resourceId = default(string))
        {
            Description = description;
            ConnectionString = connectionString;
            UseFromLocation = useFromLocation;
            ResourceId = resourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets cache description
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets runtime connection string to cache
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets location identifier to use cache from (should be
        /// either 'default' or valid Azure region identifier)
        /// </summary>
        [JsonProperty(PropertyName = "properties.useFromLocation")]
        public string UseFromLocation { get; set; }

        /// <summary>
        /// Gets or sets original uri of entity in external system cache points
        /// to
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Description != null)
            {
                if (Description.Length > 2000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 2000);
                }
            }
            if (ConnectionString != null)
            {
                if (ConnectionString.Length > 300)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ConnectionString", 300);
                }
            }
            if (UseFromLocation != null)
            {
                if (UseFromLocation.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "UseFromLocation", 256);
                }
            }
            if (ResourceId != null)
            {
                if (ResourceId.Length > 2000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ResourceId", 2000);
                }
            }
        }
    }
}
