// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a supported private link resource for the Azure Cognitive
    /// Search service.
    /// </summary>
    public partial class PrivateLinkResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkResource class.
        /// </summary>
        public PrivateLinkResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkResource class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="properties">Describes the properties of a supported
        /// private link resource for the Azure Cognitive Search
        /// service.</param>
        public PrivateLinkResource(string id = default(string), string name = default(string), string type = default(string), PrivateLinkResourceProperties properties = default(PrivateLinkResourceProperties))
            : base(id, name, type)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets describes the properties of a supported private link resource
        /// for the Azure Cognitive Search service.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public PrivateLinkResourceProperties Properties { get; private set; }

    }
}
