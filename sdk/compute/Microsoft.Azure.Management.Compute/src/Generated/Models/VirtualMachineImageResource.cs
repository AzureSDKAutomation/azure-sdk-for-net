// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Virtual machine image resource information.
    /// </summary>
    public partial class VirtualMachineImageResource : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineImageResource
        /// class.
        /// </summary>
        public VirtualMachineImageResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineImageResource
        /// class.
        /// </summary>
        /// <param name="name">The name of the resource.</param>
        /// <param name="location">The supported Azure location of the
        /// resource.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="tags">Specifies the tags that are assigned to the
        /// virtual machine. For more information about using tags, see [Using
        /// tags to organize your Azure
        /// resources](https://docs.microsoft.com/azure/azure-resource-manager/resource-group-using-tags.md).</param>
        /// <param name="extendedLocation">The extended location of the Virtual
        /// Machine.</param>
        public VirtualMachineImageResource(string name, string location, string id = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ExtendedLocation extendedLocation = default(ExtendedLocation))
            : base(id)
        {
            Name = name;
            Location = location;
            Tags = tags;
            ExtendedLocation = extendedLocation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the supported Azure location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets specifies the tags that are assigned to the virtual
        /// machine. For more information about using tags, see [Using tags to
        /// organize your Azure
        /// resources](https://docs.microsoft.com/azure/azure-resource-manager/resource-group-using-tags.md).
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the extended location of the Virtual Machine.
        /// </summary>
        [JsonProperty(PropertyName = "extendedLocation")]
        public ExtendedLocation ExtendedLocation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (ExtendedLocation != null)
            {
                ExtendedLocation.Validate();
            }
        }
    }
}
