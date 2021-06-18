// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.WFS.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DefinitionProperties
    {
        /// <summary>
        /// Initializes a new instance of the DefinitionProperties class.
        /// </summary>
        public DefinitionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DefinitionProperties class.
        /// </summary>
        /// <param name="name">name of attribute</param>
        /// <param name="required">is attribute required</param>
        /// <param name="type">type of attribute</param>
        public DefinitionProperties(string name, bool required, object type)
        {
            Name = name;
            Required = required;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of attribute
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets is attribute required
        /// </summary>
        [JsonProperty(PropertyName = "required")]
        public bool Required { get; set; }

        /// <summary>
        /// Gets or sets type of attribute
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public object Type { get; set; }

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
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
