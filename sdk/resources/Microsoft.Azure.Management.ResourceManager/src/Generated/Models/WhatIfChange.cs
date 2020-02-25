// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information about a single resource change predicted by What-If
    /// operation.
    /// </summary>
    public partial class WhatIfChange
    {
        /// <summary>
        /// Initializes a new instance of the WhatIfChange class.
        /// </summary>
        public WhatIfChange()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WhatIfChange class.
        /// </summary>
        /// <param name="resourceId">Resource ID</param>
        /// <param name="changeType">Type of change that will be made to the
        /// resource when the deployment is executed. Possible values include:
        /// 'Create', 'Delete', 'Ignore', 'Deploy', 'NoChange',
        /// 'Modify'</param>
        /// <param name="before">The snapshot of the resource before the
        /// deployment is executed.</param>
        /// <param name="after">The predicted snapshot of the resource after
        /// the deployment is executed.</param>
        /// <param name="delta">The predicted changes to resource
        /// properties.</param>
        public WhatIfChange(string resourceId, ChangeType changeType, object before = default(object), object after = default(object), IList<WhatIfPropertyChange> delta = default(IList<WhatIfPropertyChange>))
        {
            ResourceId = resourceId;
            ChangeType = changeType;
            Before = before;
            After = after;
            Delta = delta;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource ID
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets type of change that will be made to the resource when
        /// the deployment is executed. Possible values include: 'Create',
        /// 'Delete', 'Ignore', 'Deploy', 'NoChange', 'Modify'
        /// </summary>
        [JsonProperty(PropertyName = "changeType")]
        public ChangeType ChangeType { get; set; }

        /// <summary>
        /// Gets or sets the snapshot of the resource before the deployment is
        /// executed.
        /// </summary>
        [JsonProperty(PropertyName = "before")]
        public object Before { get; set; }

        /// <summary>
        /// Gets or sets the predicted snapshot of the resource after the
        /// deployment is executed.
        /// </summary>
        [JsonProperty(PropertyName = "after")]
        public object After { get; set; }

        /// <summary>
        /// Gets or sets the predicted changes to resource properties.
        /// </summary>
        [JsonProperty(PropertyName = "delta")]
        public IList<WhatIfPropertyChange> Delta { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceId");
            }
            if (Delta != null)
            {
                foreach (var element in Delta)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
