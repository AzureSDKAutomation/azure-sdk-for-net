// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.M365SecurityAndCompliance.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The common properties of a service.
    /// </summary>
    public partial class ServicesResource : IResource
    {
        /// <summary>
        /// Initializes a new instance of the ServicesResource class.
        /// </summary>
        public ServicesResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServicesResource class.
        /// </summary>
        /// <param name="kind">The kind of the service. Possible values
        /// include: 'fhir', 'fhir-Stu3', 'fhir-R4'</param>
        /// <param name="location">The resource location.</param>
        /// <param name="id">The resource identifier.</param>
        /// <param name="name">The resource name.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="systemData">Required property for system data</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="etag">An etag associated with the resource, used for
        /// optimistic concurrency when editing it.</param>
        /// <param name="identity">Setting indicating whether the service has a
        /// managed identity associated with it.</param>
        public ServicesResource(Kind kind, string location, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), ServicesResourceIdentity identity = default(ServicesResourceIdentity))
        {
            Id = id;
            Name = name;
            Type = type;
            SystemData = systemData;
            Kind = kind;
            Location = location;
            Tags = tags;
            Etag = etag;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the resource identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the resource name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets required property for system data
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

        /// <summary>
        /// Gets or sets the kind of the service. Possible values include:
        /// 'fhir', 'fhir-Stu3', 'fhir-R4'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public Kind Kind { get; set; }

        /// <summary>
        /// Gets or sets the resource location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets an etag associated with the resource, used for
        /// optimistic concurrency when editing it.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets setting indicating whether the service has a managed
        /// identity associated with it.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ServicesResourceIdentity Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Name != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Name, "^[a-z0-9][a-z0-9-]{1,21}[a-z0-9]$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Name", "^[a-z0-9][a-z0-9-]{1,21}[a-z0-9]$");
                }
            }
        }
    }
}
