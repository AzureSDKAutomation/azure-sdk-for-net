// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataCollaboration.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A diagnostic policy.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DiagnosticLevel")]
    [Rest.Serialization.JsonTransformation]
    public partial class DiagnosticPolicy : Policy
    {
        /// <summary>
        /// Initializes a new instance of the DiagnosticPolicy class.
        /// </summary>
        public DiagnosticPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiagnosticPolicy class.
        /// </summary>
        /// <param name="logLevel">The policy log level. Possible values
        /// include: 'Verbose', 'Information', 'Warning', 'Error',
        /// 'Critical'</param>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="description">Description of the policy</param>
        public DiagnosticPolicy(string logLevel, string id = default(string), string name = default(string), string type = default(string), string description = default(string))
            : base(id, name, type)
        {
            Description = description;
            LogLevel = logLevel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets description of the policy
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the policy log level. Possible values include:
        /// 'Verbose', 'Information', 'Warning', 'Error', 'Critical'
        /// </summary>
        [JsonProperty(PropertyName = "properties.logLevel")]
        public string LogLevel { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LogLevel == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LogLevel");
            }
        }
    }
}
