// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Creator.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ConformanceResponse
    {
        /// <summary>
        /// Initializes a new instance of the ConformanceResponse class.
        /// </summary>
        public ConformanceResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConformanceResponse class.
        /// </summary>
        /// <param name="conformsTo">List of requirements classes that the
        /// server conforms to.</param>
        public ConformanceResponse(IList<string> conformsTo)
        {
            ConformsTo = conformsTo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of requirements classes that the server conforms
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "conformsTo")]
        public IList<string> ConformsTo { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ConformsTo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConformsTo");
            }
        }
    }
}
