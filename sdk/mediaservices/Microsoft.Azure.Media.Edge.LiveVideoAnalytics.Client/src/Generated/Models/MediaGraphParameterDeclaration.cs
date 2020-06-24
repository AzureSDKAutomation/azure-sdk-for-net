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
    /// The declaration of a parameter in the graph topology. A graph topology
    /// can be authored with parameters. Then, during graph instance creation,
    /// the value for those parameters can be specified. This allows the same
    /// graph topology to be used as a blueprint for multiple graph instances
    /// with different values for the parameters.
    /// </summary>
    public partial class MediaGraphParameterDeclaration
    {
        /// <summary>
        /// Initializes a new instance of the MediaGraphParameterDeclaration
        /// class.
        /// </summary>
        public MediaGraphParameterDeclaration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaGraphParameterDeclaration
        /// class.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="type">Possible values include: 'String',
        /// 'SecretString', 'Int', 'Double', 'Bool'</param>
        /// <param name="description">Description of the parameter.</param>
        /// <param name="defaultProperty">The default value for the parameter,
        /// to be used if the graph instance does not specify a value.</param>
        public MediaGraphParameterDeclaration(string name, MediaGraphParameterType type, string description = default(string), string defaultProperty = default(string))
        {
            Name = name;
            Type = type;
            Description = description;
            DefaultProperty = defaultProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the parameter.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'String', 'SecretString',
        /// 'Int', 'Double', 'Bool'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public MediaGraphParameterType Type { get; set; }

        /// <summary>
        /// Gets or sets description of the parameter.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the default value for the parameter, to be used if the
        /// graph instance does not specify a value.
        /// </summary>
        [JsonProperty(PropertyName = "default")]
        public string DefaultProperty { get; set; }

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
            if (Name != null)
            {
                if (Name.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 64);
                }
            }
        }
    }
}
