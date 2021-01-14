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
    /// Public certificate object
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PublicCertificate : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the PublicCertificate class.
        /// </summary>
        public PublicCertificate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublicCertificate class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource.</param>
        /// <param name="blob">Public Certificate byte array</param>
        /// <param name="publicCertificateLocation">Public Certificate
        /// Location. Possible values include: 'CurrentUserMy',
        /// 'LocalMachineMy', 'Unknown'</param>
        /// <param name="thumbprint">Certificate Thumbprint</param>
        public PublicCertificate(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), byte[] blob = default(byte[]), PublicCertificateLocation? publicCertificateLocation = default(PublicCertificateLocation?), string thumbprint = default(string))
            : base(id, name, kind, type, systemData)
        {
            Blob = blob;
            PublicCertificateLocation = publicCertificateLocation;
            Thumbprint = thumbprint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets public Certificate byte array
        /// </summary>
        [JsonProperty(PropertyName = "properties.blob")]
        public byte[] Blob { get; set; }

        /// <summary>
        /// Gets or sets public Certificate Location. Possible values include:
        /// 'CurrentUserMy', 'LocalMachineMy', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicCertificateLocation")]
        public PublicCertificateLocation? PublicCertificateLocation { get; set; }

        /// <summary>
        /// Gets certificate Thumbprint
        /// </summary>
        [JsonProperty(PropertyName = "properties.thumbprint")]
        public string Thumbprint { get; private set; }

    }
}
