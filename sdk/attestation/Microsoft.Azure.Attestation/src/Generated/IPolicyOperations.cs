// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Attestation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PolicyOperations operations.
    /// </summary>
    public partial interface IPolicyOperations
    {
        /// <summary>
        /// Retrieves the current policy for an attestation type.
        /// </summary>
        /// <param name='instanceUrl'>
        /// The attestation instance base URI, for example
        /// https://mytenant.attest.azure.net.
        /// </param>
        /// <param name='attestationType'>
        /// Specifies the trusted execution environment to be used to validate
        /// the evidence. Possible values include: 'SgxEnclave', 'OpenEnclave',
        /// 'Tpm'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PolicyResponse>> GetWithHttpMessagesAsync(string instanceUrl, string attestationType, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sets the policy for a given attestation type.
        /// </summary>
        /// <param name='instanceUrl'>
        /// The attestation instance base URI, for example
        /// https://mytenant.attest.azure.net.
        /// </param>
        /// <param name='attestationType'>
        /// Specifies the trusted execution environment to be used to validate
        /// the evidence. Possible values include: 'SgxEnclave', 'OpenEnclave',
        /// 'Tpm'
        /// </param>
        /// <param name='newAttestationPolicy'>
        /// JWT Expressing the new policy whose body is a
        /// StoredAttestationPolicy object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PolicyResponse>> SetWithHttpMessagesAsync(string instanceUrl, string attestationType, string newAttestationPolicy, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Resets the attestation policy for the specified tenant and reverts
        /// to the default policy.
        /// </summary>
        /// <param name='instanceUrl'>
        /// The attestation instance base URI, for example
        /// https://mytenant.attest.azure.net.
        /// </param>
        /// <param name='attestationType'>
        /// Specifies the trusted execution environment to be used to validate
        /// the evidence. Possible values include: 'SgxEnclave', 'OpenEnclave',
        /// 'Tpm'
        /// </param>
        /// <param name='policyJws'>
        /// JSON Web Signature with an empty policy document
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PolicyResponse>> ResetWithHttpMessagesAsync(string instanceUrl, string attestationType, string policyJws, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
