// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines a single storage account path.
    /// </summary>
    public partial class StorageAccountPath
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountPath class.
        /// </summary>
        public StorageAccountPath()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountPath class.
        /// </summary>
        /// <param name="containerName">Gets or sets the container name to
        /// share.</param>
        /// <param name="consumerPath">Gets or sets the path on the consumer
        /// side where the dataset is to be mapped.</param>
        /// <param name="providerPath">Gets or sets the path to file/folder
        /// within the container.</param>
        public StorageAccountPath(string containerName, string consumerPath = default(string), string providerPath = default(string))
        {
            ConsumerPath = consumerPath;
            ContainerName = containerName;
            ProviderPath = providerPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the path on the consumer side where the dataset is to
        /// be mapped.
        /// </summary>
        [JsonProperty(PropertyName = "consumerPath")]
        public string ConsumerPath { get; set; }

        /// <summary>
        /// Gets or sets the container name to share.
        /// </summary>
        [JsonProperty(PropertyName = "containerName")]
        public string ContainerName { get; set; }

        /// <summary>
        /// Gets or sets the path to file/folder within the container.
        /// </summary>
        [JsonProperty(PropertyName = "providerPath")]
        public string ProviderPath { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ContainerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContainerName");
            }
        }
    }
}
