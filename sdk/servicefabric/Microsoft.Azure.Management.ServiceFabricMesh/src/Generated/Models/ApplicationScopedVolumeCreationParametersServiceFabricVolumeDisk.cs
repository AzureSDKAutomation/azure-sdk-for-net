// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricMesh.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes parameters for creating application-scoped volumes provided
    /// by Service Fabric Volume Disks
    /// </summary>
    [Newtonsoft.Json.JsonObject("ServiceFabricVolumeDisk")]
    public partial class ApplicationScopedVolumeCreationParametersServiceFabricVolumeDisk : ApplicationScopedVolumeCreationParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationScopedVolumeCreationParametersServiceFabricVolumeDisk
        /// class.
        /// </summary>
        public ApplicationScopedVolumeCreationParametersServiceFabricVolumeDisk()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationScopedVolumeCreationParametersServiceFabricVolumeDisk
        /// class.
        /// </summary>
        /// <param name="sizeDisk">Volume size. Possible values include:
        /// 'Small', 'Medium', 'Large'</param>
        /// <param name="description">User readable description of the
        /// volume.</param>
        public ApplicationScopedVolumeCreationParametersServiceFabricVolumeDisk(string sizeDisk, string description = default(string))
            : base(description)
        {
            SizeDisk = sizeDisk;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets volume size. Possible values include: 'Small',
        /// 'Medium', 'Large'
        /// </summary>
        [JsonProperty(PropertyName = "sizeDisk")]
        public string SizeDisk { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SizeDisk == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SizeDisk");
            }
        }
    }
}
