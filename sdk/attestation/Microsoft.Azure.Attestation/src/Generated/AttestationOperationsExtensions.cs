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
    /// Extension methods for AttestationOperations.
    /// </summary>
    public static partial class AttestationOperationsExtensions
    {
            /// <summary>
            /// Attest to an SGX enclave.
            /// </summary>
            /// <remarks>
            /// Processes an OpenEnclave report , producing an artifact. The type of
            /// artifact produced is dependent upon attestation policy.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='instanceUrl'>
            /// The attestation instance base URI, for example
            /// https://mytenant.attest.azure.net.
            /// </param>
            /// <param name='request'>
            /// Request object containing the quote
            /// </param>
            public static AttestationResponse AttestOpenEnclave(this IAttestationOperations operations, string instanceUrl, AttestOpenEnclaveRequest request)
            {
                return operations.AttestOpenEnclaveAsync(instanceUrl, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Attest to an SGX enclave.
            /// </summary>
            /// <remarks>
            /// Processes an OpenEnclave report , producing an artifact. The type of
            /// artifact produced is dependent upon attestation policy.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='instanceUrl'>
            /// The attestation instance base URI, for example
            /// https://mytenant.attest.azure.net.
            /// </param>
            /// <param name='request'>
            /// Request object containing the quote
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AttestationResponse> AttestOpenEnclaveAsync(this IAttestationOperations operations, string instanceUrl, AttestOpenEnclaveRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AttestOpenEnclaveWithHttpMessagesAsync(instanceUrl, request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Attest to an SGX enclave.
            /// </summary>
            /// <remarks>
            /// Processes an SGX enclave quote, producing an artifact. The type of artifact
            /// produced is dependent upon attestation policy.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='instanceUrl'>
            /// The attestation instance base URI, for example
            /// https://mytenant.attest.azure.net.
            /// </param>
            /// <param name='request'>
            /// Request object containing the quote
            /// </param>
            public static AttestationResponse AttestSgxEnclave(this IAttestationOperations operations, string instanceUrl, AttestSgxEnclaveRequest request)
            {
                return operations.AttestSgxEnclaveAsync(instanceUrl, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Attest to an SGX enclave.
            /// </summary>
            /// <remarks>
            /// Processes an SGX enclave quote, producing an artifact. The type of artifact
            /// produced is dependent upon attestation policy.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='instanceUrl'>
            /// The attestation instance base URI, for example
            /// https://mytenant.attest.azure.net.
            /// </param>
            /// <param name='request'>
            /// Request object containing the quote
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AttestationResponse> AttestSgxEnclaveAsync(this IAttestationOperations operations, string instanceUrl, AttestSgxEnclaveRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AttestSgxEnclaveWithHttpMessagesAsync(instanceUrl, request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Attest a Virtualization-based Security (VBS) enclave.
            /// </summary>
            /// <remarks>
            /// Processes attestation evidence from a VBS enclave, producing an attestation
            /// result. The attestation result produced is dependent upon the attestation
            /// policy.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='instanceUrl'>
            /// The attestation instance base URI, for example
            /// https://mytenant.attest.azure.net.
            /// </param>
            /// <param name='request'>
            /// Request object
            /// </param>
            public static TpmAttestationResponse AttestTpm(this IAttestationOperations operations, string instanceUrl, TpmAttestationRequest request)
            {
                return operations.AttestTpmAsync(instanceUrl, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Attest a Virtualization-based Security (VBS) enclave.
            /// </summary>
            /// <remarks>
            /// Processes attestation evidence from a VBS enclave, producing an attestation
            /// result. The attestation result produced is dependent upon the attestation
            /// policy.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='instanceUrl'>
            /// The attestation instance base URI, for example
            /// https://mytenant.attest.azure.net.
            /// </param>
            /// <param name='request'>
            /// Request object
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TpmAttestationResponse> AttestTpmAsync(this IAttestationOperations operations, string instanceUrl, TpmAttestationRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AttestTpmWithHttpMessagesAsync(instanceUrl, request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
