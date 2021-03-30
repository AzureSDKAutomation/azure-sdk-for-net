// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// AdhocBasedTriggerContext
    /// </summary>
    /// <remarks>
    /// Adhoc trigger context
    /// </remarks>
    public partial class AdhocBasedTriggerContext : TriggerContext
    {
        /// <summary>
        /// Initializes a new instance of the AdhocBasedTriggerContext class.
        /// </summary>
        public AdhocBasedTriggerContext()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdhocBasedTriggerContext class.
        /// </summary>
        /// <param name="taggingCriteria">Tagging Criteria containing retention
        /// tag for adhoc backup.</param>
        public AdhocBasedTriggerContext(AdhocBasedTaggingCriteria taggingCriteria)
        {
            TaggingCriteria = taggingCriteria;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets tagging Criteria containing retention tag for adhoc
        /// backup.
        /// </summary>
        [JsonProperty(PropertyName = "taggingCriteria")]
        public AdhocBasedTaggingCriteria TaggingCriteria { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TaggingCriteria == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TaggingCriteria");
            }
            if (TaggingCriteria != null)
            {
                TaggingCriteria.Validate();
            }
        }
    }
}
