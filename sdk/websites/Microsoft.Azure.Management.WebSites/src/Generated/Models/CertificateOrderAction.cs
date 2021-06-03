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
    /// Certificate order action.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CertificateOrderAction : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the CertificateOrderAction class.
        /// </summary>
        public CertificateOrderAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateOrderAction class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="actionType">Action type. Possible values include:
        /// 'CertificateIssued', 'CertificateOrderCanceled',
        /// 'CertificateOrderCreated', 'CertificateRevoked',
        /// 'DomainValidationComplete', 'FraudDetected', 'OrgNameChange',
        /// 'OrgValidationComplete', 'SanDrop', 'FraudCleared',
        /// 'CertificateExpired', 'CertificateExpirationWarning',
        /// 'FraudDocumentationRequired', 'Unknown'</param>
        /// <param name="createdAt">Time at which the certificate action was
        /// performed.</param>
        public CertificateOrderAction(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), CertificateOrderActionType? actionType = default(CertificateOrderActionType?), System.DateTime? createdAt = default(System.DateTime?))
            : base(id, name, kind, type, systemData)
        {
            ActionType = actionType;
            CreatedAt = createdAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets action type. Possible values include: 'CertificateIssued',
        /// 'CertificateOrderCanceled', 'CertificateOrderCreated',
        /// 'CertificateRevoked', 'DomainValidationComplete', 'FraudDetected',
        /// 'OrgNameChange', 'OrgValidationComplete', 'SanDrop',
        /// 'FraudCleared', 'CertificateExpired',
        /// 'CertificateExpirationWarning', 'FraudDocumentationRequired',
        /// 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.actionType")]
        public CertificateOrderActionType? ActionType { get; private set; }

        /// <summary>
        /// Gets time at which the certificate action was performed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

    }
}
