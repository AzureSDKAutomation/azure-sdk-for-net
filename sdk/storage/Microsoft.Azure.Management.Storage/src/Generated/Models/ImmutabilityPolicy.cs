// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The ImmutabilityPolicy property of a blob container, including Id,
    /// resource name, resource type, Etag.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ImmutabilityPolicy : AzureEntityResource
    {
        /// <summary>
        /// Initializes a new instance of the ImmutabilityPolicy class.
        /// </summary>
        public ImmutabilityPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImmutabilityPolicy class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="etag">Resource Etag.</param>
        /// <param name="immutabilityPeriodSinceCreationInDays">The
        /// immutability period for the blobs in the container since the policy
        /// creation, in days.</param>
        /// <param name="state">The ImmutabilityPolicy state of a blob
        /// container, possible values include: Locked and Unlocked. Possible
        /// values include: 'Locked', 'Unlocked'</param>
        /// <param name="allowProtectedAppendWrites">This property can only be
        /// changed for unlocked time-based retention policies. When enabled,
        /// new blocks can be written to an append blob while maintaining
        /// immutability protection and compliance. Only new blocks can be
        /// added and any existing blocks cannot be modified or deleted. This
        /// property cannot be changed with ExtendImmutabilityPolicy
        /// API</param>
        public ImmutabilityPolicy(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), int? immutabilityPeriodSinceCreationInDays = default(int?), string state = default(string), bool? allowProtectedAppendWrites = default(bool?))
            : base(id, name, type, etag)
        {
            ImmutabilityPeriodSinceCreationInDays = immutabilityPeriodSinceCreationInDays;
            State = state;
            AllowProtectedAppendWrites = allowProtectedAppendWrites;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the immutability period for the blobs in the container
        /// since the policy creation, in days.
        /// </summary>
        [JsonProperty(PropertyName = "properties.immutabilityPeriodSinceCreationInDays")]
        public int? ImmutabilityPeriodSinceCreationInDays { get; set; }

        /// <summary>
        /// Gets the ImmutabilityPolicy state of a blob container, possible
        /// values include: Locked and Unlocked. Possible values include:
        /// 'Locked', 'Unlocked'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets or sets this property can only be changed for unlocked
        /// time-based retention policies. When enabled, new blocks can be
        /// written to an append blob while maintaining immutability protection
        /// and compliance. Only new blocks can be added and any existing
        /// blocks cannot be modified or deleted. This property cannot be
        /// changed with ExtendImmutabilityPolicy API
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowProtectedAppendWrites")]
        public bool? AllowProtectedAppendWrites { get; set; }

    }
}
