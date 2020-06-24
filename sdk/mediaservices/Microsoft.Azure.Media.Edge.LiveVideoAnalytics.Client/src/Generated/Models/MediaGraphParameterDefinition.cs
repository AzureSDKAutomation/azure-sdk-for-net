// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Media.Edge.LiveVideoAnalytics.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A key, value pair. The graph topology can be authored with certain
    /// values with parameters. Then, during graph instance creation, the value
    /// for that parameters can be specified. This allows the same graph
    /// topology to be used as a blueprint for multiple graph instances with
    /// different values for the parameters.
    /// </summary>
    public partial class MediaGraphParameterDefinition
    {
        /// <summary>
        /// Initializes a new instance of the MediaGraphParameterDefinition
        /// class.
        /// </summary>
        public MediaGraphParameterDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaGraphParameterDefinition
        /// class.
        /// </summary>
        /// <param name="name">Name of parameter as defined in the graph
        /// topology.</param>
        /// <param name="value">Value of parameter.</param>
        public MediaGraphParameterDefinition(string name, string value)
        {
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of parameter as defined in the graph topology.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets value of parameter.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

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
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
