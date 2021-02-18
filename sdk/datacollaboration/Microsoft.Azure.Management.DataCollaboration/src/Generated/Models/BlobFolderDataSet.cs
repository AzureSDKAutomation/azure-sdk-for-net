// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataCollaboration.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An Azure storage blob folder data set.
    /// </summary>
    [Newtonsoft.Json.JsonObject("BlobFolder")]
    [Rest.Serialization.JsonTransformation]
    public partial class BlobFolderDataSet : DataSet
    {
        /// <summary>
        /// Initializes a new instance of the BlobFolderDataSet class.
        /// </summary>
        public BlobFolderDataSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobFolderDataSet class.
        /// </summary>
        /// <param name="containerName">Container that has the file
        /// path.</param>
        /// <param name="prefix">Prefix for blob folder</param>
        /// <param name="storageAccountId">Resource id of the storage
        /// account.</param>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="systemData">System Data of the Azure resource.</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="dataSetId">Unique id for identifying a data set
        /// resource</param>
        public BlobFolderDataSet(string containerName, string prefix, string storageAccountId, string id = default(string), string name = default(string), ProxyDtoSystemData systemData = default(ProxyDtoSystemData), string type = default(string), string dataSetId = default(string))
            : base(id, name, systemData, type)
        {
            ContainerName = containerName;
            DataSetId = dataSetId;
            Prefix = prefix;
            StorageAccountId = storageAccountId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets container that has the file path.
        /// </summary>
        [JsonProperty(PropertyName = "properties.containerName")]
        public string ContainerName { get; set; }

        /// <summary>
        /// Gets unique id for identifying a data set resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataSetId")]
        public string DataSetId { get; private set; }

        /// <summary>
        /// Gets or sets prefix for blob folder
        /// </summary>
        [JsonProperty(PropertyName = "properties.prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or sets resource id of the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountId")]
        public string StorageAccountId { get; set; }

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
            if (Prefix == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Prefix");
            }
            if (StorageAccountId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccountId");
            }
        }
    }
}
