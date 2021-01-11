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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PolicyOperations.
    /// </summary>
    public static partial class PolicyOperationsExtensions
    {
            /// <summary>
            /// Retrieves the current policy for an attestation type.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='instanceUrl'>
            /// The attestation instance base URI, for example
            /// https://mytenant.attest.azure.net.
            /// </param>
            /// <param name='attestationType'>
            /// Specifies the trusted execution environment to be used to validate the
            /// evidence. Possible values include: 'SgxEnclave', 'OpenEnclave', 'Tpm'
            /// </param>
            public static PolicyResponse Get(this IPolicyOperations operations, string instanceUrl, string attestationType)
            {
                return operations.GetAsync(instanceUrl, attestationType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the current policy for an attestation type.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='instanceUrl'>
            /// The attestation instance base URI, for example
            /// https://mytenant.attest.azure.net.
            /// </param>
            /// <param name='attestationType'>
            /// Specifies the trusted execution environment to be used to validate the
            /// evidence. Possible values include: 'SgxEnclave', 'OpenEnclave', 'Tpm'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyResponse> GetAsync(this IPolicyOperations operations, string instanceUrl, string attestationType, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(instanceUrl, attestationType, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets the policy for a given attestation type.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='instanceUrl'>
            /// The attestation instance base URI, for example
            /// https://mytenant.attest.azure.net.
            /// </param>
            /// <param name='attestationType'>
            /// Specifies the trusted execution environment to be used to validate the
            /// evidence. Possible values include: 'SgxEnclave', 'OpenEnclave', 'Tpm'
            /// </param>
            /// <param name='newAttestationPolicy'>
            /// JWT Expressing the new policy whose body is a StoredAttestationPolicy
            /// object.
            /// </param>
            public static PolicyResponse Set(this IPolicyOperations operations, string instanceUrl, string attestationType, string newAttestationPolicy)
            {
                return operations.SetAsync(instanceUrl, attestationType, newAttestationPolicy).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets the policy for a given attestation type.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='instanceUrl'>
            /// The attestation instance base URI, for example
            /// https://mytenant.attest.azure.net.
            /// </param>
            /// <param name='attestationType'>
            /// Specifies the trusted execution environment to be used to validate the
            /// evidence. Possible values include: 'SgxEnclave', 'OpenEnclave', 'Tpm'
            /// </param>
            /// <param name='newAttestationPolicy'>
            /// JWT Expressing the new policy whose body is a StoredAttestationPolicy
            /// object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyResponse> SetAsync(this IPolicyOperations operations, string instanceUrl, string attestationType, string newAttestationPolicy, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SetWithHttpMessagesAsync(instanceUrl, attestationType, newAttestationPolicy, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Resets the attestation policy for the specified tenant and reverts to the
            /// default policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='instanceUrl'>
            /// The attestation instance base URI, for example
            /// https://mytenant.attest.azure.net.
            /// </param>
            /// <param name='attestationType'>
            /// Specifies the trusted execution environment to be used to validate the
            /// evidence. Possible values include: 'SgxEnclave', 'OpenEnclave', 'Tpm'
            /// </param>
            /// <param name='policyJws'>
            /// JSON Web Signature with an empty policy document
            /// </param>
            public static PolicyResponse Reset(this IPolicyOperations operations, string instanceUrl, string attestationType, string policyJws)
            {
                return operations.ResetAsync(instanceUrl, attestationType, policyJws).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resets the attestation policy for the specified tenant and reverts to the
            /// default policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='instanceUrl'>
            /// The attestation instance base URI, for example
            /// https://mytenant.attest.azure.net.
            /// </param>
            /// <param name='attestationType'>
            /// Specifies the trusted execution environment to be used to validate the
            /// evidence. Possible values include: 'SgxEnclave', 'OpenEnclave', 'Tpm'
            /// </param>
            /// <param name='policyJws'>
            /// JSON Web Signature with an empty policy document
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyResponse> ResetAsync(this IPolicyOperations operations, string instanceUrl, string attestationType, string policyJws, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ResetWithHttpMessagesAsync(instanceUrl, attestationType, policyJws, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
