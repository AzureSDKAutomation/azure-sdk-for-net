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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A set of data from external storage
    /// </summary>
    public partial class ResourceReference
    {
        /// <summary>
        /// Initializes a new instance of the ResourceReference class.
        /// </summary>
        public ResourceReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceReference class.
        /// </summary>
        /// <param name="participantDetails">Participant Details of the
        /// resource</param>
        /// <param name="resourceId">Id of the azure resource</param>
        /// <param name="resourceName">Name of the azure resource</param>
        /// <param name="resourceType">Type of the azure resource</param>
        /// <param name="systemData">SystemData Info of resource</param>
        public ResourceReference(ResourceReferenceParticipantDetails participantDetails = default(ResourceReferenceParticipantDetails), string resourceId = default(string), string resourceName = default(string), string resourceType = default(string), ResourceReferenceSystemData systemData = default(ResourceReferenceSystemData))
        {
            ParticipantDetails = participantDetails;
            ResourceId = resourceId;
            ResourceName = resourceName;
            ResourceType = resourceType;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets participant Details of the resource
        /// </summary>
        [JsonProperty(PropertyName = "participantDetails")]
        public ResourceReferenceParticipantDetails ParticipantDetails { get; private set; }

        /// <summary>
        /// Gets id of the azure resource
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; private set; }

        /// <summary>
        /// Gets name of the azure resource
        /// </summary>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; private set; }

        /// <summary>
        /// Gets type of the azure resource
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; private set; }

        /// <summary>
        /// Gets systemData Info of resource
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public ResourceReferenceSystemData SystemData { get; private set; }

    }
}
