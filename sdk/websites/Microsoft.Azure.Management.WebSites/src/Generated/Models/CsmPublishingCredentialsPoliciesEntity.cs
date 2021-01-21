// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Publishing Credentials Policies parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CsmPublishingCredentialsPoliciesEntity : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CsmPublishingCredentialsPoliciesEntity class.
        /// </summary>
        public CsmPublishingCredentialsPoliciesEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CsmPublishingCredentialsPoliciesEntity class.
        /// </summary>
        /// <param name="allow">&lt;code&gt;true&lt;/code&gt; to allow access
        /// to a publishing method; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource.</param>
        public CsmPublishingCredentialsPoliciesEntity(bool allow, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData))
            : base(id, name, kind, type, systemData)
        {
            Allow = allow;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; to allow
        /// access to a publishing method; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allow")]
        public bool Allow { get; set; }

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
