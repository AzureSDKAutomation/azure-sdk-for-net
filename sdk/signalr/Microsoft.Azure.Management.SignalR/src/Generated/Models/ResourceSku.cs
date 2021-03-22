// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SignalR.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The billing information of the resource.
    /// </summary>
    public partial class ResourceSku
    {
        /// <summary>
        /// Initializes a new instance of the ResourceSku class.
        /// </summary>
        public ResourceSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceSku class.
        /// </summary>
        /// <param name="name">The name of the SKU. Required.
        ///
        /// Allowed values: Standard_S1, Free_F1</param>
        /// <param name="tier">Optional tier of this particular SKU. 'Standard'
        /// or 'Free'.
        ///
        /// `Basic` is deprecated, use `Standard` instead. Possible values
        /// include: 'Free', 'Basic', 'Standard', 'Premium'</param>
        /// <param name="size">Not used. Retained for future use.</param>
        /// <param name="family">Not used. Retained for future use.</param>
        /// <param name="capacity">Optional, integer. The unit count of SignalR
        /// resource. 1 by default.
        ///
        /// If present, following values are allowed:
        /// Free: 1
        /// Standard: 1,2,5,10,20,50,100</param>
        public ResourceSku(string name, string tier = default(string), string size = default(string), string family = default(string), int? capacity = default(int?))
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Capacity = capacity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the SKU. Required.
        ///
        /// Allowed values: Standard_S1, Free_F1
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets optional tier of this particular SKU. 'Standard' or
        /// 'Free'.
        ///
        /// `Basic` is deprecated, use `Standard` instead. Possible values
        /// include: 'Free', 'Basic', 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets not used. Retained for future use.
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; private set; }

        /// <summary>
        /// Gets not used. Retained for future use.
        /// </summary>
        [JsonProperty(PropertyName = "family")]
        public string Family { get; private set; }

        /// <summary>
        /// Gets or sets optional, integer. The unit count of SignalR resource.
        /// 1 by default.
        ///
        /// If present, following values are allowed:
        /// Free: 1
        /// Standard: 1,2,5,10,20,50,100
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

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
        }
    }
}
