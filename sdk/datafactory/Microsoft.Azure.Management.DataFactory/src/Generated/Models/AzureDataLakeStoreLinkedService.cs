// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure Data Lake Store linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureDataLakeStore")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureDataLakeStoreLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the AzureDataLakeStoreLinkedService
        /// class.
        /// </summary>
        public AzureDataLakeStoreLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureDataLakeStoreLinkedService
        /// class.
        /// </summary>
        /// <param name="dataLakeStoreUri">Data Lake Store service URI. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the linked service.</param>
        /// <param name="servicePrincipalId">The ID of the application used to
        /// authenticate against the Azure Data Lake Store account. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="servicePrincipalKey">The Key of the application used
        /// to authenticate against the Azure Data Lake Store account.</param>
        /// <param name="tenant">The name or ID of the tenant to which the
        /// service principal belongs. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="azureCloudType">Indicates the azure cloud type of the
        /// service principle auth. Allowed values are AzurePublic, AzureChina,
        /// AzureUsGovernment, AzureGermany. Default value is the data factory
        /// regions’ cloud type. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="accountName">Data Lake Store account name. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="subscriptionId">Data Lake Store account subscription
        /// ID (if different from Data Factory account). Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="resourceGroupName">Data Lake Store account resource
        /// group name (if different from Data Factory account). Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="credential">The credential reference containing
        /// authentication information.</param>
        public AzureDataLakeStoreLinkedService(object dataLakeStoreUri, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), object servicePrincipalId = default(object), SecretBase servicePrincipalKey = default(SecretBase), object tenant = default(object), object azureCloudType = default(object), object accountName = default(object), object subscriptionId = default(object), object resourceGroupName = default(object), object encryptedCredential = default(object), CredentialReference credential = default(CredentialReference))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            DataLakeStoreUri = dataLakeStoreUri;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            AzureCloudType = azureCloudType;
            AccountName = accountName;
            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            EncryptedCredential = encryptedCredential;
            Credential = credential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets data Lake Store service URI. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.dataLakeStoreUri")]
        public object DataLakeStoreUri { get; set; }

        /// <summary>
        /// Gets or sets the ID of the application used to authenticate against
        /// the Azure Data Lake Store account. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the Key of the application used to authenticate
        /// against the Azure Data Lake Store account.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalKey")]
        public SecretBase ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets the name or ID of the tenant to which the service
        /// principal belongs. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tenant")]
        public object Tenant { get; set; }

        /// <summary>
        /// Gets or sets indicates the azure cloud type of the service
        /// principle auth. Allowed values are AzurePublic, AzureChina,
        /// AzureUsGovernment, AzureGermany. Default value is the data factory
        /// regions’ cloud type. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.azureCloudType")]
        public object AzureCloudType { get; set; }

        /// <summary>
        /// Gets or sets data Lake Store account name. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accountName")]
        public object AccountName { get; set; }

        /// <summary>
        /// Gets or sets data Lake Store account subscription ID (if different
        /// from Data Factory account). Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.subscriptionId")]
        public object SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets data Lake Store account resource group name (if
        /// different from Data Factory account). Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.resourceGroupName")]
        public object ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Gets or sets the credential reference containing authentication
        /// information.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.credential")]
        public CredentialReference Credential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (DataLakeStoreUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataLakeStoreUri");
            }
            if (Credential != null)
            {
                Credential.Validate();
            }
        }
    }
}
