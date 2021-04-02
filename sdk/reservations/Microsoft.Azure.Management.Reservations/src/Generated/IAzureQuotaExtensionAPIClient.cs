// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Quota
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Microsoft Azure Quota Resource Provider.
    /// </summary>
    public partial interface IAzureQuotaExtensionAPIClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// API version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The target Azure resource Uri. Example -
        /// /subscriptions/9f6cce51-6baf-4de5-a3c4-6f58b85315b9/resourceGroups/qms-test/providers/Microsoft.Batch/batchAccounts/testAccount/.
        /// This will be the List API. If a {resourceName} is added after
        /// /quotaLimits, then it's a get Call for the specific resource.
        /// </summary>
        string ResourceUrl { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IQuotaOperations.
        /// </summary>
        IQuotaOperations Quota { get; }

        /// <summary>
        /// Gets the IQuotaRequestStatusOperations.
        /// </summary>
        IQuotaRequestStatusOperations QuotaRequestStatus { get; }

        /// <summary>
        /// Gets the IQuotaResourceProvidersOperations.
        /// </summary>
        IQuotaResourceProvidersOperations QuotaResourceProviders { get; }

        /// <summary>
        /// Gets the IQuotaTemplateDimensionTypesOperations.
        /// </summary>
        IQuotaTemplateDimensionTypesOperations QuotaTemplateDimensionTypes { get; }

        /// <summary>
        /// Gets the IOperationOperations.
        /// </summary>
        IOperationOperations Operation { get; }

    }
}
