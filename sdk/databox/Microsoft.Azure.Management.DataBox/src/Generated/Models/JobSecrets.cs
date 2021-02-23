// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The base class for the secrets
    /// </summary>
    public partial class JobSecrets
    {
        /// <summary>
        /// Initializes a new instance of the JobSecrets class.
        /// </summary>
        public JobSecrets()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobSecrets class.
        /// </summary>
        /// <param name="dcAccessSecurityCode">Dc Access Security Code for
        /// Customer Managed Shipping</param>
        /// <param name="error">Error while fetching the secrets.</param>
        public JobSecrets(DcAccessSecurityCode dcAccessSecurityCode = default(DcAccessSecurityCode), CloudError error = default(CloudError))
        {
            DcAccessSecurityCode = dcAccessSecurityCode;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets dc Access Security Code for Customer Managed Shipping
        /// </summary>
        [JsonProperty(PropertyName = "dcAccessSecurityCode")]
        public DcAccessSecurityCode DcAccessSecurityCode { get; private set; }

        /// <summary>
        /// Gets error while fetching the secrets.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public CloudError Error { get; private set; }

    }
}
