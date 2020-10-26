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
    using System.Linq;

    /// <summary>
    /// The application package contact information.
    /// </summary>
    public partial class ApplicationPackageContact
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationPackageContact class.
        /// </summary>
        public ApplicationPackageContact()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationPackageContact class.
        /// </summary>
        /// <param name="email">The contact email.</param>
        /// <param name="phone">The contact phone number.</param>
        /// <param name="contactName">The contact name.</param>
        public ApplicationPackageContact(string email, string phone, string contactName = default(string))
        {
            ContactName = contactName;
            Email = email;
            Phone = phone;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the contact name.
        /// </summary>
        [JsonProperty(PropertyName = "contactName")]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or sets the contact email.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the contact phone number.
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Email == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Email");
            }
            if (Phone == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Phone");
            }
        }
    }
}
