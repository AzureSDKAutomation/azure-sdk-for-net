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
    /// ResourceReference used to only allow access if the resource is used
    /// within the specified Azure dataAsset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DataAsset")]
    [Rest.Serialization.JsonTransformation]
    public partial class DataAssetResourceReference : ResourceReference
    {
        /// <summary>
        /// Initializes a new instance of the DataAssetResourceReference class.
        /// </summary>
        public DataAssetResourceReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataAssetResourceReference class.
        /// </summary>
        /// <param name="resourceId">Id of the azure resource</param>
        /// <param name="resourceName">Name of the azure resource</param>
        /// <param name="resourceType">Type of the azure resource</param>
        /// <param name="systemData">SystemData Info of resource</param>
        /// <param name="dataAssetId">The unique identifier of the referenced
        /// data asset</param>
        /// <param name="description">General Description of the data asset
        /// reference</param>
        public DataAssetResourceReference(string resourceId = default(string), string resourceName = default(string), string resourceType = default(string), ResourceReferenceSystemData systemData = default(ResourceReferenceSystemData), string dataAssetId = default(string), string description = default(string))
            : base(resourceId, resourceName, resourceType, systemData)
        {
            DataAssetId = dataAssetId;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the unique identifier of the referenced data asset
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataAssetId")]
        public string DataAssetId { get; private set; }

        /// <summary>
        /// Gets general Description of the data asset reference
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

    }
}
