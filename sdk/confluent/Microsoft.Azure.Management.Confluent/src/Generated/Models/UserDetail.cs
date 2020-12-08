// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Confluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Subscriber detail
    /// </summary>
    public partial class UserDetail
    {
        /// <summary>
        /// Initializes a new instance of the UserDetail class.
        /// </summary>
        public UserDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserDetail class.
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="emailAddress">Email address</param>
        public UserDetail(string firstName = default(string), string lastName = default(string), string emailAddress = default(string))
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets first name
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets last name
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets email address
        /// </summary>
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FirstName != null)
            {
                if (FirstName.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "FirstName", 50);
                }
            }
            if (LastName != null)
            {
                if (LastName.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "LastName", 50);
                }
            }
            if (EmailAddress != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(EmailAddress, "^\\S+@\\S+\\.\\S+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "EmailAddress", "^\\S+@\\S+\\.\\S+$");
                }
            }
        }
    }
}
