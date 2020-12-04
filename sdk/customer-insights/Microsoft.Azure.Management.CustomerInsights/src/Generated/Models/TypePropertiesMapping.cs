// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Metadata for a Link's property mapping.
    /// </summary>
    public partial class TypePropertiesMapping
    {
        /// <summary>
        /// Initializes a new instance of the TypePropertiesMapping class.
        /// </summary>
        public TypePropertiesMapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TypePropertiesMapping class.
        /// </summary>
        /// <param name="sourcePropertyName"> Property name on the source
        /// Entity Type.</param>
        /// <param name="targetPropertyName">Property name on the target Entity
        /// Type.</param>
        /// <param name="linkType">Link type. Possible values include:
        /// 'UpdateAlways', 'CopyIfNull'</param>
        public TypePropertiesMapping(string sourcePropertyName, string targetPropertyName, LinkTypes? linkType = default(LinkTypes?))
        {
            SourcePropertyName = sourcePropertyName;
            TargetPropertyName = targetPropertyName;
            LinkType = linkType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets  Property name on the source Entity Type.
        /// </summary>
        [JsonProperty(PropertyName = "sourcePropertyName")]
        public string SourcePropertyName { get; set; }

        /// <summary>
        /// Gets or sets property name on the target Entity Type.
        /// </summary>
        [JsonProperty(PropertyName = "targetPropertyName")]
        public string TargetPropertyName { get; set; }

        /// <summary>
        /// Gets or sets link type. Possible values include: 'UpdateAlways',
        /// 'CopyIfNull'
        /// </summary>
        [JsonProperty(PropertyName = "linkType")]
        public LinkTypes? LinkType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SourcePropertyName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourcePropertyName");
            }
            if (TargetPropertyName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetPropertyName");
            }
        }
    }
}
