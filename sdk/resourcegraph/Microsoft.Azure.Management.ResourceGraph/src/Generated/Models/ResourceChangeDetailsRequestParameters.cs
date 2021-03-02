// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceGraph.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters for a specific change details request.
    /// </summary>
    public partial class ResourceChangeDetailsRequestParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceChangeDetailsRequestParameters class.
        /// </summary>
        public ResourceChangeDetailsRequestParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ResourceChangeDetailsRequestParameters class.
        /// </summary>
        /// <param name="resourceIds">Specifies the list of resources for a
        /// change details request.</param>
        /// <param name="changeIds">Specifies the list of change IDs for a
        /// change details request.</param>
        public ResourceChangeDetailsRequestParameters(IList<string> resourceIds, IList<string> changeIds)
        {
            ResourceIds = resourceIds;
            ChangeIds = changeIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the list of resources for a change details
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "resourceIds")]
        public IList<string> ResourceIds { get; set; }

        /// <summary>
        /// Gets or sets specifies the list of change IDs for a change details
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "changeIds")]
        public IList<string> ChangeIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ResourceIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceIds");
            }
            if (ChangeIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ChangeIds");
            }
        }
    }
}
