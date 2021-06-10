// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Service.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The numeric type style rule object.
    /// </summary>
    [Newtonsoft.Json.JsonObject("number")]
    public partial class NumberTypeStyleRule : StyleObject
    {
        /// <summary>
        /// Initializes a new instance of the NumberTypeStyleRule class.
        /// </summary>
        public NumberTypeStyleRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NumberTypeStyleRule class.
        /// </summary>
        /// <param name="keyName">Stateset style key name. Key names are random
        /// strings but they should be unique inside style array.</param>
        /// <param name="rules">Numeric style rules.</param>
        public NumberTypeStyleRule(string keyName, IList<NumberRuleObject> rules)
            : base(keyName)
        {
            Rules = rules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets numeric style rules.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NumberRuleObject> Rules { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Rules == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Rules");
            }
        }
    }
}
