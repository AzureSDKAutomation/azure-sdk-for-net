// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An instruction.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Instruction : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Instruction class.
        /// </summary>
        public Instruction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Instruction class.
        /// </summary>
        /// <param name="amount">The amount budgeted for this billing
        /// instruction.</param>
        /// <param name="startDate">The date this billing instruction goes into
        /// effect.</param>
        /// <param name="endDate">The date this billing instruction is no
        /// longer in effect.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="creationDate">The date this billing instruction was
        /// created.</param>
        public Instruction(double amount, System.DateTime startDate, System.DateTime endDate, string id = default(string), string name = default(string), string type = default(string), System.DateTime? creationDate = default(System.DateTime?))
            : base(id, name, type)
        {
            Amount = amount;
            StartDate = startDate;
            EndDate = endDate;
            CreationDate = creationDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the amount budgeted for this billing instruction.
        /// </summary>
        [JsonProperty(PropertyName = "properties.amount")]
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets the date this billing instruction goes into effect.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startDate")]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the date this billing instruction is no longer in
        /// effect.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endDate")]
        public System.DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the date this billing instruction was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
