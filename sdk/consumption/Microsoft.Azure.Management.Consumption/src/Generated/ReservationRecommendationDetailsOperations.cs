// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ReservationRecommendationDetailsOperations operations.
    /// </summary>
    internal partial class ReservationRecommendationDetailsOperations : IServiceOperations<ConsumptionManagementClient>, IReservationRecommendationDetailsOperations
    {
        /// <summary>
        /// Initializes a new instance of the ReservationRecommendationDetailsOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        internal ReservationRecommendationDetailsOperations(ConsumptionManagementClient client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the ConsumptionManagementClient
        /// </summary>
        public ConsumptionManagementClient Client { get; private set; }

        /// <summary>
        /// Details of a reservation recommendation for what-if analysis of reserved
        /// instances.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
        /// </summary>
        /// <param name='scope'>
        /// The scope associated with reservation recommendation details operations.
        /// This includes '/subscriptions/{subscriptionId}/' for subscription scope,
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
        /// resource group scope,
        /// /providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
        /// BillingAccount scope, and
        /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
        /// for billingProfile scope
        /// </param>
        /// <param name='scope1'>
        /// Scope of the reservation. Possible values include: 'Single', 'Shared'
        /// </param>
        /// <param name='region'>
        /// Used to select the region the recommendation should be generated for.
        /// </param>
        /// <param name='term'>
        /// Specify length of reservation recommendation term. Possible values include:
        /// 'P1Y', 'P3Y'
        /// </param>
        /// <param name='lookBackPeriod'>
        /// Filter the time period on which reservation recommendation results are
        /// based. Possible values include: 'Last07Days', 'Last30Days', 'Last60Days'
        /// </param>
        /// <param name='product'>
        /// Filter the products for which reservation recommendation results are
        /// generated. Examples: Standard_DS1_v2 (for VM),
        /// Premium_SSD_Managed_Disks_P30 (for Managed Disks)
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HighCasedErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationResponse<ReservationRecommendationDetailsModel>> GetWithHttpMessagesAsync(string scope, string scope1, string region, string term, string lookBackPeriod, string product, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (Client.ApiVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "this.Client.ApiVersion");
            }
            if (scope == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "scope");
            }
            if (scope1 == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "scope1");
            }
            if (region == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "region");
            }
            if (term == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "term");
            }
            if (lookBackPeriod == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "lookBackPeriod");
            }
            if (product == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "product");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("scope", scope);
                tracingParameters.Add("scope1", scope1);
                tracingParameters.Add("region", region);
                tracingParameters.Add("term", term);
                tracingParameters.Add("lookBackPeriod", lookBackPeriod);
                tracingParameters.Add("product", product);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "Get", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "{scope}/providers/Microsoft.Consumption/reservationRecommendationDetails").ToString();
            _url = _url.Replace("{scope}", scope);
            List<string> _queryParameters = new List<string>();
            if (Client.ApiVersion != null)
            {
                _queryParameters.Add(string.Format("api-version={0}", System.Uri.EscapeDataString(Client.ApiVersion)));
            }
            if (scope1 != null)
            {
                _queryParameters.Add(string.Format("scope={0}", System.Uri.EscapeDataString(scope1)));
            }
            if (region != null)
            {
                _queryParameters.Add(string.Format("region={0}", System.Uri.EscapeDataString(region)));
            }
            if (term != null)
            {
                _queryParameters.Add(string.Format("term={0}", System.Uri.EscapeDataString(term)));
            }
            if (lookBackPeriod != null)
            {
                _queryParameters.Add(string.Format("lookBackPeriod={0}", System.Uri.EscapeDataString(lookBackPeriod)));
            }
            if (product != null)
            {
                _queryParameters.Add(string.Format("product={0}", System.Uri.EscapeDataString(product)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (Client.GenerateClientRequestId != null && Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", System.Guid.NewGuid().ToString());
            }
            if (Client.AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", Client.AcceptLanguage);
            }


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200 && (int)_statusCode != 204)
            {
                var ex = new HighCasedErrorResponseException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    HighCasedErrorResponse _errorBody =  Rest.Serialization.SafeJsonConvert.DeserializeObject<HighCasedErrorResponse>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new AzureOperationResponse<ReservationRecommendationDetailsModel>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
            }
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Rest.Serialization.SafeJsonConvert.DeserializeObject<ReservationRecommendationDetailsModel>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
