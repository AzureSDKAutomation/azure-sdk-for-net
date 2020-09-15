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
    /// Data asset that can be referenced from a proposal.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DataAsset : ProxyDto
    {
        /// <summary>
        /// Initializes a new instance of the DataAsset class.
        /// </summary>
        public DataAsset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataAsset class.
        /// </summary>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="dataAssetId">Unique id for identifying a data asset
        /// resource</param>
        /// <param name="dataProcessingStrategy">Data processing strategy to
        /// use for the the child DataSets. Possible values include:
        /// 'CopyBased', 'InPlace'</param>
        /// <param name="description">General Description of the DataSet
        /// content</param>
        /// <param name="provisioningState">Provisioning state of the
        /// DataAsset. Possible values include: 'Succeeded', 'Creating',
        /// 'Updating', 'Deleting', 'Moving', 'Failed'</param>
        /// <param name="systemData">SystemData Info of dataAsset</param>
        public DataAsset(string id = default(string), string name = default(string), string type = default(string), string dataAssetId = default(string), string dataProcessingStrategy = default(string), string description = default(string), string provisioningState = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            DataAssetId = dataAssetId;
            DataProcessingStrategy = dataProcessingStrategy;
            Description = description;
            ProvisioningState = provisioningState;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets unique id for identifying a data asset resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataAssetId")]
        public string DataAssetId { get; private set; }

        /// <summary>
        /// Gets or sets data processing strategy to use for the the child
        /// DataSets. Possible values include: 'CopyBased', 'InPlace'
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataProcessingStrategy")]
        public string DataProcessingStrategy { get; set; }

        /// <summary>
        /// Gets or sets general Description of the DataSet content
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets provisioning state of the DataAsset. Possible values include:
        /// 'Succeeded', 'Creating', 'Updating', 'Deleting', 'Moving', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets systemData Info of dataAsset
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

    }
}
