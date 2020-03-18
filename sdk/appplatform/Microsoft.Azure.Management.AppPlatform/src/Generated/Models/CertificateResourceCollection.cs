// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection compose of certificate resources list and a possible link
    /// for next page.
    /// </summary>
    public partial class CertificateResourceCollection
    {
        /// <summary>
        /// Initializes a new instance of the CertificateResourceCollection
        /// class.
        /// </summary>
        public CertificateResourceCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateResourceCollection
        /// class.
        /// </summary>
        /// <param name="value">The certificate resources list.</param>
        /// <param name="nextLink">The link to next page of certificate
        /// list.</param>
        public CertificateResourceCollection(IList<CertificateResource> value = default(IList<CertificateResource>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the certificate resources list.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<CertificateResource> Value { get; set; }

        /// <summary>
        /// Gets or sets the link to next page of certificate list.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
