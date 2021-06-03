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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SSL certificate for an app.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Certificate : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Certificate class.
        /// </summary>
        public Certificate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Certificate class.
        /// </summary>
        /// <param name="location">Resource Location.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="password">Certificate password.</param>
        /// <param name="friendlyName">Friendly name of the
        /// certificate.</param>
        /// <param name="subjectName">Subject name of the certificate.</param>
        /// <param name="hostNames">Host names the certificate applies
        /// to.</param>
        /// <param name="pfxBlob">Pfx blob.</param>
        /// <param name="siteName">App name.</param>
        /// <param name="selfLink">Self link.</param>
        /// <param name="issuer">Certificate issuer.</param>
        /// <param name="issueDate">Certificate issue Date.</param>
        /// <param name="expirationDate">Certificate expiration date.</param>
        /// <param name="thumbprint">Certificate thumbprint.</param>
        /// <param name="valid">Is the certificate valid?.</param>
        /// <param name="cerBlob">Raw bytes of .cer file</param>
        /// <param name="publicKeyHash">Public key hash.</param>
        /// <param name="hostingEnvironmentProfile">Specification for the App
        /// Service Environment to use for the certificate.</param>
        /// <param name="keyVaultId">Key Vault Csm resource Id.</param>
        /// <param name="keyVaultSecretName">Key Vault secret name.</param>
        /// <param name="keyVaultSecretStatus">Status of the Key Vault secret.
        /// Possible values include: 'Initialized',
        /// 'WaitingOnCertificateOrder', 'Succeeded', 'CertificateOrderFailed',
        /// 'OperationNotPermittedOnKeyVault',
        /// 'AzureServiceUnauthorizedToAccessKeyVault', 'KeyVaultDoesNotExist',
        /// 'KeyVaultSecretDoesNotExist', 'UnknownError', 'ExternalPrivateKey',
        /// 'Unknown'</param>
        /// <param name="serverFarmId">Resource ID of the associated App
        /// Service plan, formatted as:
        /// "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}".</param>
        /// <param name="canonicalName">CNAME of the certificate to be issued
        /// via free certificate</param>
        /// <param name="domainValidationMethod">Method of domain validation
        /// for free cert</param>
        public Certificate(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SystemData systemData = default(SystemData), string password = default(string), string friendlyName = default(string), string subjectName = default(string), IList<string> hostNames = default(IList<string>), byte[] pfxBlob = default(byte[]), string siteName = default(string), string selfLink = default(string), string issuer = default(string), System.DateTime? issueDate = default(System.DateTime?), System.DateTime? expirationDate = default(System.DateTime?), string thumbprint = default(string), bool? valid = default(bool?), byte[] cerBlob = default(byte[]), string publicKeyHash = default(string), HostingEnvironmentProfile hostingEnvironmentProfile = default(HostingEnvironmentProfile), string keyVaultId = default(string), string keyVaultSecretName = default(string), KeyVaultSecretStatus? keyVaultSecretStatus = default(KeyVaultSecretStatus?), string serverFarmId = default(string), string canonicalName = default(string), string domainValidationMethod = default(string))
            : base(location, id, name, kind, type, tags, systemData)
        {
            Password = password;
            FriendlyName = friendlyName;
            SubjectName = subjectName;
            HostNames = hostNames;
            PfxBlob = pfxBlob;
            SiteName = siteName;
            SelfLink = selfLink;
            Issuer = issuer;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Thumbprint = thumbprint;
            Valid = valid;
            CerBlob = cerBlob;
            PublicKeyHash = publicKeyHash;
            HostingEnvironmentProfile = hostingEnvironmentProfile;
            KeyVaultId = keyVaultId;
            KeyVaultSecretName = keyVaultSecretName;
            KeyVaultSecretStatus = keyVaultSecretStatus;
            ServerFarmId = serverFarmId;
            CanonicalName = canonicalName;
            DomainValidationMethod = domainValidationMethod;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets certificate password.
        /// </summary>
        [JsonProperty(PropertyName = "properties.password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets friendly name of the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlyName")]
        public string FriendlyName { get; private set; }

        /// <summary>
        /// Gets subject name of the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subjectName")]
        public string SubjectName { get; private set; }

        /// <summary>
        /// Gets or sets host names the certificate applies to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostNames")]
        public IList<string> HostNames { get; set; }

        /// <summary>
        /// Gets or sets pfx blob.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pfxBlob")]
        public byte[] PfxBlob { get; set; }

        /// <summary>
        /// Gets app name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.siteName")]
        public string SiteName { get; private set; }

        /// <summary>
        /// Gets self link.
        /// </summary>
        [JsonProperty(PropertyName = "properties.selfLink")]
        public string SelfLink { get; private set; }

        /// <summary>
        /// Gets certificate issuer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.issuer")]
        public string Issuer { get; private set; }

        /// <summary>
        /// Gets certificate issue Date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.issueDate")]
        public System.DateTime? IssueDate { get; private set; }

        /// <summary>
        /// Gets certificate expiration date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expirationDate")]
        public System.DateTime? ExpirationDate { get; private set; }

        /// <summary>
        /// Gets certificate thumbprint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.thumbprint")]
        public string Thumbprint { get; private set; }

        /// <summary>
        /// Gets is the certificate valid?.
        /// </summary>
        [JsonProperty(PropertyName = "properties.valid")]
        public bool? Valid { get; private set; }

        /// <summary>
        /// Gets raw bytes of .cer file
        /// </summary>
        [JsonProperty(PropertyName = "properties.cerBlob")]
        public byte[] CerBlob { get; private set; }

        /// <summary>
        /// Gets public key hash.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicKeyHash")]
        public string PublicKeyHash { get; private set; }

        /// <summary>
        /// Gets specification for the App Service Environment to use for the
        /// certificate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostingEnvironmentProfile")]
        public HostingEnvironmentProfile HostingEnvironmentProfile { get; private set; }

        /// <summary>
        /// Gets or sets key Vault Csm resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultId")]
        public string KeyVaultId { get; set; }

        /// <summary>
        /// Gets or sets key Vault secret name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultSecretName")]
        public string KeyVaultSecretName { get; set; }

        /// <summary>
        /// Gets status of the Key Vault secret. Possible values include:
        /// 'Initialized', 'WaitingOnCertificateOrder', 'Succeeded',
        /// 'CertificateOrderFailed', 'OperationNotPermittedOnKeyVault',
        /// 'AzureServiceUnauthorizedToAccessKeyVault', 'KeyVaultDoesNotExist',
        /// 'KeyVaultSecretDoesNotExist', 'UnknownError', 'ExternalPrivateKey',
        /// 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultSecretStatus")]
        public KeyVaultSecretStatus? KeyVaultSecretStatus { get; private set; }

        /// <summary>
        /// Gets or sets resource ID of the associated App Service plan,
        /// formatted as:
        /// "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}".
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverFarmId")]
        public string ServerFarmId { get; set; }

        /// <summary>
        /// Gets or sets CNAME of the certificate to be issued via free
        /// certificate
        /// </summary>
        [JsonProperty(PropertyName = "properties.canonicalName")]
        public string CanonicalName { get; set; }

        /// <summary>
        /// Gets or sets method of domain validation for free cert
        /// </summary>
        [JsonProperty(PropertyName = "properties.domainValidationMethod")]
        public string DomainValidationMethod { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
