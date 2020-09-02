// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure Active Directory only authentication.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServerAzureADOnlyAuthentication : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ServerAzureADOnlyAuthentication
        /// class.
        /// </summary>
        public ServerAzureADOnlyAuthentication()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerAzureADOnlyAuthentication
        /// class.
        /// </summary>
        /// <param name="azureADOnlyAuthentication">Azure Active Directory only
        /// Authentication enabled.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        public ServerAzureADOnlyAuthentication(bool azureADOnlyAuthentication, string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            AzureADOnlyAuthentication = azureADOnlyAuthentication;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets azure Active Directory only Authentication enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureADOnlyAuthentication")]
        public bool AzureADOnlyAuthentication { get; set; }

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
